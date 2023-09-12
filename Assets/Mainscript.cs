using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mainscript : MonoBehaviour {
    private void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
    }
    public static int status = 0;
    public static int frame = 0;
    public static int[] endFrame = {360,360,360,360,360 };
    public static bool[] checkEnd = { false, false, false, false, false };
    void Update()
    {
        if(!checkEnd[status])
            {
            if(frame > endFrame[status])
            {
                checkEnd[status] = true;
                frame = 0;
            }
            else
            {
                frame++;
            }
        }
    }
}
