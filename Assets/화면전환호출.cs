using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class 화면전환호출 : MonoBehaviour {


	public static void 화면전환1(){

		StaticNextScene.NextScene = "F1R1W4";
		AdditionalLoad.additional = "both";
		SceneManager.LoadScene ("FadeWhite");
		Mainscript.status = 1;

			Audio.which = 1;

	}

	public static void 화면전환2(){

		StaticNextScene.NextScene = "F1R1W3";
		AdditionalLoad.additional = "both";
		SceneManager.LoadScene ("FadeWhite");
		Mainscript.status = 2;

			Audio.which = 2;

	}

	public static void 화면전환3(){

		StaticNextScene.NextScene = "F1R1W2";
		AdditionalLoad.additional = "both";
		SceneManager.LoadScene ("FadeWhite");
		Mainscript.status = 3;

			Audio.which = 3;

	}


}
