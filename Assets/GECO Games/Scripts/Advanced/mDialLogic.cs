using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class mDialLogic : MonoBehaviour
{

    public Camera camEra;
    public bool isDragging = false;
    private Vector3 lastMousePosition;

    public bool isActiveScript = true;



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
                // Check if the mouse is clicked within the circle's collider
                Vector3 mousePosition = camEra.ScreenToWorldPoint(Input.mousePosition);
                mousePosition.z = transform.position.z;
                if (Vector3.Distance(mousePosition, transform.position) <= GetComponent<CircleCollider2D>().radius)
                {
                    isDragging = true;
                    lastMousePosition = mousePosition;

                    //if(DialCoordinator.DC.recievedDistance == false)
                    //{
                        //DialCoordinator.DC.DistanceRecieved = Vector3.Distance(mousePosition, transform.position);
                        //DialCoordinator.DC.recievedDistance = true;
                    //}
                }
            }
            else if (Input.GetMouseButtonUp(0))
            {
                isDragging = false;
                //DialCoordinator.DC.DistanceRecieved = 0;
                //DialCoordinator.DC.recievedDistance = false;
                //_DialAlignment.DialAlign();
            }
            
            else if (isDragging)
            {
                // Rotate the circle based on the mouse movement
                Vector3 mousePosition = camEra.ScreenToWorldPoint(Input.mousePosition);
                mousePosition.z = transform.position.z;
                Vector3 rotationAxis = Vector3.Cross(lastMousePosition, mousePosition);
                float rotationAngle = Vector3.Angle(lastMousePosition, mousePosition);
                transform.Rotate(rotationAxis, rotationAngle, Space.Self);
                lastMousePosition = mousePosition;
            }

        }
    }
}


