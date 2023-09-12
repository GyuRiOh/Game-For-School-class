using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OtherPillAppear : MonoBehaviour {

	public GameObject Pills;
	public GameObject Bottle;

	void Start(){
		
	}

	void Update(){

		if (Mainscript.status < 1) {
			Bottle.transform.eulerAngles = new Vector3 (0.0f, 0.0f, 268.8f);
		} else {
			Bottle.transform.eulerAngles = new Vector3 (0.0f, 0.0f, 359.3f);
		}

		if (Mainscript.status < 1) {
			Pills.SetActive (false);
		} else {
			Pills.SetActive (true);
		}

	}

}


