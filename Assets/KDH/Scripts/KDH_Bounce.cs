using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KDH_Bounce : MonoBehaviour
{
	public float force = 1;
	public float jumpTime = 0.5f;
    public GameObject player;   
    bool bJumping = false;
    float currTime = 0;


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            bJumping = true;
            player.GetComponent<PlayerController>().verticalVelocity = 15;
        }
    }

    void Update()
    {
        //if(bJumping)
        //{
        //    player.GetComponent<PlayerController>().characterController.enabled = false;
        //    player.transform.position += Vector3.up * force * Time.deltaTime;
        //    force += 0.15f;
        //    currTime += Time.deltaTime;
        //    if (currTime > jumpTime)
        //    {
        //        bJumping = false;
        //        currTime = 0;
        //        force = 1;
        //        player.GetComponent<PlayerController>().characterController.enabled = true;

        //    }
        //}
    }
}
