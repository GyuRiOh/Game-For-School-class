using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddItem1 : MonoBehaviour {

	public static void addItem(string ID){

		bool itemAdded = false;

		for (int i = 0; i < 5; i++) {
			if (AddedIDList.AddedID[i]==null){

				// update StaticList
				AddedIDList.AddedID[i]=ID;
				Debug.Log (ID + "was added to AddedItemsStatic");
			
				itemAdded = true;
				break;
			}
		}


		if (!itemAdded) {
			Debug.Log ("Inventory Full - item not Added");
		}
	}

}
