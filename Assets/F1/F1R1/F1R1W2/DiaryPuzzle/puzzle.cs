using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class puzzle : MonoBehaviour {

	public string id;

	public void IfPuzzleTouched(){
		id = Unselect1.SaveSelected;
		if (id == "F1R1W4_ItemPuzzle") {
			Unselect1.NoInter = false;
			PTD.show = true;
			AfterUsing.deleteItem (id);

		}

	}


}
