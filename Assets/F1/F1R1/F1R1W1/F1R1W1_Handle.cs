using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class F1R1W1_Handle : MonoBehaviour {

	public GameObject handle;
	public static bool show = false;

	void Update () {
		handle = this.gameObject.transform.Find ("Handle").gameObject;
		handle.SetActive (show);
	}

	public void Ifclicked(){
		show = false;
		AddItem1.addItem ("F1R1W1_Handle");

	}
}
