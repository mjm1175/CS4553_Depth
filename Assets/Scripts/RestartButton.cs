using UnityEngine;
using UnityEngine.SceneManagement;

/*
For the game over scene 
When the button is pressed, restart the game
 */

public class RestartButton : MonoBehaviour
{

    public void Restart()
    {
        GlobalVars.lives = 3; // reset the number of lives 
        SceneManager.LoadScene("Game");
    }

}