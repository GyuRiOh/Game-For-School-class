using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class drawer_dInter : MonoBehaviour {

	public string id;
	public string image;
	public Sprite OpenDownstairs;

	public void ifclicked(){
		id = Unselect1.SaveSelected;
		if (id == "F1R1W3_KeyEye") {
			Unselect1.NoInter = false;
			image = "next";
			F1R1W1_consent.show = true;
			AfterUsing.deleteItem (id);
		}
	}


	void Update(){
		if (image == "next") {
			GameObject.Find ("drawer").GetComponent<Image> ().sprite = OpenDownstairs;
		}
	}
}
