using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/***********************************
Goes on Player Bullet prefab
Used when player's bullet hits enemy object
***********************************/
public class EnemyHit : MonoBehaviour
{
    //public AudioSource enemyDeathAudio;

    private void OnTriggerEnter2D(Collider2D other) {
        if (other.gameObject.CompareTag("Enemy")){
            //enemyDeathAudio.Play();
            other.gameObject.GetComponent<NewEnemyMovement>().Die();
            Destroy(gameObject);
        }
    }
}
