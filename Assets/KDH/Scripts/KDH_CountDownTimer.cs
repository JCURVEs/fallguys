using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class KDH_CountDownTimer : MonoBehaviour
{
    float currTime = 0;    
    float startTime = 4.5f;
    public Text countdownText;
    public TextMeshProUGUI countdownTMP;
    public GameObject player;
    Vector3 startPosition;

    float transTime = 0;
    float spawnTime = 1f;
    public float scaleMultiplier = 5f;
    public float rotationSpeed = 100f;
    bool isLogoEaseing = false; 

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
        transTime += Time.deltaTime;  

        if (currTime < 0.5f)
        {
            countdownTMP.transform.localScale = new Vector3(2f, 2f, 2f);
            countdownTMP.transform.rotation = Quaternion.Euler(0f, 0f, 0f);
            countdownTMP.text = "GO!";
            
            if(!isLogoEaseing)
            {
                iTween.ScaleTo(gameObject, iTween.Hash(
               "scale", new Vector3(2f, 2f, 2f), // Target scale values
               "time", 1f, // Animation duration
               "easeType", iTween.EaseType.easeOutBounce // Ease type
                ));

                isLogoEaseing = true;
            }
        }
        else
        {
            //Input.ResetInputAxes();
            player.transform.position = startPosition;
            
            countdownTMP.text = currTime.ToString("0");

            if (transTime > spawnTime)
            {
                countdownTMP.transform.localScale = new Vector3(3f, 3f, 3f);
                countdownTMP.transform.rotation = Quaternion.Euler(0f, 0f, 0f);
                transTime = 0;
            }
            else if(transTime > 0.2f && transTime<spawnTime)
            {
                float scale = 1f + (1f - transTime / spawnTime) * scaleMultiplier;
                countdownTMP.transform.localScale = new Vector3(scale, scale, 1f);

                float rotation = -transTime / spawnTime * rotationSpeed;
                countdownTMP.transform.rotation = Quaternion.Euler(0f, 0f, rotation);
            }

            
        }
        if(currTime < 0)
        {
            Destroy(gameObject);
        }
        
    }
}
