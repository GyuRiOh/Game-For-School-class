using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class backButton : MonoBehaviour {

	public static SceneChange Scenechange = new SceneChange();

	public void ifClicked(){
		diary.image = "closed";
		Scenechange.ToF1R1W2 ();
	}
}
