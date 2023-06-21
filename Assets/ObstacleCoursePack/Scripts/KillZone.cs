using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class KillZone : MonoBehaviour
{
    public AudioSource respawnSound;
    public GameObject vfx;

    private void Start()
    {
        vfx.SetActive(false);
    }

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {
			col.gameObject.GetComponent<CharacterControls>().LoadCheckPoint();
            respawnSound.Stop();
            respawnSound.Play();
            vfx.SetActive(true);
            vfx.transform.position = col.gameObject.transform.position + new Vector3(0, 1, 0);


        }
        else if(col.gameObject.tag == "Enemy")
        {
            col.gameObject.GetComponent<KDH_Enemy>().LoadCheckPoint();
        }
        
	}
}
