using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreCounter : MonoBehaviour
{
    public Text totalScoreText; // UI Text component to display the total score
    public float scoreUpdateSpeed = 100.0f; // Speed at which the score updates (higher value means faster update)
    public float scoreUpdateInterval = 1.0f; // Time interval between score updates (in seconds)
    public int levelScore = 0; // Current level score

    private float totalScore = 0; // Current total score
    private int targetScore = 0; // Target score to reach for the animation
    private bool isUpdatingScore = false; // Flag to indicate if the score is currently being updated
    private float timeSinceLastScoreUpdate = 0.0f; // Time elapsed since the last score update

    bool GameHasScore = true;

    void Start()
    {
        if(GameHasScore)
        {
            // Initialize the total score and level score to zero
            totalScore = GameData.gameData.gameScore;

            // Set the UI text components to display the initial scores
            totalScoreText.text = totalScore.ToString();
        
            StartCoroutine(LoadGameOver());
        }else
        {
            totalScoreText.text = "" + GameData.gameData.gameScore;
        }
        
    }


    IEnumerator LoadGameOver()
    {
        yield return new WaitForSeconds(0.5f);
        GameOver();
    }


    public void GameOver()
    {
        // Set the target score to the new total score
        targetScore = GameData.gameData.gameScore + levelScore;

        // Start the score update animation
        isUpdatingScore = true;
    }

    public void NoScore()
    {
        GameHasScore = false;
    }

    void Update()
    {
        if (isUpdatingScore)
        {
            // Update the time elapsed since the last score update
            timeSinceLastScoreUpdate += Time.deltaTime;

            // If enough time has elapsed, update the displayed total score by 1 point and reset the timer
            if (timeSinceLastScoreUpdate >= scoreUpdateInterval)
            {
                // Update the displayed total score by 1 point
                totalScore += 1;
                totalScoreText.text = totalScore.ToString();

                // If the displayed total score has reached the target score, stop the score update animation
                if (totalScore == targetScore)
                {
                    GameData.gameData.gameScore += levelScore;
                    isUpdatingScore = false;
                }

                // Reset the timer
                timeSinceLastScoreUpdate = 0.0f;
            }
        }

    }
}
