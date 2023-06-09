using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KDH_GoalArea : MonoBehaviour
{
    public GameObject clearUIFactory;
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
        clearUIFactory.SetActive(true);
        Destroy(other.gameObject);
    }
}
