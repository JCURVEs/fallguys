using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KDH_GoalArea : MonoBehaviour
{
    public GameObject clearUIFactory;
    float goalCount = 0;
    public Text goalCountText;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            clearUIFactory.SetActive(true);
            
        }
        goalCount++;
        goalCountText.text = goalCount.ToString() + " / 30";

        other.gameObject.SetActive(false);
    }
}
