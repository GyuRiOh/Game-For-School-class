using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class F1R1W1_Key01: MonoBehaviour {

	public GameObject key01;
	public static bool show = false;

	void Update () {
		key01 = this.gameObject.transform.Find ("Key01").gameObject;
		key01.SetActive (show);
	}
		
	public static void showkey(){
		show = true;
	}

	public void Ifclicked(){
		show = false;
		AddItem1.addItem ("F1R1W1_Key01");

	}


}
