using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class CellphoneNum : MonoBehaviour
{
	static int[] answer = { 0, 0, 0 };
    public int CurrentNum = 0;
    public int Num;
    public Sprite[] n = new Sprite[10];
	public static SceneChange Scenechange = new SceneChange();

    public void PressRButton()
    {
        if (CurrentNum == 9)
        {
            CurrentNum = 0;
        }
        else
        {
            CurrentNum++;
        }
        gameObject.GetComponent<Image>().sprite = n[CurrentNum];
        checkAnswer(Num,CurrentNum);
    }



    public void PressLButton()
    {

        if (CurrentNum == 0)
        {
            CurrentNum = 9;
        }
        else
        {
            CurrentNum--;
        }
        gameObject.GetComponent<Image>().sprite = n[CurrentNum];
        checkAnswer(Num, CurrentNum);
    }

	public void checkAnswer(int Num, int CurrentNum){
		answer[Num] = CurrentNum;
		Debug.Log(answer[1]);
		Debug.Log(answer[2]);
		if(answer[1] == 0 && answer[2] == 6)
		{
			cellphone.Inter = false;
			Scenechange.ToF1R1W2();
			PuzzlePiece.BgSwitch ();
			화면전환호출.화면전환3 ();
		}
	
	}

}