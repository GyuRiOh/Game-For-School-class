using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class diary : MonoBehaviour {

	public static int clicked = 0;
	public static string image = "closed";
	public Sprite opened, closed;
	public static SceneChange Scenechange = new SceneChange();

	
	public void ifclicked(){
		clicked++;
		if (clicked == 1) {
			image = "opened";
		}else {
			clicked = 0;
			Scenechange.ToPuzzle_112_Diary ();
		}
	}

	void Update () {
		if (image == "opened") {
			gameObject.GetComponent<Image> ().sprite = opened;
		}
		if (image == "closed") {
			gameObject.GetComponent<Image> ().sprite = closed;
		}
	}



}
