using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class changeDrawer : MonoBehaviour {
    static int[] answer = { 0, 1, 1, 1, 1 };
    public static SceneChange Scenechange = new SceneChange();
    static string spriteImage = null;
    public Sprite OpenUpstairs;
	public Sprite AllClosed;

	
	// Update is called once per frame
	void Update () {
		if(spriteImage == "OpenUpstairs")
        {
			GameObject.Find ("Button").GetComponent<Button>().enabled = false;
            gameObject.GetComponent<Image>().sprite = OpenUpstairs;
        }
		if (spriteImage == "AllClosed") {
			GameObject.Find ("Button").GetComponent<Button>().enabled = false;
			gameObject.GetComponent<Image> ().sprite = AllClosed;
		}
	}
    public static void checkAnswer(int Num,int CurrentNum)
    {
        answer[Num] = CurrentNum;
        if(answer[1] == 6 && answer[2] == 8 && answer[3] == 1 && answer[4] == 7)
        {
            spriteImage = "OpenUpstairs";
			F1R1W1_Alarm01.showAlarm01 ();
            Scenechange.ToF1R1W1();
        }
    }

	public static void showAllClosed(){
		spriteImage = "AllClosed";
	}

}
