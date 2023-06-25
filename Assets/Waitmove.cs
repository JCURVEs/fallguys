using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Waitmove : MonoBehaviour
{
    GameObject pink;

    public float speed = 1f;
    float currentTime;
    public float moveTime = 1f;
    public Vector3 target;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        currentTime += Time.deltaTime;

        if (currentTime > moveTime && currentTime < 9)
        {
            transform.position = target;

        }
        else
        {
            transform.position += Vector3.down * speed * Time.deltaTime;

        }
    }
}
