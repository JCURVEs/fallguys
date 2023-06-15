using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KDH_GroundCheck : MonoBehaviour
{
    public float groundCheckDistance = 0.1f;
    public LayerMask groundLayer;
    public Animator animator;
    private bool isGrounded;

    private void Start()
    {

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
                isGrounded = true;
            }
        }
        else
        {
            isGrounded = false;

        }
        animator.SetBool("isGrounded", isGrounded);
    }

    public bool IsGrounded()
    {
        return isGrounded;
    }
}
