using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/***********************************
Goes on Cross and Trig bullet prefabs & Cross, Trig, and Circle Enemy prefabs
Player loses life when bullet or enemy hits player
***********************************/
public class BulletHit : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other) {
        
        if (other.gameObject.CompareTag("Player")){
            
            other.gameObject.GetComponent<LoseLife>().Hit();
            Destroy(gameObject);
        }
    }
}
