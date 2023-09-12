using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class PressDown : MonoBehaviour {
    
	public Sprite[] sprites = new Sprite[2];
    public Sprite solved;
    string[] ButtonId = { "light0", "light1", "light2", "light3" };
    public static bool[] onOff = { false, false, false, false };
    SceneChange sceneChange = new SceneChange();
    public void Start() {
    }
    public void Update()
    {
        if(onOff[0]&& onOff[1] && onOff[2] && onOff[3])
        {
			Bed.inter = false;
            Bed.puzzleSolved = true;
			Bed.ShowChu ();
            sceneChange.ToF1R1W4();
        }
    }
    public void press(int id)
    {
        switch (id)
        {
            case 0:
                {
                    changeLight(1);
                    changeLight(2);
                    changeLight(3);
                    break;
                }
            case 1:
                {
                    changeLight(0);
                    changeLight(2);
                    break;
                }
            case 2:
                {
                    changeLight(1);
                    break;
                }
            case 3:
                {
                    changeLight(1);
                    changeLight(2);
                    break;
                }
        }
    }
    void changeLight(int id)
    {
        onOff[id] = !onOff[id];
        GameObject.Find(ButtonId[id]).GetComponent<Image>().sprite = sprites[Convert.ToInt32(onOff[id])];
        Debug.Log(Convert.ToInt32(onOff[id]) + "" + ButtonId[id]);
    }
}
