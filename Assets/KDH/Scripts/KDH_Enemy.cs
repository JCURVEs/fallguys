using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KDH_Enemy : MonoBehaviour
{
    float speed = 9;
    float currTime = 0;
    float jumpTime = 2;
    //bool bJumping = false;
    public Rigidbody rb;
    Quaternion desiredRotation = Quaternion.Euler(0, 0, 0);
    public Vector3 checkPoint;
    GameObject countdownTimer;
    Vector3 startPosition;
    Vector3 dir;
    public GameObject target;
    public KDH_GroundCheck groundcheck;
    public Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        startPosition = transform.position;
        countdownTimer = GameObject.Find("CountDown");
    }

    // Update is called once per frame
    void Update()
    {
        if (countdownTimer)
        {
            anim.SetBool("Run", false);
            transform.position = startPosition;
        }      

        else
        {
            //anim.SetBool("Run", true);
            //anim.SetBool("Idle", false);
            dir = target.transform.position - transform.position;
            dir.Normalize();
            transform.position += dir * speed * Time.deltaTime;
            currTime += Time.deltaTime;
                         
            if (currTime > jumpTime)
            {                
                rb.AddForce(Vector3.up * 5, ForceMode.VelocityChange);
                currTime = 0;
            } 
            
            if(groundcheck.IsGrounded())
            {
                anim.SetBool("Run", true);
                anim.SetBool("Jump", false);
            }            
            else
            {
                anim.SetBool("Run", false);
                anim.SetBool("Jump", true);
            }
            transform.rotation = desiredRotation;
        }       
    }

    public void LoadCheckPoint()
    {
        int rand = Random.Range(-10, 10);
        transform.position = checkPoint + new Vector3(rand, 0, 0);
    }
}
