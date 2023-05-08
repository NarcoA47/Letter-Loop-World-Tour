using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelsManager : MonoBehaviour
{


    public Text LevelID;

    public GameObject[] Level;
    public int LevelNumber;

    int displayLevel;
    
    public void NextLevel()
    {
        
            Level[LevelNumber].SetActive(false);
            LevelNumber++;
            //displayLevel = LevelNumber + 1;
            //LevelID.text = "" + displayLevel;
            if(LevelNumber < Level.Length)
            {
                Level[LevelNumber].SetActive(true);
            }
    }
}
