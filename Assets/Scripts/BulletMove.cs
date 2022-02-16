using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/***********************************
Goes on Cross Bullet and Player Bullet prefabs
Public var endPos is set on instantiation and used to determine a specific end position for the bullet to move towards
Note: smaller speed results in faster movement;
***********************************/
public class BulletMove : MonoBehaviour
{
    private Vector3 startPos;
    public Vector3 endPos;

    private bool isMoving;
    public float speed = 20.0f;

    private float rotationSpeed = 720;
    void Start()
    {
        startPos = transform.position;

        isMoving = true;
        StartCoroutine(Move());
    }

    // Update is called once per frame
    void Update()
    {
        //print(isMoving);
        if (!isMoving)
        {
            Destroy(gameObject);
        } else {
            Vector3 relativePos = endPos - transform.position;
            Quaternion toRotation = Quaternion.LookRotation(Vector3.forward, relativePos);
            transform.rotation = Quaternion.RotateTowards(transform.rotation, toRotation, rotationSpeed * Time.deltaTime);
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
}
