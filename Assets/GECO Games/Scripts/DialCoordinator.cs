using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialCoordinator : MonoBehaviour
{

    public static DialCoordinator DC;

    public DialLogic[] dialLogic;
    public float[] DialedDistance;
    public float DistanceRecieved;
    public bool recievedDistance = false;

    void Awake()
    {
        DC = this;
    }
    
    void Update()
    {
        
        if(recievedDistance == true)
        {
            if(DistanceRecieved >= DialedDistance[0])
            {
                dialLogic[1].enabled = false;
                dialLogic[2].enabled = false;
            }
            if(DistanceRecieved <= DialedDistance[0])
            {
                if(DistanceRecieved >= DialedDistance[1])
                {
                    dialLogic[0].enabled = false;
                    dialLogic[2].enabled = false;
                }else if(DistanceRecieved <= DialedDistance[1])
                {
                    dialLogic[0].enabled = false;
                    dialLogic[1].enabled = false;
                }
            }
            
        }else
        {
            dialLogic[0].enabled = true;
            dialLogic[1].enabled = true;
            dialLogic[2].enabled = true;
        }
    }
}
