using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Administration : MonoBehaviour
{
    public void DeleteUserData()
    {
        PlayerPrefs.DeleteAll();
    }
}
