using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KDH_Hit : MonoBehaviour
{
    public float force = 100f; //Force 10000f
    public float stunTime = 0.5f;
    private Vector3 hitDir;
    public GameObject player;
    bool bHit = false;
    float currTime = 0;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            bHit = true;
            hitDir = player.transform.position - transform.position;
        }
    }

    void Update()
    {
        if (bHit)
        {
            player.transform.position += hitDir * force * Time.deltaTime;
            force += 10f;
            currTime += Time.deltaTime;
            if (currTime > stunTime)
            {
                bHit = false;
                currTime = 0;
                force = 100;
            }
        }
    }
}
