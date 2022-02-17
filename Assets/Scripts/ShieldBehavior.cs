using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/***********************************
Goes on player prefab
Waits for GlobalVars.shieldTime and then turns off the shield 
***********************************/

public class ShieldBehavior : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        if (GlobalVars.shieldOn && !GlobalVars.turningOff)
        {
            GlobalVars.turningOff = true;
            ShieldWait();
        }
    }

    void ShieldWait()
    {
        Invoke("ShieldOff", GlobalVars.shieldTime);
    }

    void ShieldOff()
    {
        GlobalVars.shieldOn = false;
        GlobalVars.turningOff = false;
        Debug.Log("Shield off"); // delete later
    }
}
