using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlobleData : MonoBehaviour
{
    private int score;
    private int level;

    private const string SCORE_KEY = "Score";
    private const string LEVEL_KEY = "Level";

    private void Start()
    {
        LoadGameData();
    }

    public void SaveGameData()
    {
        PlayerPrefs.SetInt(SCORE_KEY, score);
        PlayerPrefs.SetInt(LEVEL_KEY, level);
        PlayerPrefs.Save();
    }

    public void LoadGameData()
    {
        score = PlayerPrefs.GetInt(SCORE_KEY, 0);
        level = PlayerPrefs.GetInt(LEVEL_KEY, 0);
    }

    public int GetScore()
    {
        return score;
    }

    public void SetScore(int value)
    {
        score = value;
    }

    public int GetLevel()
    {
        return level;
    }

    public void SetLevel(int value)
    {
        level = value;
    }
}
