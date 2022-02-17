using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/***********************************
Goes on Cross, Trig, and Circle Enemy prefabs   --> added to shield prefab too 
Produces their downward movement on the screen.
Note: smaller speed results in faster movement
***********************************/
public class NewEnemyMovement : MonoBehaviour
{
    private bool isMoving;
    public float speed = 5.0f;

    private AudioSource deathSound;
    void Start()
    {

        isMoving = true;
        //StartCoroutine(Move());

        deathSound = gameObject.GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(-Vector3.up * speed * Time.deltaTime, Space.World);
        //print(isMoving);
        if (!isMoving)
        {
            Destroy(gameObject);
        }
    }

    public void Die(){
        deathSound.Play();
        StartCoroutine(DeathScene());
    }

    IEnumerator DeathScene(){
        int i = 0;
        while(i < 1){
            Transform explosion = gameObject.transform.GetChild(0);
            //ParticleSystem explosion = gameObject.GetComponentInChildren<ParticleSystem>();
            if (explosion != null){
                explosion.gameObject.SetActive(true);
            }
            i++;
            yield return new WaitForSeconds(0.5f);
        }
        Destroy(gameObject);
        yield return null;
    }
}
