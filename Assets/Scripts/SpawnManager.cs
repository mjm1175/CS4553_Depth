using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject trigPrefab;
    public GameObject crossPrefab;
    public GameObject circPrefab;

    public Transform lane1SP;
    public Transform lane2SP;
    public Transform lane3SP;

    private int thisSpawnItem = 0;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnItems());
    }

    IEnumerator SpawnItems(){
        // 8 is length of pre-made spawn items and locations (arrays in GlobalVars)
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
                    Instantiate(trigPrefab, spawnHere);
                    break;
                case 'c':
                    Instantiate(circPrefab, spawnHere);
                    break;
                case 'x':
                    Instantiate(crossPrefab, spawnHere);
                    break;
                //default:
            }

            thisSpawnItem++;
            yield return new WaitForSeconds(2.0f);  // 2 secs btwn each; could randomize or put in another array to hardcode
        }
    }
}
