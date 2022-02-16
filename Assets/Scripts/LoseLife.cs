using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


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
                if (GlobalVars.shieldOn == true) break; // don't lose life if shield is on 
                GlobalVars.lives--;
                life3.SetActive(false);
                //Debug.Log("life 3");
                gameObject.SetActive(false);
                Invoke("LoadGameOver", 1f); // call the LoadGameOver() after a short delay of 1 sec
                break;
            case 2:
                if (GlobalVars.shieldOn == true) break;
                GlobalVars.lives--;
                life2.SetActive(false);
                //Debug.Log("life 2");
                break;
            case 3:
                if (GlobalVars.shieldOn == true) break;
                GlobalVars.lives--;
                life1.SetActive(false);
                //Debug.Log("life 1");
                break;
            //default:
        }
    }

    void LoadGameOver() // load game over scene after third life is lost
    {
        SceneManager.LoadScene("Game Over");
    }
}
