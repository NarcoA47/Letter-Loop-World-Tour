using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ImageObjectivesControl : MonoBehaviour
{

    public Image Objective_;
    public Sprite[] ObjectiveSource;

    int ObjectiveNumb;

    void Start()
    {
        Objective_.sprite = ObjectiveSource[0];
    }


    public void NextImage()
    {
        ObjectiveNumb++;
        if(ObjectiveNumb < ObjectiveSource.Length)
        {
            Objective_.sprite = ObjectiveSource[ObjectiveNumb];
        }
    }

    public void PopImage(bool isShrunk){

        if(isShrunk)
        {
            gameObject.GetComponent<Animator>().SetBool("Shrink", true);
        }
        else if(!isShrunk)
        {  
            gameObject.GetComponent<Animator>().SetBool("Shrink", false);
        }
    }
}
