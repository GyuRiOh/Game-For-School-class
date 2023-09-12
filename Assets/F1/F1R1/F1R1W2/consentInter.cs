using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class consentInter : MonoBehaviour {

	public static string image= null;
	public string id;

	public void IfConsentTouched(){
		id = Unselect1.SaveSelected;
		if (id == "F1R1W1_consent") {
			Unselect1.NoInter = false;
			jackInter.showJack = true;
			AfterUsing.deleteItem (id);
		}

	}

}
