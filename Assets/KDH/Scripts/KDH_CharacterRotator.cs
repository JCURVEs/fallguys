using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KDH_CharacterRotator : MonoBehaviour
{
    private Vector3 previousMousePosition;
    private bool isRotating;

    private void OnMouseDown()
    {
        previousMousePosition = Input.mousePosition;
        isRotating = true;
    }

    private void OnMouseDrag()
    {
        if (!isRotating)
            return;

        Vector3 currentMousePosition = Input.mousePosition;
        float deltaX = currentMousePosition.x - previousMousePosition.x;

        // Rotate the character around the Y-axis based on mouse movement
        transform.Rotate(Vector3.up, deltaX * 0.5f);

        previousMousePosition = currentMousePosition;
    }

    private void OnMouseUp()
    {
        isRotating = false;
    }
}
