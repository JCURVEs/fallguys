using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class CustomButton : Button
{
    // Start is called before the first frame update
    protected override void Start()
    {
        base.Start(); 
    }

    void Update()// Update is called once per frame
    {

    }

    bool IsHover()
    {
        return IsHighlighted();
    }
}
