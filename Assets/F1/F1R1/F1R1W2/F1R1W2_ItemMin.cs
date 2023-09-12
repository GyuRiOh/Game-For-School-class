using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class F1R1W2_ItemMin : MonoBehaviour {
    SceneChange sceneChange = new SceneChange();


    public void IfClicked()
    {
        AddItem1.addItem("F1R1W2_itemMin");
        sceneChange.ToF1R1W2();
        gameObject.SetActive(false);
    }
}
