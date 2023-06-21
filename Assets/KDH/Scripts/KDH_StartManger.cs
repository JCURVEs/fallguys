using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class KDH_StartManger : MonoBehaviour
{
    public AudioClip logoClickSound;
    private AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        audioSource = gameObject.AddComponent<AudioSource>();
        audioSource.clip = logoClickSound;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.anyKeyDown)
        {
            // Start the game
            audioSource.Play();
            StartCoroutine(NextScene());
        }
    }

    private IEnumerator NextScene()
    {

        yield return new WaitForSeconds(1.5f);

        SceneManager.LoadScene(1);
    }
}
