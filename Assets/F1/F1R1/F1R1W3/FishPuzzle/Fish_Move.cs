using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Fish_Move : MonoBehaviour {

	public GameObject fish;
	Vector3 firstPosition;
	Vector3 currentPosition;
	int count;
	string movement;
	public float move = 150f;

	void Start(){

		fish = GameObject.Find ("fish");
		movement = null;
		firstPosition = fish.transform.localPosition;
	}

	void Update(){

		currentPosition = fish.transform.localPosition;
		Debug.Log (currentPosition);
		if (currentPosition.x > 546.0f || currentPosition.x < -650.0f ||currentPosition.y>392.0f||currentPosition.y<-8.0f) {
			Reset ();
		}
	}

	public void MoveRight (){

		movement = movement + "1";
		count++;
		fish.transform.localPosition += new Vector3 (-move, 0f, 0f);
		checkAnswer ();


	}


	public void MoveLeft (){

		movement = movement + "2";
		count++;
		fish.transform.localPosition += new Vector3 (move, 0f, 0f);
		checkAnswer ();


	}


	public void MoveUp (){

		movement = movement + "3";
		count++;
		fish.transform.localPosition += new Vector3 (0f, move, 0f);
		checkAnswer ();

	}


	public void MoveDown (){

		movement = movement + "4";
		count++;
		fish.transform.localPosition += new Vector3 (0f, -move, 0f);
		checkAnswer ();
	}

	public void checkAnswer(){
		Debug.Log (movement);
		if (movement == "2241") {
			F1R1W3_KeyEye.show = true;
		}
	}

	public void Reset (){
		Debug.Log ("reset");
		fish.transform.localPosition = firstPosition;
		movement = null;

	}



}
