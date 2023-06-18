using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallPlat : MonoBehaviour
{
    private bool isPlayerOnPlatform = false;
    private WaitForSeconds disappearTime = new WaitForSeconds(0.5f);
    float currTime = 0;
    float moveTime = 0.1f;
    bool bMove = true;
    Vector3 startPosition;

    private void Start()
    {
        startPosition = transform.position;
    }

    private void Update()
    {
        currTime += Time.deltaTime;
        if(isPlayerOnPlatform)
        {
            if(currTime>moveTime)
            {
                if(bMove)
                {
                    transform.position += Vector3.forward * 50 * Time.deltaTime;
                    transform.position += Vector3.right * 50 * Time.deltaTime;                    
                    currTime = 0;
                    bMove = false;
                }
                else
                {
                    transform.position -= Vector3.forward * 50 * Time.deltaTime;
                    transform.position -= Vector3.right * 50 * Time.deltaTime;
                    currTime = 0;
                    bMove = true;                    
                }
            }        
        }
    }

    private void OnCollisionEnter(Collision collision)
    {        
        if (!isPlayerOnPlatform)
        {
            isPlayerOnPlatform = true;
            StartCoroutine(DisappearPlatform());
        }        
    }

    private IEnumerator DisappearPlatform()
    {
        yield return disappearTime;

        // Disable the platform renderer and collider
        GetComponent<Renderer>().enabled = false;
        GetComponent<Collider>().enabled = false;

        yield return new WaitForSeconds(1f);

        transform.position = startPosition;
        // Enable the platform renderer and collider
        GetComponent<Renderer>().enabled = true;
        GetComponent<Collider>().enabled = true;

        isPlayerOnPlatform = false;
    }
}
