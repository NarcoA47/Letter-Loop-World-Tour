using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialState : MonoBehaviour
{

    public AnimateByBool[] abb;
    public LevelsManager lman;
    public ScoreCounter scoreCounting;
    public ImageObjectivesControl IOC;
    public LevelComplete levelComplete;
    public Timer _timer;
    public GameObject[] win;
    public GameObject preWin;
    public GameObject retry;

    public SpriteRenderer[] Dial;
    public SpriteRenderer[] BallSprite;

    public DialAlignment DialA;
    public DialAlignment DialB;
    public DialAlignment DialC;


    public int DialAState;
    public int DialBState;
    public int DialCState;

    public int DialAStateID;
    public int DialBStateID;
    public int DialCStateID;

    public int WordsToFind;

    public bool GamePlaying;
    public bool PresetsLoaded;

    public bool RewardsSet = false;
    public bool Rewardable = true;

    public Timer GameTimer;

    public int wordsFound;
    public GameObject[] AllBalls;
    public GameObject ObjectivesParent;

    bool LoadedPresets = false;

    void Start()
    {
        //PresetsLoaded = true;
    }

    void Update()
    {
        if(LoadedPresets == false)
        {
            PresetsLoaded = true;
            LoadedPresets = true;
        }
        if(PresetsLoaded){

        DialAState = DialA.CurrentDialState;
        DialBState = DialB.CurrentDialState;
        DialCState = DialC.CurrentDialState;

        if(DialAState == DialBState && DialBState == DialCState)
        {
            if(GamePlaying)
            {
                if(wordsFound >= WordsToFind)
                {
                    _timer.CancelTimer();
                    gameObject.GetComponent<Animator>().SetBool("Shrink", true);
                    ObjectivesParent.SetActive(false);
                    IOC.PopImage(true);
                    VictoryWin();
                    SetRewards();
                    levelComplete.enabled = true;
                }else
                {
                    foreach (AnimateByBool _abb in abb)
                    {
                        _abb.WordFoundAnimate();
                    }
                    foreach (SpriteRenderer ball in BallSprite)
                    {
                        Color customColor = new Color(0.1411765f, 0.5921569f, 1f, 1.0f);
                        ball.color = customColor;
                    }
                    StartCoroutine(mResetDial());
                    wordsFound++;
                    OneShotWin();
                    SoundManager.SoundMan.PlaySoundEffect(0);
                    
                }
                GamePlaying = false;
            }
        }
    }
    }

    public void ResetDial(bool isStart)
    {
        if(isStart)
        {
            foreach (GameObject ball in AllBalls)
            {
                ball.GetComponent<LetterBlock>().Shrink();
            }
        }
        else if(!isStart)
        {
            if(wordsFound < WordsToFind)
            {
                foreach (GameObject ball in AllBalls)
                {
                    ball.GetComponent<LetterBlock>().Pop();
                }
            }
        }
    }

    public void ResetImageObjective(bool relayBool)
    {
        if(relayBool == true)
        {
         IOC.PopImage(true);
        }
        else if(relayBool == false)
        {
            if(wordsFound < WordsToFind)
            {
                IOC.PopImage(false);
            }
        }
    }

    public void ResetDialSpecifics()
    {
        foreach (SpriteRenderer ball in BallSprite)
        {
            //Color customColor = new Color(0.1411765f, 0.5921569f, 1f, 1.0f);
            ball.color = Color.white;
        }
    }

    IEnumerator mResetDial()
    {
        ResetDial(true);
        ResetImageObjective(true);
        yield return new WaitForSeconds(1);
        ResetDialSpecifics();
        lman.NextLevel();
        yield return new WaitForSeconds(1);
        ResetDial(false);
        ResetImageObjective(false);
        IOC.NextImage();
        GamePlaying = true;
        StopAllCoroutines();
    }

    public void Reset()
    {
        DialA._alignAuto = false;
        DialB._alignAuto = false;
        DialC._alignAuto = false;
        DialA.CurrentDialState = -1;
        DialB.CurrentDialState = -1;
        DialC.CurrentDialState = -1;
        DialAState = -1;
        DialBState = -1;
        DialCState = -1;
        GamePlaying = true;
        GameTimer.time = 0;
        
        foreach (AnimateByBool _abb in abb)
        {
            _abb.WordDisanimate();
        }
    }

    bool preWon = false;

    public void OneShotWin()
    {
        if(Rewardable)
        {   
            if(!preWon)
            {
                preWin.SetActive(true);
                preWon = true;
            }
        }
    }

    public void VictoryWin()
    {
        if(Rewardable)
        {
            win[0].SetActive(true);
        }else
        {
            win[1].SetActive(true);
        }
    }

    public void SetRewards()
    {
        if(!RewardsSet)
        {
            if(Rewardable)
            {
                //GameData.gameData.gameScore += 12;
                GameData.gameData.gameCoins += 1;
            }
            else
            {
                scoreCounting.NoScore();
            }
            RewardsSet = true;
        }
    }

    public void DisAbleRewards()
    {
        Rewardable = false;
    }
}
