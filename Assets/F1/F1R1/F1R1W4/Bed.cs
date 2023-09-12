using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Bed : MonoBehaviour {
    static bool status = false;//false=덮인거 true=열린거
    public GameObject bedpuzzle;
    public GameObject itemChu;
    public Sprite solved;
    public static bool puzzleSolved = false;
    public Sprite openBed;
    public Sprite closeBed;
    bool puzzleClicked = false;
    float delayTime = 0;
	public static bool inter = false;
	public static bool showChu = false;


    void Start() {
        itemChu.SetActive(false);
        if (status)
        {
            gameObject.GetComponent<Image>().sprite = openBed;
        }
        else
        {
            gameObject.GetComponent<Image>().sprite = closeBed;
        }
        bedpuzzle.SetActive(status);
    }

    // Update is called once per frame
    void Update() {

		itemChu.SetActive (showChu);


		if (Mainscript.status != 1) {
			inter = false;
		}
		gameObject.GetComponent<Button> ().interactable = inter;



        if (delayTime > 0)
        {
            delayTime -= Time.deltaTime;
            if (delayTime <= 0 && status && !puzzleClicked)
            {
                gameObject.GetComponent<Image>().sprite = closeBed;
                bedpuzzle.SetActive(false);
                status = false;
            }
        }
        if (puzzleSolved)
        {
			bedpuzzle.GetComponent<Button> ().enabled = false;
            bedpuzzle.GetComponent<Image>().sprite = solved;
        }
    }
    public void IfClicked()
    {
        if (status)
        {
            delayTime = 0.1F;
            puzzleClicked = false;
        }
        else
        {
            gameObject.GetComponent<Image>().sprite = openBed;
            bedpuzzle.SetActive(true);
            status = true;
        }
    }
    public void IfClickedPuzzle()
    {
        puzzleClicked = true;
        delayTime = 0;
    } 

	public static void ShowChu(){
		showChu = true;

	}
}
