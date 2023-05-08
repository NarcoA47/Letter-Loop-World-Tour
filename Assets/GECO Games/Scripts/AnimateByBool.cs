using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AnimateByBool : MonoBehaviour
{
    public string[] Bool;
    public float waitTime;
    public GameObject ParticleSystem;
    public SpriteRenderer[] BallSprite;
    public DialState dialState;

    float timer;
    public bool GameOn = true;

    public Text Letter;

    void FixedUpdate()
    {
        if(GameOn == true)
        {
            timer += Time.deltaTime;

            if(timer >= waitTime)
            {
                gameObject.GetComponent<Animator>().SetBool(Bool[0], true);
                timer = 0;
                GameOn = false;
            }
        }
    }

    public void WordFoundAnimate()
    {
        gameObject.GetComponent<Animator>().SetBool(Bool[0], false);
        //ParticleSystem.SetActive(true);
        //gameObject.GetComponent<Text>().color = Color.yellow;
        GameOn = false;

        foreach (SpriteRenderer ball in BallSprite)
        {
            //ball.color = Color.blue;
        }

    }

    public void WordDisanimate()
    {
        //gameObject.GetComponent<Animator>().SetBool(Bool[0], true);
        ParticleSystem.SetActive(false);
        gameObject.GetComponent<Text>().color = Color.white;

        foreach (SpriteRenderer ball in BallSprite)
        {
            ball.color = Color.white;
        }

    }
}
