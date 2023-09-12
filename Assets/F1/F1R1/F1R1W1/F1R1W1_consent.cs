using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class F1R1W1_consent : MonoBehaviour {

	public static bool show = false;
	public GameObject consent;

	void Update(){
		consent.SetActive (show);
	}

	public void ifclicked(){
		show = false;
		AddItem1.addItem ("F1R1W1_consent");
	}

}
