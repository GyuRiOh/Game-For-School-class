using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PillInter : MonoBehaviour {

	public Sprite nextimage;
	public static string image  = null;
	public static bool inter = false;
	public static bool done = false;

	public void ifclicked(){

		done = true;
		inter = false;
		image = "nextimage";
		F1R1W1_Key01.showkey ();


	}

	void Update(){
		if (Mainscript.status == 1) {
			if (!done) {
				inter = true;
			}
		}
		if (image == "nextimage"){
			this.gameObject.GetComponent<Image>().sprite= nextimage;
		}
		gameObject.GetComponent<Button> ().interactable = inter;
	}

}
