using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause : MonoBehaviour
{
    public void PausePressed()
    {
        // Freeze time
        Time.timeScale = 0.0f; // set time scale to zero
    }

    public void Play()
    {
        // Unfreeze time
        Time.timeScale = 1; // set time scale back to its original value
    }
}
