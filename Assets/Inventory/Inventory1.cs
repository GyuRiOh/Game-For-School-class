using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Inventory1 : MonoBehaviour {

	public Button[] InventoryButtons = new Button[5];
	public Sprite[] Icons;
	public string[] IDs;
	public string id;
	public int index;

	void Start(){
		Icons = GameObject.Find ("IconStorage").GetComponent<IconStorage> ().itemIcons;
		IDs = GameObject.Find ("IconStorage").GetComponent<IconStorage> ().itemIDs;
	}

	void Update() {
		for (int i = 0; i < 5; i++) {
			if (AddedIDList.AddedID[i]!=null){
				id = AddedIDList.AddedID [i];
				index = System.Array.IndexOf (IDs, id);
				InventoryButtons [i].GetComponent<Image>().enabled=true;
				InventoryButtons [i].GetComponent<Image> ().preserveAspect = true;
				InventoryButtons [i].image.overrideSprite = Icons[index];
			}
			if (AddedIDList.AddedID [i] == null) {
				InventoryButtons [i].GetComponent<Image>().enabled=false;
			}
		}
	

	}

}