using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonEaseOutElastic : MonoBehaviour
{
    Vector3 startScale;

    // Start is called before the first frame update
    void Start()
    {
        startScale = transform.localScale;
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void OnMyPoninterEnter()
    {
        iTween.ScaleTo(gameObject, iTween.Hash(
       "scale", new Vector3(1.1f, 1.1f, 1.1f), // Target scale values
       "time", 0.2f, // Animation duration
       "easeType", iTween.EaseType.easeOutElastic // Ease type
        ));
    }
    
    public void OnMyPointExit()
    {
        transform.localScale = startScale;
    }
}
