using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gear_rotate : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}

	// Update is called once per frame
	void Update () {


		GameObject.Find("gear1").transform.Rotate (Vector3.forward * -2);
		GameObject.Find("gear3").transform.Rotate (Vector3.forward * -2);
		GameObject.Find("gear2").transform.Rotate (Vector3.forward * 2);
		GameObject.Find("gear4").transform.Rotate (Vector3.forward * 1);
		GameObject.Find("jangsic_gear2").transform.Rotate (Vector3.forward * 2);
		GameObject.Find("jangsic_gear").transform.Rotate (Vector3.forward * 1);

		
	}
}
