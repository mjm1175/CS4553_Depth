using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/***********************************
Goes on player object
Called from collision when enemy or bullet hits player
***********************************/
public class LoseLife : MonoBehaviour
{
    public GameObject life1;
    public GameObject life2;
    public GameObject life3;
    public void Hit(){
        switch (GlobalVars.lives)
        {
            case 1:
                GlobalVars.lives--;
                life3.SetActive(false);
                //Debug.Log("life 3");
                gameObject.SetActive(false);
                break;
            case 2:
                GlobalVars.lives--;
                life2.SetActive(false);
                //Debug.Log("life 2");
                break;
            case 3:
                GlobalVars.lives--;
                life1.SetActive(false);
                //Debug.Log("life 1");
                break;
            //default:
        }
    }
}
