using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrossBulletController : MonoBehaviour
{
    public Transform finalPos;

    public float speed;

    private Vector3 angle;
    void Start()
    {
        angle = (finalPos.position-transform.position).normalized;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(angle * speed * Time.deltaTime);
    }
}
