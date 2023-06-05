using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpDown : MonoBehaviour
{
    float speed = 5;
    float currTime = 0;
    float moveTime = 2;
    bool bUp = true;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        currTime += Time.deltaTime;        

        if (bUp)
        {
            transform.position += Vector3.up * speed * Time.deltaTime;
            
        }
        else
        {
            transform.position += Vector3.down * speed * Time.deltaTime;
            
        }

        if (currTime > moveTime)
        {
            if (bUp)
            {
                bUp = false;
                currTime = 0;
            }
            else
            {
                bUp = true;
                currTime = 0;
            }
        }
    }
}
