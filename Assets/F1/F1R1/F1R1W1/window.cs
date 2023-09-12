using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class window : MonoBehaviour {

	public Sprite next;
	public GameObject pieces;

	void Update () {
		if (Mainscript.status >= 2) {
			this.gameObject.GetComponent<Image> ().sprite = next;
			pieces.SetActive (true);
		} else {
			pieces.SetActive (false);
		}
	}

}
