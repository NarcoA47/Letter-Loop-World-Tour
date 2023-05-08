using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class mCoins : MonoBehaviour
{

    public Text coins_text;
    public int coins;
    public float waitTime;

    void Start()
    {
        StartCoroutine(loadCoins());
    }

    void Update()
    {
        coins_text.text = "" + coins;
    }

    IEnumerator loadCoins()
    {
        yield return new WaitForSeconds(waitTime);
        coins = (int)GameData.gameData.gameCoins;
    }
}
