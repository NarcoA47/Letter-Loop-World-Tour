using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Dialwin : MonoBehaviour
{

    public int Ready;
    public DialState ds;

    bool GameOn = true;
    bool gameOver = false;

    float time;

    
    void Update()
    {
        if(Ready >= 4)
        {
            if(time >= 3){
                if(GameOn)
                {
                    //ds.Submit();
                    ds.gameObject.SetActive(false);
                    GameOn = false;
                }
            }
            gameOver = true;
        }else{
            gameOver = false;
            time = 0;
        }
    }

    void FixedUpdate(){
        if(gameOver){
            time += Time.deltaTime;
        }
    }
}
