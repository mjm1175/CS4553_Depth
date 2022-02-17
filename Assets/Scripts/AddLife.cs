using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/***********************************
Goes on LifePowerUp prefab
Add a life when player collides with it
***********************************/

public class AddLife : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Debug.Log("got a life");
            other.gameObject.GetComponent<LoseLife>().AddALife();
            
            Destroy(gameObject);
        }
    }
}
