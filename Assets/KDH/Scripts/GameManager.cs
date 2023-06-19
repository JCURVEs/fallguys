using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public GameObject escMenu;
    //public static GameManager instance;

    //private void Awake()
    //{
    //    if (instance == null)
    //    {
    //        instance = this;
    //        DontDestroyOnLoad(gameObject);
    //    }
    //    else
    //    {
    //        Destroy(gameObject);
    //    }ad
    //}

    // Start is called before the first frame update
    void Start()
    {
        escMenu = GameObject.Find("Image ESC");
        escMenu.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            if(escMenu.activeSelf)
            {
                escMenu.SetActive(false);
            }
            else
            {
                escMenu.SetActive(true);
            }
        }
    }

    public void OnMyStart()
    {
        SceneManager.LoadScene(2);
    }

    public void OnMyQuit()
    {
        #if UNITY_EDITOR
                UnityEditor.EditorApplication.isPlaying = false;
        #else
                Application.Quit(); // 어플리케이션 종료
        #endif
    }

    public void OnMyESCNo()
    {
        escMenu.SetActive(false);
    }

    public void OnMyLobby()
    {
        SceneManager.LoadScene(1);
    }

}
