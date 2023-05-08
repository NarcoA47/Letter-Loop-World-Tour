using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaySoundOnActivate : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        SoundManager.SoundMan.PlaySoundEffect(1);
    }
}
