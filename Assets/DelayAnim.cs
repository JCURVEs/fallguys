using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DelayAnim : MonoBehaviour
{
    public Animator anim;
    float currentTime = 0;
    public float delayTime = 5f;
    bool isEmote = true;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        currentTime += Time.deltaTime;
        if(currentTime >= delayTime && isEmote)
        {
            anim.SetBool("Emote", true);
            isEmote = false;
        }
        else
        {
            anim.SetBool("Emote", false);
            //anim.SetBool("Idle", true);
        }
        


    }
}
