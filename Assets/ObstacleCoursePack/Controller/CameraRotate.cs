﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraRotate : MonoBehaviour
{
    float rx, ry;
    public float rotSpeed = 200;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float mx = Input.GetAxis("Mouse X");
        float my = Input.GetAxis("Mouse Y");

        rx += my * rotSpeed * Time.deltaTime;
        ry += mx * rotSpeed * Time.deltaTime;

        rx = Mathf.Clamp(rx, -70, 70);

        transform.eulerAngles = new Vector3(-rx, ry, 0);


    }
}
