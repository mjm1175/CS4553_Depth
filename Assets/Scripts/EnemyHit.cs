using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/***********************************
Goes on Player Bullet prefab
Used when player's bullet hits enemy object
***********************************/
public class EnemyHit : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other) {
        if (other.gameObject.CompareTag("Enemy")){
            other.gameObject.GetComponent<EnemyMovement>().Die();
            //Destroy(other.gameObject);
            Destroy(gameObject);
        }
    }
}
