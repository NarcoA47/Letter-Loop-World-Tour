using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TinySauceGECO : MonoBehaviour
{

    public bool pre_progression;
    public string levelNumber;

    
    void Start()
    {

        //This code you need to activate after all TinySauce integrations are done... Yes, am talking to you bulemu!!
        /*
        if(pre_progression)
        {
            TinySauce.OnGameStarted(levelNumber);
        }
        else if(!pre_progression)
        {
            TinySauce.OnGameFinished(true, GameData.gameData.gameScore, levelNumber);
        }
        */
    }
}
