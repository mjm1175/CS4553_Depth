using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/***********************************
Goes on background image
***********************************/
public class MoveDown : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed = 5;

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.down * speed *Time.deltaTime);
    }
}
