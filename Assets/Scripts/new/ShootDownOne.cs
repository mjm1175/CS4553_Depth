using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootDownOne : MonoBehaviour
{
    public GameObject bullet;

    public float interval = 2;
    // Update is called once per frame

    void Start(){

        InvokeRepeating("ShootDown", 1, interval);
    }
    void Update()
    {
        
    }

    void ShootDown(){
        Instantiate(bullet, transform.position, transform.rotation);
    }
}
