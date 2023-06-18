using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallPlatManager : MonoBehaviour
{
    public GameObject[] childObjects;

    private bool isChildDeactivated = false;
    private WaitForSeconds waitTime = new WaitForSeconds(5f);

    private void Update()
    {
        if (isChildDeactivated)
        {
            StartCoroutine(ActivateChildAfterDelay());
        }
    }

    private IEnumerator ActivateChildAfterDelay()
    {
        yield return waitTime;

        foreach (GameObject childObject in childObjects)
        {
            if (!childObject.activeSelf)
            {
                childObject.SetActive(true);
                isChildDeactivated = false;
                yield break;
            }
        }

        isChildDeactivated = false;
    }

    public void ChildDeactivated()
    {
        print("dsafdsf");
        isChildDeactivated = true;
    }
}
