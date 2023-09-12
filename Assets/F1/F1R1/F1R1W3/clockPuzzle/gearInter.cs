using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class gearInter : MonoBehaviour {

	public Sprite nextimage;
	public static string image  = null;
	public string id;
	public static bool done = false;
	public string rotate;
	public static bool inter = true;
	public static Vector3 Rotation;
	static bool RotSaved= false;

	public void ifclicked(){

		StartCoroutine (clicked ());

	}

	IEnumerator clicked(){

		if (!done) {
			id = Unselect1.SaveSelected;
			if (id == "F1R1W1_Handle") {
				Debug.Log ("success");
				Unselect1.NoInter = false;
				image = "nextimage";
				done = true;
				AfterUsing.deleteItem (id);
			}
		} else {
			inter = false;
			GameObject.Find ("Main Camera").GetComponent<Gear_rotate> ().enabled = true;
			yield return new WaitForSeconds(1.5f);
			GameObject.Find ("Main Camera").GetComponent<Gear_rotate> ().enabled = false;
			Rotation = gameObject.transform.rotation.eulerAngles;
			RotSaved = true;
			F1R1W3_Cable.inter = true;
		}
	}

	void Update(){
		if (RotSaved) {
			gameObject.transform.eulerAngles = Rotation;
		}

		gameObject.GetComponent<Button> ().interactable = inter;
		if (image == "nextimage"){
			this.gameObject.GetComponent<Image>().sprite= nextimage;
		}

	}
}
