using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class KDH_LoadingSceneManager : MonoBehaviour
{
    public GameObject bgm;

    // Start is called before the first frame update
    void Start()
    {
        bgm = GameObject.Find("BGMManager");
        StartCoroutine(NextScene());
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    IEnumerator NextScene()
    {
        yield return new WaitForSeconds(10f);

        Destroy(bgm.gameObject);
        SceneManager.LoadScene(3);

    }
}
