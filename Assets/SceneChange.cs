using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChange : MonoBehaviour {
    

    
	public void ToInterfaceStart()
		{SceneManager.LoadScene ("InterfaceStart");
	}

	public void ToF1R1W1(){
		StaticNextScene.NextScene = "F1R1W1";
		AdditionalLoad.additional = "both";
		SceneManager.LoadScene ("FadeWithoutImage");
	}
		

	public void ToF1R1W2() {
		StaticNextScene.NextScene = "F1R1W2";
		AdditionalLoad.additional = "both";
		SceneManager.LoadScene ("FadeWithoutImage");

	}


	public void ToF1R1W4() {
		
		StaticNextScene.NextScene = "F1R1W4";
		AdditionalLoad.additional = "both";
		SceneManager.LoadScene ("FadeWithoutImage");

	}


	public void ToF1R1W3() {
		StaticNextScene.NextScene = "F1R1W3";
		AdditionalLoad.additional = "both";
		SceneManager.LoadScene ("FadeWithoutImage");
	}






	public void ToF1R0W1(){
		StaticNextScene.NextScene = "F1R0W1";
		AdditionalLoad.additional = "onlyINVEN";
		SceneManager.LoadScene("FadeWithoutImage");
}



	public void ToPuzzle_111_Drawer(){

		StaticNextScene.NextScene= "F1R1W1_puzzle";
		AdditionalLoad.additional = "onlyINVEN";
		SceneManager.LoadScene ("FadeWithoutImage_fast");


}

	public void ToPuzzle_112_TableLeg(){

		StaticNextScene.NextScene = "F1R1W2_puzzle";
		AdditionalLoad.additional = "onlyINVEN";
		SceneManager.LoadScene ("FadeWithoutImage_fast");

	}


	public void ToPuzzle_114_bed(){

		StaticNextScene.NextScene = "F1R1W4_puzzle";
		AdditionalLoad.additional = "onlyINVEN";
		SceneManager.LoadScene ("FadeWithoutImage_fast");



	}

	public void ToPuzzle_113_Clock(){

		UP.ifZoomUclicked ();
		StaticNextScene.NextScene = "F1R1W3_Clockpuzzle";
		AdditionalLoad.additional = "onlyINVEN";
		SceneManager.LoadScene ("FadeWithoutImage_fast");

	}
		



	public void ToPuzzle_113_Fish(){

		StaticNextScene.NextScene = "F1R1W3_Fishpuzzle";
		AdditionalLoad.additional = "onlyINVEN";
		SceneManager.LoadScene ("FadeWithoutImage_fast");


	}

	public void ToPuzzle_112_Cellphone(){

		StaticNextScene.NextScene = "F1R1W2_Cellphonepuzzle";
		AdditionalLoad.additional = "onlyINVEN";
		SceneManager.LoadScene ("FadeWithoutImage_fast");


	}

	public void ToPuzzle_112_Diary(){

		StaticNextScene.NextScene = "F1R1W2_DiaryPuzzle";
		AdditionalLoad.additional = "onlyINVEN";
		SceneManager.LoadScene ("FadeWithoutImage_fast");


	}

}

