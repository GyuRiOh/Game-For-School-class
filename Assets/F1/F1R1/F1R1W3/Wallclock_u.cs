using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wallclock_u : MonoBehaviour {

	public static bool h = false;
	public static bool m = false;
	public static bool c = false;
	public GameObject hour, min, cen;
	public GameObject inter;


	void Update(){
		hour.SetActive (h);
		min.SetActive (m);
		cen.SetActive (c);
		if (Mainscript.status != 1) {
			inter.SetActive (false);
		} else {
			inter.SetActive (true);
		}
	}

	public static void showHour(){
		h = true;
		c = true;
	}

	public static void showMin(){
		m = true;
		c = true;
	}

	public static void hideAll(){
		h = false;
		m = false;
		c = false;
	}

	public static void showAll(){
		h = true;
		m = true;
		c = true;
	}

}
