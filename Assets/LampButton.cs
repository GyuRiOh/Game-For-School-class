using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LampButton : MonoBehaviour {
    SceneChange Scenechange = new SceneChange();
	public void iflampclicke(){
		StartCoroutine (Ifclicked ());
	}

	IEnumerator Ifclicked(){
		AudioSource audio = GetComponent<AudioSource> ();
		audio.Play ();
		yield return new WaitUntil (() => audio.isPlaying == false);
		Scenechange.ToF1R0W1 ();
	}

}
