using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftRight : MonoBehaviour
{
    public float speed = 5;
    float currTime = 0;
    float moveTime = 2;
    bool bRight = true;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        currTime += Time.deltaTime;

        if (bRight)
        {
            transform.position += Vector3.right * speed * Time.deltaTime;

        }
        else
        {
            transform.position += Vector3.left * speed * Time.deltaTime;

        }

        if (currTime > moveTime)
        {
            if (bRight)
            {
                bRight = false;
                currTime = 0;
            }
            else
            {
                bRight = true;
                currTime = 0;
            }
        }
    }
}

