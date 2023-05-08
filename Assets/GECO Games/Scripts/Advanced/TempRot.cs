using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TempRot : MonoBehaviour
{
    // Speed at which the circle rotates
    public float rotationSpeed = 100.0f;

    void OnMouseDrag()
    {
        // Get the position of the mouse click
        Vector3 mousePos = Input.mousePosition;
        mousePos.z = 10.0f; // Distance of the camera from the circle

        // Convert the mouse position from screen space to world space
        Vector3 worldPos = Camera.main.ScreenToWorldPoint(mousePos);

        //Debug.Log("Mouse position: " + mousePos);
        //Debug.Log("World position: " + worldPos);

        // Calculate the direction to rotate the circle towards
        Vector3 direction = worldPos - transform.position;

        // Calculate the angle to rotate the circle by
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;

        //Debug.Log(angle);

        // Rotate the circle
        transform.rotation = Quaternion.RotateTowards(transform.rotation, Quaternion.Euler(0, 0, angle), rotationSpeed * Time.deltaTime);
    }
}
