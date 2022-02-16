using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/***********************************
Goes on the Trig Enemy prefab
Contains coroutine for Trig enemy's firing pattern
***********************************/
public class TrigBehavior : MonoBehaviour
{
    public GameObject bullet;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(TrigFire());
    }

    IEnumerator TrigFire(){
        while (true){
            Instantiate(bullet, transform);
            yield return new WaitForSeconds(1.0f);
        }
    }
}
