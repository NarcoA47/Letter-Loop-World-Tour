using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelComplete : MonoBehaviour
{
    public float[] waitTime;

    public int LevelNumber;
    public GameObject Game;
    public GameObject Achievement;
    public GameObject _LevelComplete;
    public GameObject NextGame;

    public Timer timer_;

    public Text AchievementText;
    public Text CoinsText;

    void Start(){
        //StartCoroutine(LoadLeveComplete());
        //timer_.SetScores();
    }

    void Update(){
        //GlobalText[0].text = "" + GameData.gameData.gameScore;
        //GlobalText[1].text = "" + GameData.gameData.gameCoins; 
        //GlobalText[2].text = "" + GameData.gameData.gameJewels; 
    }

    void OnEnable()
    {
        StartCoroutine(LoadLeveComplete());
    }

    IEnumerator LoadLeveComplete(){
        yield return new WaitForSeconds(waitTime[0]);
        Achievement.SetActive(false);
        _LevelComplete.SetActive(true);
        yield return new WaitForSeconds(waitTime[1]);
        _LevelComplete.SetActive(false);
        NextGame.SetActive(true);
        LevelData.levelData.SaveGame(LevelNumber + 1);
        Game.SetActive(false);
        
    }

    public void ResetLevel()
    {
        
    }
}
