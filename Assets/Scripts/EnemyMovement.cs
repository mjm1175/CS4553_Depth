using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/***********************************
Goes on Cross, Trig, and Circle Enemy prefabs   --> added to shield prefab too 
Produces their downward movement on the screen.
Note: smaller speed results in faster movement
***********************************/
public class EnemyMovement : MonoBehaviour
{
    private Vector3 startPos;
    private Vector3 endPos;
    private bool isMoving;
    public float speed = 10.0f;

    private AudioSource deathSound;
    void Start()
    {
        startPos = transform.position;
        endPos.x = startPos.x;
        endPos.z = startPos.z;
        endPos.y = startPos.y - 6.5f;

        isMoving = true;
        StartCoroutine(Move());

        deathSound = gameObject.GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        //print(isMoving);
        if (!isMoving)
        {
            Destroy(gameObject);
        }
    }

    IEnumerator Move()
    {
        float timeElapsed = 0.0f;
        while (timeElapsed < 1.0)
        {
            transform.position = Vector3.Lerp(startPos, endPos, timeElapsed);
            timeElapsed += Time.deltaTime * (1.0f / speed);
            yield return null;
        }
        isMoving = false;
        yield return null;
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
