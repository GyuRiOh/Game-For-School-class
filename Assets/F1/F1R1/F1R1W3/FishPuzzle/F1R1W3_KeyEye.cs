using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class F1R1W3_KeyEye : MonoBehaviour {

	public static bool show= false;
	public GameObject key;
	public static SceneChange Scenechange = new SceneChange();

	void Update(){
		key.SetActive (show);
	}

	public void ifclicked(){
		fishingport.inter = false;
		show = false;
		AddItem1.addItem ("F1R1W3_KeyEye");
		Scenechange.ToF1R1W3 ();

	}
}
