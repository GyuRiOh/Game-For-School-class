using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clock_rotate_min : MonoBehaviour {
    public int angle =0;
    public int[] targetAngle = new int[5];
    // Use this for initialization
    void Start()
    {
        Application.targetFrameRate = 80;
    }

    // Update is called once per frame
    void Update()
    {
        if (angle < targetAngle[Mainscript.status])
        {
            if (Mainscript.checkEnd[Mainscript.status])
            {
                transform.Rotate(Vector3.forward * -1 * (targetAngle[Mainscript.status] - angle));
				angle = targetAngle[Mainscript.status];
            }
            else
            {
                transform.Rotate(Vector3.forward * -1);
                angle++;
            }
        }
    }
}
