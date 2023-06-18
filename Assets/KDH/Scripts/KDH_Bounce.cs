using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KDH_Bounce : MonoBehaviour
{
    public float force = 10f; //Force 10000f
    public float stunTime = 0.5f;
    private Vector3 hitDir;
    bool bBounce = false;
    float currTime = 0;
    float scaleTime = 1;

    private void Update()
    {
        //currTime += Time.deltaTime;

        //if(bBounce)
        //{
        //    transform.localScale += new Vector3(1, 1, 1);

        //    if(currTime> scaleTime)
        //    {
        //        bBounce = false;
        //        currTime = 0;
        //    }
        //}
        //else
        //{
        //    if (currTime > scaleTime)
        //    {
        //        transform.localScale -= new Vector3(1, 1, 1);
        //        bBounce = false;
        //    }
        //}
    }

    void OnCollisionEnter(Collision collision)
    {
        foreach (ContactPoint contact in collision.contacts)
        {
            Debug.DrawRay(contact.point, contact.normal, Color.white);
            if (collision.gameObject.tag == "Player")
            {
                hitDir = contact.normal;
                collision.gameObject.GetComponent<CharacterControls>().HitPlayer(-hitDir * force, stunTime);
                return;
            }
            else
            {
                collision.gameObject.GetComponent<Rigidbody>().AddForce(Vector3.up * 10, ForceMode.VelocityChange);
            }
        }
        bBounce = true;
    }
}
