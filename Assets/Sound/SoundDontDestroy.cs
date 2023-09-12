using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundDontDestroy : MonoBehaviour {

    public static SoundDontDestroy instance;

    void Awake()
    { if (instance == null)
        { instance = this; }

        else if (instance != this)
        {

            Destroy(gameObject);

        }


        DontDestroyOnLoad(gameObject);
    
    



    }
    
}
