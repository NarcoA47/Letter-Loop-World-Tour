using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisableAfterTime : MonoBehaviour
{

    public float dTime = 2;
    float time;

    void OnEnable()
    {
        time = 0;
    }

    void Update(){
        time += Time.deltaTime;

        if(time > dTime)
        {
            gameObject.SetActive(false);
        }
    }
}
