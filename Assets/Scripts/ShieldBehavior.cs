using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/***********************************
Goes on player prefab
waits for alloted shield time and then turns off shield
change the shieldTime in global vars to change length of how long shield stays on 
***********************************/

public class ShieldBehavior : MonoBehaviour
{

    public GameObject shield; // goes around the player when the shield is on 

    void Start()
    {
        shield.SetActive(false); // shield is not activated yet
    }

    // Update is called once per frame
    void Update()
    {
        if (GlobalVars.shieldOn && !GlobalVars.turningOff)
        {
            shield.SetActive(true); // turn on the shield
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
        shield.SetActive(false);
        GlobalVars.shieldOn = false;
        GlobalVars.turningOff = false;
        //Debug.Log("Shield off"); // delete later
    }
}
