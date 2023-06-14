using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class KillZone : MonoBehaviour
{
    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {
			col.gameObject.GetComponent<CharacterControls>().LoadCheckPoint();
		}
        else if(col.gameObject.tag == "Enemy")
        {
            col.gameObject.GetComponent<KDH_Enemy>().LoadCheckPoint();
        }
	}
}
