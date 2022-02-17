using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenericEnemyStuff : MonoBehaviour
{
    private AudioSource deathSound;
    void Start()
    {
        deathSound = gameObject.GetComponent<AudioSource>();
    }



    public void Die(){
        Debug.Log("do you think we made it here");
        deathSound.Play();
        StartCoroutine(DeathScene());
    }

    IEnumerator DeathScene(){
        int i = 0;
        while(i < 1){
            Transform explosion = gameObject.transform.GetChild(0);
            //ParticleSystem explosion = gameObject.GetComponentInChildren<ParticleSystem>();
            if (explosion != null){
                explosion.gameObject.SetActive(true);
            }
            i++;
            yield return new WaitForSeconds(0.4f);
        }
        Destroy(gameObject);
        yield return null;
    }
}
