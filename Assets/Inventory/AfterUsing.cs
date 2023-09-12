using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AfterUsing : MonoBehaviour {


	public static void deleteItem(string id){

		for (int i = 0; i < 5; i++) {
			if (id == AddedIDList.AddedID[i]) {
				Debug.Log (id + " deleted");
				AddedIDList.AddedID[i] = null;

			}
		}
	}


}
