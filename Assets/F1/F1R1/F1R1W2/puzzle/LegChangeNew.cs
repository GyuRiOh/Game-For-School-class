using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LegChangeNew : MonoBehaviour {
    public string[] objectNames = { "leg_0", "leg_1", "leg_2", "leg_3" };
    public GameObject min;
	public GameObject L, R;
	public GameObject back;
	public int[] n = { 0, 1, 2, 3 };
	public Sprite[] leg = new Sprite[4];
	public static bool solved= false;


	public void PressRButtonLeg(int id)
	{
        if (n[id] == 3)
        {
            n[id] = 0;
        }
        else
        {
            n[id]++;
        }
        GameObject.Find(objectNames[id]).GetComponent<Image>().sprite = leg[n[id]];
		checkAnswer ();
	}



	public void PressLButtonLeg(int id)
	{
        if (n[id] == 0)
        {
            n[id] = 3;
        }
        else
        {
            n[id]--;
        }
        GameObject.Find(objectNames[id]).GetComponent<Image>().sprite = leg[n[id]];
		checkAnswer ();

    }
    private void Start()
    {
        min = GameObject.Find("min");
        min.SetActive(false);
    }
    private void checkAnswer()
    {
        if (n[0]==0&& n[1] == 0 && n[2] == 0 && n[3] == 0)
        {
			solved = true;
			back.SetActive (false);
            min.SetActive(true);
			for (int i=0;i<4;i++){
				L = GameObject.Find ("L_" + i);
				R = GameObject.Find ("R_" + i);
				L.SetActive (false);
				R.SetActive (false);
			}
        }
    }

}
