using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mDialState : MonoBehaviour
{
    public GameObject win;
    public GameObject retry;

    public SpriteRenderer[] Dial;

    public mDialAlignment mDialA;
    //public DialAlignment DialB;
    //public DialAlignment DialC;


    public int DialAState;
    public int DialBState;
    public int DialCState;

    public int DialAStateID;
    public int DialBStateID;
    public int DialCStateID;

    public bool GamePlaying;


    public void Submit()
    {
        /*
        //DialAState = mDialA.CurrentDialState;
        //DialBState = DialB.CurrentDialState;
        //DialCState = DialC.CurrentDialState;

        if(DialAState == DialAStateID && DialBState == DialBStateID && DialCState == DialCStateID)
        {
            if(GamePlaying)
            {
                Debug.Log("Win");
                win.SetActive(true);
                //Dial.color = Color.yellow;
                GamePlaying = false;
            }
        }
        else
        {
            retry.SetActive(true);
        }
        */
    }
}
