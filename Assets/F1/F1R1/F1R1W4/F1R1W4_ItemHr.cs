using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class F1R1W4_ItemHr : MonoBehaviour {

	public GameObject itemHr;
	public static bool show = false;

	void Update () {
		itemHr = this.gameObject.transform.Find ("ItemHr").gameObject;
		itemHr.SetActive (show);
	}

	public void Ifclicked(){
		Debug.Log ("clicked");
		show = false;
		AddItem1.addItem ("F1R1W4_ItemHr");
	}
}
