using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootDownThree : MonoBehaviour
{
    // Start is called before the first frame update
    
    public GameObject bullet;

    public float interval;

    void Start()
    {
        InvokeRepeating("ShootThree", 1, interval);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void ShootThree(){
        Instantiate(bullet, transform.position, transform.rotation);
        Instantiate(bullet, transform.position, transform.rotation);
        Instantiate(bullet, transform.position, transform.rotation);
    }
}
