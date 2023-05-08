using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelData : MonoBehaviour
{
    
    public static LevelData levelData;
    
    public GameObject[] Stage;
    public GlobleData globalData;
    public GameObject LoadScreen;

    void Awake()
    {
        levelData = this;
    }
    

    void Start()
    {
        StartCoroutine(InitializeGame());
    }

    
    public void SaveGame(int LevelSaved)
    {
        globalData.SetLevel(LevelSaved);
        globalData.SetScore(globalData.GetScore() + GameData.gameData.gameScore);
        globalData.SaveGameData();
    }

    IEnumerator InitializeGame()
    {
        yield return new WaitForSeconds(2);
        Stage[globalData.GetLevel()].SetActive(true);
        GameData.gameData.gameScore = globalData.GetScore();
        yield return new WaitForSeconds(5);
        LoadScreen.SetActive(false);

    }
}
