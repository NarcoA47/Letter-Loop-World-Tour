using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LetterBlock : MonoBehaviour
{
    public Transform parent;
 
    void Update ()
    {
        transform.rotation = Quaternion.Euler (0.0f, 0.0f, parent.transform.rotation.z * -1.0f);
    }

    public void Shrink()
    {
        gameObject.GetComponent<Animator>().SetBool("Shrink", true);
    }

    public void Pop()
    {
        gameObject.GetComponent<Animator>().SetBool("Shrink", false);
    }
}
