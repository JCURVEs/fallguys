using UnityEngine;

public class ObjectRotation : MonoBehaviour
{

    void Update()
    {
        Vector3 mousePosition = Input.mousePosition;

        // Convert the screen coordinates to world coordinates
        Vector3 worldPosition = Camera.main.ScreenToWorldPoint(mousePosition);
        worldPosition.z = 0f; // Set the z-coordinate to 0 to ensure it's on the same plane as the UI

        // Set the position of the check mark image
        transform.position = worldPosition;
    }
}
