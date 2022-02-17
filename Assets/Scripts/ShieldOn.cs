using UnityEngine;

/***********************************
Goes on Shield prefab
Turns on shield when player collides w it  
***********************************/

public class ShieldOn : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Debug.Log("player immune"); // delete later
            GlobalVars.shieldOn = true;
                        
            Destroy(gameObject);
        }
    }
}
