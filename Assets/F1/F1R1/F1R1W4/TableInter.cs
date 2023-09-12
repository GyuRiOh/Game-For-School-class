using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TableInter : MonoBehaviour {

	public Sprite nextimage;
	public static string image=null;
	public string id;

	public void IfTableTouched(){
		id = Unselect1.SaveSelected;
		if (id == "F1R1W1_Key01") {
			Unselect1.NoInter = false;
			image = "next";
			F1R1W4_ItemHr.show = true;
			AfterUsing.deleteItem (id);

		}

	}
		
	void Update(){
		if (image == "next"){
			this.gameObject.GetComponent<Image>().sprite= nextimage;
		}
	}




}
