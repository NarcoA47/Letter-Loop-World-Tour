using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutorialManager : MonoBehaviour
{

    public Animator anim;
    public DialState ds;

    void Update()
    {
        if(ds.DialAState == 4 && ds.DialBState != 4)
        {
            anim.SetInteger("Tut", 1);
        }
        if(ds.DialBState == 4 && ds.DialCState != 4)
        {
            anim.SetInteger("Tut", 2);
        }
        if(ds.DialCState == 4)
        {
            anim.SetInteger("Tut", 3);
        }
        
    }
}
