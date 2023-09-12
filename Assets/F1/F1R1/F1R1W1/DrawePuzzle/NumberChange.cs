using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class NumberChange : MonoBehaviour
{

    public int CurrentNum = 1;
    public int Num = 1;
    public Sprite[] n = new Sprite[13];
    public void PressRButton()
    {
        if (CurrentNum == 12)
        {
            CurrentNum = 1;
        }
        else
        {
            CurrentNum++;
        }
        gameObject.GetComponent<Image>().sprite = n[CurrentNum];
        changeDrawer.checkAnswer(Num,CurrentNum);
    }



    public void PressLButton()
    {
        if (CurrentNum == 1)
        {
            CurrentNum = 12;
        }
        else
        {
            CurrentNum--;
        }
        gameObject.GetComponent<Image>().sprite = n[CurrentNum];
        changeDrawer.checkAnswer(Num, CurrentNum);
    }
}