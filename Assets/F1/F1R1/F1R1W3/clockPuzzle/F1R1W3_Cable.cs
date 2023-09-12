using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class F1R1W3_Cable : MonoBehaviour {

	public static bool inter = false;
	public GameObject cable;
	public static bool show = true;

		void Update () {
			cable.SetActive (show);
			gameObject.GetComponent<Button> ().interactable = inter;
		}
		

		public void Ifclicked(){
			show = false;
			inter = false;
			Debug.Log ("success");
			AddItem1.addItem ("F1R1W3_Cable");
		}
}
