using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PuzzlePiece : MonoBehaviour {

	public Sprite BG_Puzzled;
	public GameObject DiaryPuzzle;
	public GameObject BG;
	public static bool show = false;
	public static string image;

	void Update(){
		DiaryPuzzle.SetActive (show);
		if (image == "Puzzled") {
			BG.GetComponent<Image> ().sprite = BG_Puzzled;
		}
	}

	public void IfClicked () {
		show = false;
		AddItem1.addItem ("F1R1W4_ItemPuzzle");
	}

	public static void BgSwitch() {

		show = true;
		image = "Puzzled";
		
	}


}
