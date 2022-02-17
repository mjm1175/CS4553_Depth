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

    void Start()
    {

        isMoving = true;
        //StartCoroutine(Move());

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
}
