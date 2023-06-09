using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KDH_Bounce : MonoBehaviour
{
	public float force = 100f; //Force 10000f
	public float stunTime = 0.5f;
	private Vector3 hitDir;
    //public Rigidbody rb;

    private void OnTriggerEnter(Collider other)
    {
        //if (other.gameObject.tag == "Player")
        //{
        //    rb.AddForce(Vector3.up * force, ForceMode.Impulse);
        //    print("dfadf");

        //    return;
        //}

        CharacterController cc = other.GetComponent<CharacterController>();
        if (cc != null)
        {
            print("dsafsdfsd");
            Vector3 bounceDirection = Vector3.up;
            //rb.AddForce(bounceDirection * force, ForceMode.Impulse);
            cc.Move(bounceDirection * force);
        }
    }

    //void OnCollisionEnter(Collision collision)
    //{
    //    foreach (ContactPoint contact in collision.contacts)
    //    {
    //        Debug.DrawRay(contact.point, contact.normal, Color.white);
    //        if (collision.gameObject.tag == "Player")
    //        {
    //            hitDir = contact.normal;
    //            //rb.AddForce(new Vector3(0f, 5f, 0f), ForceMode.Impulse);
    //            return;
    //        }
    //    }


        /*if (collision.relativeVelocity.magnitude > 2)
		{
			if (collision.gameObject.tag == "Player")
			{
				//Debug.Log("Hit");
				collision.gameObject.GetComponent<CharacterControls>().HitPlayer(-hitDir*force, stunTime);
			}
			//audioSource.Play();
		}*/
    
}
