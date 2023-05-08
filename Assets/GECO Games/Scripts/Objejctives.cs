using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Objejctives : MonoBehaviour
{

    public AnimateByBool[] abb;

    public void SetGameOn()
    {
        foreach (AnimateByBool _abb in abb)
        {
            _abb.GameOn = true;
        }
    }
}
