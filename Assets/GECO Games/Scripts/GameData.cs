using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameData : MonoBehaviour
{
    public static GameData gameData;

    public int gameScore;
    public int gameCoins;

    void Awake()
    {
        gameData = this;
    }
}
