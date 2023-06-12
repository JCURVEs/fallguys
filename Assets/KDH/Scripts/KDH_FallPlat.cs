using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KDH_FallPlat : MonoBehaviour
{
    public float fallTime = 0.5f;

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            StartCoroutine(Fall(fallTime));
        }
    }

    IEnumerator Fall(float time)
    {
        yield return new WaitForSeconds(time);
        Destroy(gameObject);
    }
}
