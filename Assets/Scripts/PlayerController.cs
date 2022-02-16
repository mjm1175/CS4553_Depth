using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/***********************************
Goes on player object
Controls input keys (space, l, r) and movement
***********************************/
public class PlayerController : MonoBehaviour
{
    public Transform lane1Pos;
    public Transform lane2Pos;
    public Transform lane3Pos;
    private int currentLane = 2;
    private bool isMoving = false;
    private bool isRecharging = false;
    private Animator playerAnim;

    public float coolDownTime = 1.0f;
    public float speed = 0.5f;
    public GameObject bullet;

    void Start(){
        playerAnim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && !isRecharging){
            GameObject thisBullet = Instantiate(bullet, transform);
            thisBullet.GetComponent<BulletMove>().endPos = new Vector3(transform.position.x, 3.07f, 0);
            isRecharging = true;
            

        }
        if (Input.GetKey(KeyCode.LeftArrow) && !isMoving){
            switch (currentLane)
            {
                // can't move left if in lane 1
                //case 1:

                // from lane 2 to lane 1
                case 2:
                    StartCoroutine(Move(lane2Pos.position, lane1Pos.position));
                    isMoving = true;
                    currentLane = 1;
                    //Debug.Log("Moving left; Old lane: 2, new lane: 1");    
                    break;

                // from lane 3 to lane 1
                case 3:
                    StartCoroutine(Move(lane3Pos.position, lane2Pos.position));
                    isMoving = true;
                    currentLane = 2;
                    //Debug.Log("moving left; Old lane: 3, new lane: 2");      
                    break;
                //default:
            }

        } else if (Input.GetKey(KeyCode.RightArrow) && !isMoving){
            switch (currentLane)
            {
                // from lane 1 to lane 2
                case 1:
                    StartCoroutine(Move(lane1Pos.position, lane2Pos.position));
                    isMoving = true;
                    currentLane = 2;
                    //Debug.Log("Moving right; Old lane: 1, new lane: 2");      
                    break;
                
                // from lane 2 to lane 3
                case 2:
                    StartCoroutine(Move(lane2Pos.position, lane3Pos.position));
                    isMoving = true;
                    currentLane = 3;
                    //Debug.Log("moving right; Old lane: 2, new lane: 3");      
                    break;
                
                // can't move right if in lane 3
                //case 3:
                //default:
            }
        }
        if(coolDownTime < 0){
            isRecharging = false;
            coolDownTime = 1.0f;
        }
        coolDownTime -= Time.deltaTime;
        playerAnim.SetBool("isRecharging_b", isRecharging);
    }


    IEnumerator Move(Vector3 startPos, Vector3 endPos)
    {
        float timeElapsed = 0.0f;
        while (timeElapsed < 1.0)
        {
            transform.position = Vector3.Lerp(startPos, endPos, timeElapsed);
            timeElapsed += Time.deltaTime * (1.0f / speed);
            yield return null;
        }
        isMoving = false;
        yield return null;
    }
}
