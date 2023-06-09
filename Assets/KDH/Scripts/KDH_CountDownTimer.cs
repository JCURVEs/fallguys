using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KDH_CountDownTimer : MonoBehaviour
{
    float currTime = 0;
    float startTime = 5;
    public Text countdownText;

    // Start is called before the first frame update
    void Start()
    {
        currTime = startTime;
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
            Input.ResetInputAxes();
            countdownText.text = currTime.ToString("0");
        }
        if(currTime < 0)
        {
            Destroy(gameObject);
        }
        
    }
}
