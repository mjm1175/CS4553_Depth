using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


/***********************************
Goes on player object
Called from collision when enemy or bullet hits player
Also called from collision with a life powerup 
***********************************/
public class LoseLife : MonoBehaviour
{
    public GameObject life1;
    public GameObject life2;
    public GameObject life3;

    // for shake
    private Vector3 _startPos;
    private float _timer;
    private Vector3 _randomPos;
    
    public float _time = 0.2f;
    public float _distance = 0.1f;
    public float _delayBetweenShakes = 0f;

    private AudioSource deathSound;

    public AudioSource hitSound;

    private void Start() {
        deathSound = gameObject.GetComponent<AudioSource>();
    }

    public void AddALife()
    {
        switch (GlobalVars.lives)
        {
            case 1:
                GlobalVars.lives++;
                life2.SetActive(true);
                break;
            case 2:
                GlobalVars.lives++;
                life3.SetActive(true);
                break;
                // if you already have three lives, do nothing

        }
    }
    
    public void Hit(){
        if (GlobalVars.shieldOn == true) return; // do nothing if shield
        _startPos = transform.position;
        StopAllCoroutines();
        StartCoroutine(Shake());
        switch (GlobalVars.lives)
        {
            case 1:
                //if (GlobalVars.shieldOn == true) break; // don't lose life if shield is on 
                deathSound.Play();
                GlobalVars.lives--;
                life3.SetActive(false);
                StopAllCoroutines();
                StartCoroutine(FlashAndSpin());
                //Debug.Log("life 3");
                //gameObject.SetActive(false);
                Invoke("LoadGameOver", 1f); // call the LoadGameOver() after a short delay of 1 sec
                break;
            case 2:
                //if (GlobalVars.shieldOn == true) break;
                hitSound.Play();
                GlobalVars.lives--;
                life2.SetActive(false);
                //Debug.Log("life 2");
                break;
            case 3:
                //if (GlobalVars.shieldOn == true) break;
                hitSound.Play();
                GlobalVars.lives--;
                life1.SetActive(false);
                //Debug.Log("life 1");
                break;
            //default:
        }
    }

    // Envoked when life is lost
   private IEnumerator Shake()
   {
       _timer = 0f;
 
       while (_timer < _time)
       {
           _timer += Time.deltaTime;
 
           _randomPos = _startPos + (Random.insideUnitSphere * _distance);
 
           transform.position = _randomPos;
 
           if (_delayBetweenShakes > 0f)
           {
               yield return new WaitForSeconds(_delayBetweenShakes);
           }
           else
           {
               yield return null;
           }
       }
 
       transform.position = _startPos;
   }

   private IEnumerator FlashAndSpin(){
       Renderer thisRenderer = gameObject.GetComponent<Renderer>();
       int i = 0;
       Color normalColor = thisRenderer.material.color;
       Color flashColor = new Color(1,0,0,1);
       thisRenderer.material.color = flashColor;
       while (true){
            transform.Translate(-Vector3.up * 0.5f* Time.deltaTime, Space.World);
            transform.Rotate(Vector3.forward, 700*Time.deltaTime);
           i++;
           yield return null;
       }
       //thisRenderer.material.color = normalColor;
   }

    void LoadGameOver() // load game over scene after third life is lost
    {
        SceneManager.LoadScene("Game Over");
    }
}
