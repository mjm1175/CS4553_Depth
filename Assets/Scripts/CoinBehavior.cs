using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinBehavior : MonoBehaviour
{
    public AudioSource collectSound;

    private void OnTriggerEnter2D(Collider2D other) {
        if (other.gameObject.CompareTag("Player")){
            collectSound.Play();
            GlobalVars.score++;
            Destroy(gameObject);
        }
    }

}
