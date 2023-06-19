using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KDH_RaceSceneManger : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip soundClip;

    private void Start()
    {
        StartCoroutine(PlaySoundDelayed());
    }

    private IEnumerator PlaySoundDelayed()
    {
        yield return new WaitForSeconds(4.5f); // Wait for 3 seconds

        audioSource.PlayOneShot(soundClip);
    }
}
