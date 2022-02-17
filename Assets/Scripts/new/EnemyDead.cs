using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDead : MonoBehaviour
{

    void OnTriggerEnter2D(Collider2D other){
        Debug.Log("reached");
        if(other.gameObject.CompareTag("PlayerBullet")){
            Destroy(other.gameObject);
            Destroy(gameObject);
        }
    }
}
