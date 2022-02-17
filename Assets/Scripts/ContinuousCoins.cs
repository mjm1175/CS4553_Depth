using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ContinuousCoins : MonoBehaviour
{
    private Vector3 startPos;
    private bool hasChilded;
    public float speed = 5f;

    public GameObject coinPattern;
    //private Vector3 spawnPos = new Vector3(-0.548f, 0.0887f, 1.3289f);

    void Start()
    {
        startPos = transform.position;
        hasChilded = false;

    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(-Vector3.up * speed * Time.deltaTime, Space.World);
        //print(isMoving);
        if ((transform.position.y < -6.47f) && !hasChilded)
        {
            Instantiate(coinPattern, startPos, transform.rotation);
            hasChilded = true;
        }
        if (transform.position.y < -18.25f){
            Destroy(gameObject);
        }
    }
}
