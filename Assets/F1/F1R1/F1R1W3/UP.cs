using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UP : MonoBehaviour {

	public GameObject OpenU, CloseU, ZoomU;
	public static int currentImage =1;
	public static Sprite now;
	public Sprite Opened_U, Closed_U;
	public static bool OU = false;
	public static bool CU, ZU = false;

	void Update(){

	
		if (currentImage == 1) {
			gameObject.GetComponent<Image> ().sprite = Closed_U;
		} else {
			gameObject.GetComponent<Image> ().sprite = Opened_U;
		}
		OpenU.SetActive(OU);
		CloseU.SetActive(CU);
		ZoomU.SetActive(ZU);
	}

	public void ifOpenUclicked(){

		Debug.Log ("OpenUclicked");
		Wallclock_u.hideAll ();
		OU = false;
		CU = true;
		ZU = true;
		currentImage = 2;
	}

	public void ifCloseUclicked(){

		Debug.Log ("CloseUclicked");
		Wallclock_u.showAll ();
		OU = true;
		CU = false;
		ZU = false;
		currentImage = 1;
	}

	public static void ifZoomUclicked(){

		Debug.Log ("ZoomUclicked");
		Wallclock_u.hideAll ();
		OU = false;
		CU = true;
		ZU = true;
		currentImage = 2;
	}

}
