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
        SceneManager.LoadScene("Game");
    }

}