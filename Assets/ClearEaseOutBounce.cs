using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClearEaseOutBounce : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {        
        iTween.ScaleTo(gameObject, iTween.Hash(
       "scale", new Vector3(2f, 2f, 2f), // Target scale values
       "time", 1f, // Animation duration
       "easeType", iTween.EaseType.easeOutBounce // Ease type
        ));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
