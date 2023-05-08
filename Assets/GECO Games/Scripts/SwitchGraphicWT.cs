using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchGraphicWT : MonoBehaviour
{
    public GameObject nextObject;
    public float time;

    float timer;

    void Update()
    {
        timer += Time.deltaTime;

        if(timer >= time)
        {
            gameObject.SetActive(false);
            nextObject.SetActive(true);
        }
    }
}
