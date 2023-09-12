using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class alarmclockInter1 : MonoBehaviour {

	public Sprite nextSource;
	public static string image= null;
	public string id;

	public void IfClockTouched(){
		id = Unselect1.SaveSelected;
		if (id == "F1R1W1_Alarm01") {
			Unselect1.NoInter = false;
			image = "next";
			Bed.inter = true;
			AfterUsing.deleteItem (id);
			화면전환호출.화면전환1 ();
		}
			
	}

	void Update(){
		
		if (image == "next"){
			this.gameObject.GetComponent<Image>().sprite= nextSource;
		}


	}
		




}
