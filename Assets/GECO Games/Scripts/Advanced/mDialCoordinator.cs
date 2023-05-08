using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mDialCoordinator : MonoBehaviour
{
    public static mDialCoordinator mDC;

    public mDialLogic[] mdialLogic;
    public float[] DialedDistance;
    public float DistanceRecieved;
    public bool recievedDistance = false;

    void Awake()
    {
        mDC = this;
    }
    
    void Update()
    {
        
        if(recievedDistance == true)
        {
            if(DistanceRecieved >= DialedDistance[0])
            {
                //dialLogic[1].enabled = false;
                //mdialLogic[0].enabled = false;
            }
            if(DistanceRecieved <= DialedDistance[0])
            {
                if(DistanceRecieved >= DialedDistance[0])
                {
                    //dialLogic[0].enabled = false;
                    //mdialLogic[0].enabled = false;
                }else if(DistanceRecieved <= DialedDistance[0])
                {
                    //dialLogic[0].enabled = false;
                    //dialLogic[1].enabled = false;
                }
            }
            
        }else
        {
            //dialLogic[0].enabled = true;
            //dialLogic[1].enabled = true;
            mdialLogic[0].enabled = true;
        }
    }
}
