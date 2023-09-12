using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PTD : MonoBehaviour {


	public static bool show=false;
	public GameObject puzzletodoor;
	public Sprite Swipe;
	public static SceneChange Scenechange = new SceneChange();

	void Update(){
		puzzletodoor.SetActive (show);
	}

	public void ifclicked(){
		StartCoroutine (SwipeAndWait ());
	}

	IEnumerator SwipeAndWait(){
		puzzletodoor.GetComponent<Image> ().sprite = Swipe;
		yield return new WaitForSeconds (1.0f);
		Scenechange.ToF1R0W1();
	}


}
