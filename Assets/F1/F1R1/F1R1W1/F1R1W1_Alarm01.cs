using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class F1R1W1_Alarm01 : MonoBehaviour {

	public GameObject alarm01;
	public static bool show = false;

	void Update () {
		alarm01 = this.gameObject.transform.Find ("Alarm01").gameObject;
		alarm01.SetActive (show);
	}

	public static void showAlarm01(){
		show = true;
	}

	public void Ifclicked(){

		show = false;
		AddItem1.addItem ("F1R1W1_Alarm01");
		changeDrawer.showAllClosed ();
	}
}
