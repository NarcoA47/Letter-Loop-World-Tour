using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HUDScore : MonoBehaviour
{

    public Text ScoreHome;

    void Start()
    {
        ScoreHome.text = "" + GameData.gameData.gameScore;
    }
}
