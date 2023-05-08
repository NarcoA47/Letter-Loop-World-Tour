using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//[ExecuteInEditMode]
public class LevelSetUp : MonoBehaviour
{

    public bool ConditionalDS = false;
    public Text[] TopLetter;
    public Text Center;
    public string[] sTopLetter;
    public string sCenter;
    public Text[] RightLetter;
    public string[] sRightLetter;
    public Text[] BottomLetter;
    public string[] sBottomLetter;
    public Text[] LeftLetter;
    public string[] sLeftLetter;

    public Text[] Objectives;
    public string[] sObjectives;

    public Transform[] Dial;
    public float[] DialRotationOn;

    public DialState dialState;
    public DialStateConditional dialStateCondition;
    public AnimateByBool[] _abb;
    public SpriteRenderer[] _BallSprite;

    public DialAlignment[] dAlign;


    void OnEnable()
    {

        TopLetter[0].text = sTopLetter[0];
        TopLetter[1].text = sTopLetter[1];
        TopLetter[2].text = sTopLetter[2];

        Center.text = sCenter;

        RightLetter[0].text = sRightLetter[0];
        RightLetter[1].text = sRightLetter[1];
        RightLetter[2].text = sRightLetter[2];

        BottomLetter[0].text = sBottomLetter[0];
        BottomLetter[1].text = sBottomLetter[1];
        BottomLetter[2].text = sBottomLetter[2];

        LeftLetter[0].text = sLeftLetter[0];
        LeftLetter[1].text = sLeftLetter[1];
        LeftLetter[2].text = sLeftLetter[2];

        //Objectives[0].text = sObjectives[0];
        //Objectives[1].text = sObjectives[1];
        //Objectives[2].text = sObjectives[2];
        //Objectives[3].text = sObjectives[3];

        Dial[0].rotation = Quaternion.Euler(0, 0, DialRotationOn[0]);
        Dial[1].rotation = Quaternion.Euler(0, 0, DialRotationOn[1]);
        Dial[2].rotation = Quaternion.Euler(0, 0, DialRotationOn[2]);
        

        if(!ConditionalDS)
        {  
            dialState.abb = _abb;
            dialState.BallSprite = _BallSprite;
        }
        else if(ConditionalDS)
        { 
            dialStateCondition.abb = _abb;
            dialStateCondition.BallSprite = _BallSprite;
        }
        

        foreach (DialAlignment dial in dAlign)
        {
            dial.AlignByOrder();
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
