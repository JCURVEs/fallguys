using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SavePos : MonoBehaviour
{
	public Transform checkPoint;
    public AudioSource checkPointSound;

	void OnTriggerEnter(Collider col)
	{
		if (col.gameObject.tag == "Player")
		{
			col.gameObject.GetComponent<CharacterControls>().checkPoint = checkPoint.position;
		}
        else if (col.gameObject.tag == "Enemy")
        {
            col.gameObject.GetComponent<KDH_Enemy>().checkPoint = checkPoint.position;
        }
        checkPointSound.Stop();
        checkPointSound.Play();
    }
}
