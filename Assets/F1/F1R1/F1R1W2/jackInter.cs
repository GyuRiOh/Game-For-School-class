using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jackInter : MonoBehaviour {

	public static bool showJack, showCable =false;
	public GameObject Jack, Cable;
	string id;

	void Update () {
		Jack.SetActive (showJack);
		Cable.SetActive (showCable);
	}

	public void ifJackclicked(){
		id = Unselect1.SaveSelected;
		if (id == "F1R1W3_Cable") {
			Unselect1.NoInter = false;
			showCable = true;
			cellphone.Inter = true;
			AfterUsing.deleteItem (id);
		}
	}
}
