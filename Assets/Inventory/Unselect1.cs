using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Unselect1 : MonoBehaviour {

	public static string SaveSelected = null;
	public static bool NoInter=true;

	void Update(){
		
		StartCoroutine (unselect ());
	}

	IEnumerator unselect(){
		if (SelectedItem.Selected != null) {
			if (Input.GetMouseButtonDown (0)) {
				SaveSelected = SelectedItem.Selected;
				for(int i=0; i<15; i++){
					yield return null;
					if (!NoInter) {
						NoInter = true;
						break;
					}
					NoInter = true;
				}
				SaveSelected = null;
				SelectedItem.Selected = null;
				gameObject.GetComponent<Image> ().enabled = false;
			}
		}
	}

}
