using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WallClockSwitch : MonoBehaviour {

	public int WCN = 1;
	public int WCNT = 1;
	public Sprite UpOpened;
	public Sprite UpClosed;
	public Sprite DownOpened;
	public Sprite DownClosed;
	public Sprite DownClosedWithChu;


	void start (){
		GameObject.Find ("Wallclock_u").GetComponent<Image> ().sprite = UpClosed;
		GameObject.Find ("Open_u").GetComponent<Button>().enabled=true;
		GameObject.Find ("Close_u").GetComponent<Button>().enabled=false;

		GameObject.Find ("Wallclock_d").GetComponent<Image> ().sprite = DownClosed;
		GameObject.Find ("Open_d").GetComponent<Button>().enabled=true;
		GameObject.Find ("Close_d").GetComponent<Button>().enabled=false;
		GameObject.Find ("InterButton_d").GetComponent<Button>().enabled=false;


		
	}

	void Update (){

		if (Mainscript.status < 3) {
			GameObject.Find ("Open_u").GetComponent<Button> ().enabled = false;

		}

	}


	public void WallClockUpSwitch () {

		if (WCN == 1) {
			WCN = 2;

			GameObject.Find ("Wallclock_u").GetComponent<Image> ().sprite = UpOpened;
			GameObject.Find ("Close_u").GetComponent<Button>().enabled=true;
			GameObject.Find ("Open_u").SetActive (false);
		}

	}

	public void WallClockUpSwitch_Door(){


		if (WCN == 2) 	{
		WCN = 1;
		GameObject.Find ("Wallclock_u").GetComponent<Image> ().sprite = UpClosed;
			GameObject.Find ("Open_u").GetComponent<Button>().enabled=true;
			GameObject.Find ("ClockZoomin").GetComponent<Button>().enabled=false;
			GameObject.Find ("Close_u").GetComponent<Button>().enabled=false;

		}


	}


	public void WallClockDownSwitch () {


		if (WCNT == 1) {
			WCNT = 2;

			GameObject.Find ("Wallclock_d").GetComponent<Image> ().sprite = DownOpened;
			GameObject.Find ("Open_d").GetComponent<Button>().enabled=false;
			GameObject.Find ("Close_d").GetComponent<Button>().enabled=true;
			GameObject.Find ("InterButton_d").GetComponent<Button>().enabled=true;


		}


	}


	public void WallClockDownSwitch_Door(){



		if (WCNT == 2){
			WCNT = 1;

			GameObject.Find ("Wallclock_d").GetComponent<Image> ().sprite = DownClosed;
			GameObject.Find ("Open_d").GetComponent<Button>().enabled=true;
			GameObject.Find ("Close_d").GetComponent<Button>().enabled=false;
			GameObject.Find ("InterButton_d").GetComponent<Button>().enabled=false;


		}

	}



}
