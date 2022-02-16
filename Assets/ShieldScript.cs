using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/***********************************
Goes on Shield prefab
When enemy gets shield 
***********************************/

public class ShieldScript : MonoBehaviour
{
    public float shieldTime = 5f;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Debug.Log("player immune");
            GlobalVars.shieldOn = true;
            
            Debug.Log("Shield On");
            
            Invoke("ShieldOff", shieldTime);
            Destroy(gameObject);
        }
    }

    void ShieldOff() // not turning shield off for some reason 
    {
        if(GlobalVars.shieldOn == true)
        {
            GlobalVars.shieldOn = false;
            
            Debug.Log("Shield off");
        }
    }
}
