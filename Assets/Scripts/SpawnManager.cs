using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

/***********************************
Goes on Game Manager object
Controls the spawning of enemies and powerups as specified from the arrays in GlobalVars
***********************************/
public class SpawnManager : MonoBehaviour
{
    public GameObject trigPrefab;
    public GameObject crossPrefab;
    public GameObject circPrefab;

    public GameObject shieldPrefab;
    public GameObject lifePrefab;

    public Transform lane1SP;
    public Transform lane2SP;
    public Transform lane3SP;

    private Quaternion rotationVec = Quaternion.Euler(0,0,0);

    private int thisSpawnItem = 0;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnItems());
    }

    private void Update() {
        if (Input.GetKeyDown(KeyCode.Escape)){
            GlobalVars.lives = 3; // reset lives before starting new scene
            SceneManager.LoadScene("Start");
        }
    }


    IEnumerator SpawnItems(){
        // 8 is length of pre-made spawn items and locations (arrays in GlobalVars)
        while(true){
            while(thisSpawnItem < 8){

                // get which lane to spawn in
                Transform spawnHere = lane1SP;
                switch (GlobalVars.nextLane[thisSpawnItem])
                {
                    case 1:
                        spawnHere = lane1SP;
                        break;
                    case 2:
                        spawnHere = lane2SP;
                        break;
                    case 3:
                        spawnHere = lane3SP;
                        break;
                    //default:
                }
                
                // get which item to spawn there
                switch (GlobalVars.nextSpawn[thisSpawnItem])
                {
                    case 't':
                        Instantiate(trigPrefab, spawnHere.position, rotationVec);
                        break;
                    case 'c':
                        Instantiate(circPrefab, spawnHere.position, rotationVec);
                        break;
                    case 'x':
                        Instantiate(crossPrefab, spawnHere.position, rotationVec);
                        break;
                    case 's': //shield
                        Instantiate(shieldPrefab, spawnHere.position, rotationVec);
                        break;
                    case 'l': //life 
                        Instantiate(lifePrefab, spawnHere.position, rotationVec);
                        break;

                        //default:
                }

                thisSpawnItem++;
                yield return new WaitForSeconds(2.0f);  // 2 secs btwn each; could randomize or put in another array to hardcode
            }
            // restart and just loop again from the beginning
            thisSpawnItem = 0;   
            yield return null;;
        }

    }
}
