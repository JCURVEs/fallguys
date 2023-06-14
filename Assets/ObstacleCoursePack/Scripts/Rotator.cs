using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{
	public float speed = 3f;
    float randomTime;
    float currTime = 0;

    private void Awake()
    {
        randomTime = Random.Range(0, 2);
    }

    // Update is called once per frame
    void Update()
    {
        currTime += Time.deltaTime;
        if (currTime > randomTime)
        {
		    transform.Rotate(0f, 0f, speed * Time.deltaTime / 0.01f, Space.Self);
        }
	}
}
