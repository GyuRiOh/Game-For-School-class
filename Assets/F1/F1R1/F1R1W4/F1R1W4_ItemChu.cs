using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class F1R1W4_ItemChu : MonoBehaviour {

    public GameObject itemChu;
    public SpriteRenderer render;


    
    public void Ifclicked()
    {
        Debug.Log("clicked");
        Bed.showChu = false;
        AddItem1.addItem("F1R1W4_itemChu");
        
    }
}
