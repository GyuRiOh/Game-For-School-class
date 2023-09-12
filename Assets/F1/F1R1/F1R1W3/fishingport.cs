using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class fishingport : MonoBehaviour {

	public static bool inter=false;


	void Update () {

		if (Mainscript.status < 2) {
			inter=false;
		}
		gameObject.GetComponent<Button> ().interactable = inter;
		
	}
}
