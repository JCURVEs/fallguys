using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KDH_Enemy : MonoBehaviour
{
    public float speed = 10;
    float currTime = 0;
    public float jumpTime = 2;
    bool bJumping = false;
    public Rigidbody rb;
    Quaternion desiredRotation = Quaternion.Euler(0, 0, 0);
    public Vector3 checkPoint;
    GameObject countdownTimer;
    Vector3 startPosition;
    Vector3 dir;
    int rand;
    public GameObject target;

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
            transform.position = startPosition;
        }      

        else
        {
            //if(Random.Range(0,10) > 3)
            {
                dir = target.transform.position - transform.position;
                dir.Normalize();
            }
            //else
            //{
            //    dir = Vector3.up;
            //}
            transform.position += dir * speed * Time.deltaTime;

            currTime += Time.deltaTime;

            if (currTime > jumpTime)
            {
                if (!bJumping)
                {
                    rb.AddForce(Vector3.up * 5, ForceMode.VelocityChange);
                }
                currTime = 0;
            }
            transform.rotation = desiredRotation;
        }       
    }

    public void LoadCheckPoint()
    {
        transform.position = checkPoint;
    }
}
