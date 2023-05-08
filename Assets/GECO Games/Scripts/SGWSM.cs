using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SGWSM : MonoBehaviour
{
    public GameObject PREVObject;
    public GameObject nextObject;
    public float time;

    float timer;

    void Update()
    {
        timer += Time.deltaTime;

        if(timer >= time)
        {
            timer = 0;
            nextObject.SetActive(true);
            PREVObject.SetActive(false);
        }
    }
}
