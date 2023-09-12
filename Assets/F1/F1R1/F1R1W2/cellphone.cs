using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class cellphone : MonoBehaviour {

	public Sprite next;
	public static bool Inter=false;

	void Update () {
		gameObject.GetComponent<Button> ().interactable = Inter;
		if (Inter) {
			gameObject.GetComponent<Image> ().sprite = next;
		}
	}
}
