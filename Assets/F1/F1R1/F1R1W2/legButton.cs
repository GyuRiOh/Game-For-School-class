using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class legButton : MonoBehaviour {


	void Update () {
		if (Mainscript.status < 1 || LegChangeNew.solved==true) {
			gameObject.GetComponent<Button> ().interactable = false;
		}
	}
}
