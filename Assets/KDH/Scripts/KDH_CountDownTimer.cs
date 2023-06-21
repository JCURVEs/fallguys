using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KDH_CountDownTimer : MonoBehaviour
{
    float currTime = 0;
    float startTime = 3.5f;
    public Text countdownText;
    public GameObject player;
    Vector3 startPosition;

    // Start is called before the first frame update
    void Start()
    {
        currTime = startTime;
        startPosition = player.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        currTime -= Time.deltaTime;
        if (currTime < 0.5)
        {
            countdownText.text = "Go!";            
        }
        else
        {
            //Input.ResetInputAxes();
            player.transform.position = startPosition;
            countdownText.text = currTime.ToString("0");
        }
        if(currTime < 0)
        {
            Destroy(gameObject);
        }
        
    }
}
