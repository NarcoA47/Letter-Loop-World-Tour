using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IdentifyWordByCollision : MonoBehaviour
{


    public Dialwin dw;
    public AnimateByBool[] abb;
    public int[] CollectedLetters;
    public string[] IdentifiedBy;

    public bool[] WordFoundIsolated;

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.GetComponent<LetterID>() != null)
        {
            if(other.gameObject.GetComponent<LetterID>().ID == IdentifiedBy[0])
            {
                    CollectedLetters[0] += 1;
            }
        }
        if(other.gameObject.GetComponent<LetterID>() != null)
        {
            if(other.gameObject.GetComponent<LetterID>().ID == IdentifiedBy[1])
            {
                    CollectedLetters[1] += 1;
            }
        }
        if(other.gameObject.GetComponent<LetterID>() != null)
        {
            if(other.gameObject.GetComponent<LetterID>().ID == IdentifiedBy[2])
            {
                    CollectedLetters[2] += 1;
            }
        }
        if(other.gameObject.GetComponent<LetterID>() != null)
        {
            if(other.gameObject.GetComponent<LetterID>().ID == IdentifiedBy[3])
            {
                    CollectedLetters[3] += 1;
            }
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if(other.gameObject.GetComponent<LetterID>().ID == IdentifiedBy[0])
        {
                CollectedLetters[0] -= 1;
        }
        if(other.gameObject.GetComponent<LetterID>().ID == IdentifiedBy[1])
        {
                CollectedLetters[1] -= 1;
        }
        if(other.gameObject.GetComponent<LetterID>().ID == IdentifiedBy[2])
        {
                CollectedLetters[2] -= 1;
        }
        if(other.gameObject.GetComponent<LetterID>().ID == IdentifiedBy[3])
        {
                CollectedLetters[3] -= 1;
        }
    }

    void Update()
    {
        if(WordFoundIsolated[0] == false)
        {
            if(CollectedLetters[0] >= 3)
            {
                abb[0].WordFoundAnimate();
                WordFoundIsolated[0] = true;
                dw.Ready += 1;
            }
        }
        if(WordFoundIsolated[1] == false)
        {
            if(CollectedLetters[1] >= 3)
            {
                abb[1].WordFoundAnimate();
                WordFoundIsolated[1] = true;
                dw.Ready += 1;
            }
        }
        if(WordFoundIsolated[2] == false)
        {
            if(CollectedLetters[2] >= 3)
            {
                abb[2].WordFoundAnimate();
                WordFoundIsolated[2] = true;
                dw.Ready += 1;
            }
        }
        if(WordFoundIsolated[3] == false)
        {
            if(CollectedLetters[3] >= 3)
            {
                abb[3].WordFoundAnimate();
                WordFoundIsolated[3] = true;
                dw.Ready += 1;
            }
        }
    }
}
