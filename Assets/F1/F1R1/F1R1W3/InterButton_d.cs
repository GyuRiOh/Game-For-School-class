using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InterButton_d : MonoBehaviour {



	string id;

	public void ifInterClicked(){
		id = Unselect1.SaveSelected;
		if (id == "F1R1W4_itemChu") {
			Unselect1.NoInter = false;
			DOWN.currentImage=3;
			InterButton_u.cApplied = true;
			InterButton_u.check ();
			AfterUsing.deleteItem (id);
		}
	}
		
}
