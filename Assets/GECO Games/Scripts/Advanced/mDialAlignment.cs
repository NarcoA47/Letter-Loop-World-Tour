using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mDialAlignment : MonoBehaviour
{

    public Transform Dial;
    public SpriteRenderer Identifier;
    public float StandardRotationZ;

    Color startID;

    void Start()
    {
        startID = Identifier.color;
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag == "LetterID")
        {
            Identifier.color = Color.green;
            Dial.rotation = Quaternion.Euler(0, 0, StandardRotationZ);
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if(other.gameObject.tag == "LetterID")
        {
            Identifier.color = startID;
        }
    }
}
