using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InterButton_u : MonoBehaviour {

	string id;
	public static bool hApplied, mApplied, cApplied = false;
	static bool Inter;

	public void ifclicked(){

		id = Unselect1.SaveSelected;
		if (id == "F1R1W4_ItemHr") {
			Unselect1.NoInter = false;
			Wallclock_u.showHour ();
			Debug.Log ("hour");
			hApplied = true;
			check ();
			AfterUsing.deleteItem (id);
		}
		if (id == "F1R1W2_itemMin") {
			Unselect1.NoInter = false;
			Wallclock_u.showMin ();
			Debug.Log ("min");
			mApplied = true;
			check ();
			AfterUsing.deleteItem (id);
		}
	}

	public static void check(){
		if (hApplied && mApplied && cApplied) {
			UP.OU = true;
			F1R1W1_Handle.show = true;
			fishingport.inter = true;
			화면전환호출.화면전환2 ();
		}
	}
		


}
