using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayExplosion : MonoBehaviour
{
    public ParticleSystem explosion;

    void OnDestroy(){
        Debug.Log("On destroy reached");
        explosion.Play();
    }
}
