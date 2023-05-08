using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialLogic : MonoBehaviour
{

    public DialAlignment _DialAlignment;
    public bool isDragging = false;
    private Vector3 lastMousePosition;

    public bool isActiveScript = true;
    public float CircleColliderRadiusAdjusted;



    private void OnDisable()
    {
        isActiveScript = false;
        isDragging = false;
    }

    private void OnEnable()
    {
        isActiveScript = true;
        isDragging = false;
    }

    void Update()
    {
        if(isActiveScript){

            if (Input.GetMouseButtonDown(0))
            {
                _DialAlignment._alignAuto = true;
                // Check if the mouse is clicked within the circle's collider
                Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
                mousePosition.z = transform.position.z;
                //Debug.Log(Vector3.Distance(mousePosition, transform.position));
                if (Vector3.Distance(mousePosition, transform.position) <= CircleColliderRadiusAdjusted)
                {
                    isDragging = true;
                    lastMousePosition = mousePosition;

                    if(DialCoordinator.DC.recievedDistance == false)
                    {
                        DialCoordinator.DC.DistanceRecieved = Vector3.Distance(mousePosition, transform.position);
                        DialCoordinator.DC.recievedDistance = true;
                    }
                }
            }
            else if (Input.GetMouseButtonUp(0))
            {
                isDragging = false;
                DialCoordinator.DC.DistanceRecieved = 0;
                DialCoordinator.DC.recievedDistance = false;
                _DialAlignment.DialAlign();
            }
            
            else if (isDragging)
            {
                // Rotate the circle based on the mouse movement
                Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
                mousePosition.z = transform.position.z;
                Vector3 rotationAxis = Vector3.Cross(lastMousePosition, mousePosition);
                float rotationAngle = Vector3.Angle(lastMousePosition, mousePosition);
                transform.Rotate(rotationAxis, rotationAngle, Space.Self);
                lastMousePosition = mousePosition;
                //Debug.Log(Vector3.Distance(mousePosition, lastMousePosition));
            }

        }
    }
}


