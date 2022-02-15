using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepeatBackground : MonoBehaviour
{
    private Vector3 startPos;
    private float repeatHeight;
    void Start()
    {
        startPos = transform.position;
        repeatHeight = GetComponent<BoxCollider2D>().size.y /4;
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(repeatHeight);
        Debug.Log(startPos.y);
        Debug.Log(transform.position.y);
        if(transform.position.y < startPos.y - repeatHeight){
            transform.position = startPos;
        }
        
    }
}
