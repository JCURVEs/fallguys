using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SavePos : MonoBehaviour
{
	public Transform checkPoint;
    public AudioSource checkPointSound;
    public GameObject vfx;
    bool check = false;

    private void Start()
    {
        vfx.SetActive(false);
    }

    void OnTriggerEnter(Collider col)
	{
		if (col.gameObject.tag == "Player")
		{
			col.gameObject.GetComponent<CharacterControls>().checkPoint = checkPoint.position;
            if(!check)
            {
                vfx.SetActive(true);
                checkPointSound.Play();
                check = true;
                vfx.transform.position = col.gameObject.transform.position+ new Vector3(0,1,0);
            }
            
		}
        else if (col.gameObject.tag == "Enemy")
        {
            col.gameObject.GetComponent<KDH_Enemy>().checkPoint = checkPoint.position;
        }
    }
}
