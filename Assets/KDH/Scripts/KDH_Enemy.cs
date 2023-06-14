using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KDH_Enemy : MonoBehaviour
{
    //public float minSpeed = 5;
    //public float maxSpeed = 10;
    public float speed = 4;
    float currTime = 0;
    public float jumpTime = 2;
    bool bJumping = false;
    public Rigidbody rb;
    Quaternion desiredRotation = Quaternion.Euler(0, 0, 0);
    public Vector3 checkPoint;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //speed = Random.Range(minSpeed, maxSpeed);
        transform.position += transform.forward * speed * Time.deltaTime;

        currTime += Time.deltaTime;

        if (currTime > jumpTime)
        {
            if(!bJumping)
            {
                rb.AddForce(Vector3.up * 5, ForceMode.VelocityChange);
            }
            currTime = 0;
        }
        
        transform.rotation = desiredRotation;
    }

    public void LoadCheckPoint()
    {
        transform.position = checkPoint;
    }
}
