﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gamerespawn : MonoBehaviour
{
    public float threshold;

    private void FixedUpdate()
    {
        if(transform.position.y < threshold)
        {
            transform.position = new Vector3(0f,1.5f, 0f);
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}