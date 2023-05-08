using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{

    public float time;
    public Text timer_text;
    public GameObject failed;

    public Text FailingTimer;
    public Animator failingAnim;

    bool isFailed;


    void FixedUpdate()
    {
        if(isFailed == false)
        {
            if(time > 0)
            {
                time -= Time.deltaTime;

                timer_text.text = "" + (int)time;
                FailingTimer.text = "" + (int)time;
            }
            if(time <= 10 && time > 0)
            {
                FailingTimer.enabled = true;
                failingAnim.SetBool("Failing", true);
                FailingTimer.color = Color.red;
            }
            else if(time <= 0)
            {
                FailingTimer.enabled = false;
                failed.SetActive(true);
                isFailed = true;
            }
        }
        
    }

    public void CancelTimer()
    {
        FailingTimer.enabled = false;
        isFailed = true;
    }

}
