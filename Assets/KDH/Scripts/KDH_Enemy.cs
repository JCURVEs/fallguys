using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KDH_Enemy : MonoBehaviour
{
    public float minSpeed = 5;
    public float maxSpeed = 10;
    float speed;
    float currTime = 0;
    float jumpTime = 2;
    bool bJumping = false;
    Quaternion desiredRotation = Quaternion.Euler(0, 0, 0);
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        speed = Random.Range(minSpeed, maxSpeed);
        transform.position += transform.forward * speed * Time.deltaTime;

        currTime += Time.deltaTime;
        if(currTime < jumpTime)
        {
            if(!bJumping)
            {
                transform.position += transform.up * speed * Time.deltaTime;
            }
        }
        currTime = 0;
        transform.rotation = desiredRotation;
    }
}
