using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialAlignment : MonoBehaviour
{

    public Vector2[] minMax;
    public float[] alignedRotation;
    public int CurrentDialState;
    public bool _alignAuto = true;

    public void AlignByOrder()
    {
        DialAlign();
    }

    public void DialAlign()
    {

        if(_alignAuto)
        {
        
            if(transform.localEulerAngles.z >= minMax[0].x && transform.localEulerAngles.z <= minMax[0].y)
            {
                transform.rotation = Quaternion.Euler(0, 0, alignedRotation[0]);
                CurrentDialState = 1;
            }
            else if(transform.localEulerAngles.z >= minMax[1].x && transform.localEulerAngles.z <= minMax[1].y)
            {
                transform.rotation = Quaternion.Euler(0, 0, alignedRotation[1]);
                CurrentDialState = 2;
            }
            else if(transform.localEulerAngles.z >= minMax[2].x && transform.localEulerAngles.z <= minMax[2].y)
            {
                transform.rotation = Quaternion.Euler(0, 0, alignedRotation[2]);
                CurrentDialState = 3;
            }
            else if(transform.localEulerAngles.z <= minMax[3].x)
            {   
                transform.rotation = Quaternion.Euler(0, 0, alignedRotation[3]);
                CurrentDialState = 4;
            }
            else if(transform.localEulerAngles.z >= minMax[3].y)
            {
                transform.rotation = Quaternion.Euler(0, 0, alignedRotation[3]);
                CurrentDialState = 4;
            }

        }
    }

}
