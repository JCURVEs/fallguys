using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class KillZone : MonoBehaviour
{
    public AudioSource respawnSound;

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {
			col.gameObject.GetComponent<CharacterControls>().LoadCheckPoint();
            respawnSound.Stop();
            respawnSound.Play();
        }
        else if(col.gameObject.tag == "Enemy")
        {
            col.gameObject.GetComponent<KDH_Enemy>().LoadCheckPoint();
        }
        
	}
}
