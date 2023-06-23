using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Logo : MonoBehaviour
{
    public float minScale = 0.5f;
    public float maxScale = 1f;
    public float scaleSpeed = 0.5f;

    private bool isScalingUp = true;
    


    private void Update()
    {
        float currentScale = transform.localScale.x;

        if(KDH_StartManger.instance.isOnclick)
        {
            if(currentScale>=0)
            {
                currentScale -= scaleSpeed * 10 * Time.deltaTime;
            }
            
        }
        else
        {
            if (isScalingUp)
            {
                currentScale += scaleSpeed * Time.deltaTime;
                if (currentScale >= maxScale)
                {
                    currentScale = maxScale;
                    isScalingUp = false;
                }
            }
            else
            {
                currentScale -= scaleSpeed * Time.deltaTime;
                if (currentScale <= minScale)
                {
                    currentScale = minScale;
                    isScalingUp = true;
                }
            }
            
        }

        transform.localScale = new Vector3(currentScale, currentScale, currentScale);

    }
}
