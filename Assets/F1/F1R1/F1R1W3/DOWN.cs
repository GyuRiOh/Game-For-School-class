using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DOWN : MonoBehaviour {

	public GameObject OpenD, CloseD, InterButtonD;
	public static int currentImage =1;
	public Sprite Opened_D, Closed_D, Opened_D_chu, Closed_D_chu;
	public static bool OD = true;
	public static bool CD = false;
	static bool Inter = false;


	void Update(){


		if (currentImage == 1) {
			gameObject.GetComponent<Image> ().sprite = Closed_D;
		} else if (currentImage == 2) {
			gameObject.GetComponent<Image> ().sprite = Opened_D;
		} else if (currentImage == 3) {
			gameObject.GetComponent<Image> ().sprite = Opened_D_chu;
		} else if (currentImage ==4){
			gameObject.GetComponent<Image> ().sprite = Closed_D_chu;
		}
		OpenD.SetActive(OD);
		CloseD.SetActive(CD);
		InterButtonD.SetActive (Inter);
	}

	public void ifOpenDclicked(){

		Debug.Log ("OpenDclicked");
		OD = false;
		CD = true;
		Inter = true;
		currentImage = 2;
	}

	public void ifCloseDclicked(){

		if (currentImage == 3) {
			OD = false;
			CD = false;
			Inter = false;
			currentImage = 4;

		} else {

			Debug.Log ("CloseDclicked");
			OD = true;
			CD = false;
			Inter = false;
			currentImage = 1;

		}


	}


}
