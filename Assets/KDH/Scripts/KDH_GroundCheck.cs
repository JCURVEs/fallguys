using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class KDH_GroundCheck : MonoBehaviour
{
    public float groundCheckDistance = 1f;
    public LayerMask groundLayer;
    public Animator animator;
    private bool isGrounded;
    private bool isMute = true;
    public AudioClip loadingfallClip;
    public AudioSource audioSource;
    float fallTimer = 0;
    float fallInterval = 0.8f;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
        //animator = GetComponent<Animator>();
    }

    private void Update()
    {
        // Cast a ray or sphere downwards to check for ground collision
        RaycastHit hit;
        if (Physics.Raycast(transform.position, Vector3.down, out hit, groundCheckDistance, groundLayer)
            || Physics.SphereCast(transform.position, GetComponent<Collider>().bounds.extents.x, Vector3.down, out hit, groundCheckDistance, groundLayer))
        {
            // Check if the hit object is tagged as "Ground" or any other desired ground layer
            if (hit.collider.CompareTag("Ground"))
            {
                isMute = true;
                isGrounded = true;
                animator.SetBool("isFlying", false);
                fallTimer = 0;
            }
        }        
        else
        {
            isGrounded = false;
            fallTimer += Time.deltaTime;

            if (isMute && fallTimer>fallInterval)
            {
                OnPlay();

                animator.SetBool("isFlying", true);
                animator.SetBool("Jump", false);
            } 
        }
        animator.SetBool("isGrounded", isGrounded);
    }
    public void OnPlay()
    {
        audioSource.PlayOneShot(loadingfallClip);
        isMute = false;
    }
    public bool IsGrounded()
    {
        return isGrounded;
    }
}
