using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class IfSlotTouched : MonoBehaviour {

	public GameObject border;

	public void SlotTouched(){
		SaveSelectedItem ();
		ShowBorder ();
	}

	public void SaveSelectedItem(){

		for (int i = 0; i < 5; i++){
			if (gameObject.name == "Slot" + i){
				SelectedItem.Selected = AddedIDList.AddedID[i];
				Debug.Log ("Item Selected" + SelectedItem.Selected);
			}
		}
	}
		

	public void ShowBorder(){

		border = this.gameObject.transform.Find("border").gameObject;
		border.GetComponent<Image> ().enabled = true;


	}
		
}
