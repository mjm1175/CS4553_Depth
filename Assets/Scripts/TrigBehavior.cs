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
    private bool startedFiring = false;
    // Start is called before the first frame update
    void Start()
    {
        //StartCoroutine(TrigFire());
    }

    private void Update() {
        if ((transform.position.y < 3.0f) && !startedFiring){
            StartCoroutine(TrigFire());
            startedFiring = true;
        }
        if (transform.position.y < -3.0f){
            StopAllCoroutines();
        }
    }

    IEnumerator TrigFire(){
        while (true){
            Instantiate(bullet, transform);
            yield return new WaitForSeconds(1.5f);
        }
    }
}
