using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/***********************************
Goes on Cross Enemy prefab
Contains coroutine for Cross Enemy's firing pattern
***********************************/
public class CrossBehavior : MonoBehaviour
{
    public GameObject bullet;

    private Vector3 lane1 = new Vector3(-1.51f, -3.0f,0.0f);
    private Vector3 lane2 = new Vector3(0.0f,-3.0f,0.0f);
    private Vector3 lane3 = new Vector3(1.5f,-3.0f,0.0f);
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(CrossFire());
    }

    IEnumerator CrossFire(){
        while (true){
            GameObject bullet1 = Instantiate(bullet, transform);
            GameObject bullet2 = Instantiate(bullet, transform);
            GameObject bullet3 = Instantiate(bullet, transform);

            bullet1.GetComponent<BulletMove>().endPos = lane1;
            bullet2.GetComponent<BulletMove>().endPos = lane2;
            bullet3.GetComponent<BulletMove>().endPos = lane3;

            yield return new WaitForSeconds(1.0f);
        }
    }
}
