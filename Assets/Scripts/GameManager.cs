using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // public GameObject timeranoutUI;
    float timer = 0f;
    float redBalltimer = 0f;
    float greenBalltimer = 0f;
    float yellowBalltimer = 0f;
    bool isDifficultyIncreased = false;
    // public int numberofInvokes = 0;
    // public static int numberofCalls = 0;
    // bool functioncalled = false;
    private GameObject Ball;
    private GameObject Ball2;
    private GameObject Ball3;
    public GameObject RedBall;
    public GameObject YellowBall;
    public GameObject GreenBall;
    
    // Start is called before the first frame update
    void Start() 
    {
        
    }

    // Update is called once per frame
    
    



    void Update()
    {
        
    redBalltimer += Time.deltaTime;
    yellowBalltimer += Time.deltaTime;
    greenBalltimer += Time.deltaTime;

    // spawn a red ball every 5 seconds, or every 4 seconds if difficulty is increased
    float redBallSpawnInterval = isDifficultyIncreased ? 7f : 8f;
    if (redBalltimer > redBallSpawnInterval)
    {
        popredball();
        redBalltimer = 0f; // reset the timer
    }

    // spawn a yellow ball every 10 seconds, or every 8 seconds if difficulty is increased
    float yellowBallSpawnInterval = isDifficultyIncreased ? 12f : 15f;
    if (yellowBalltimer > yellowBallSpawnInterval)
    {
        popyellowball();
        yellowBalltimer = 0f; // reset the timer
    }

    // spawn a green ball every 15 seconds, or every 12 seconds if difficulty is increased
    float greenBallSpawnInterval = isDifficultyIncreased ? 15f : 18f;
    if (greenBalltimer > greenBallSpawnInterval)
    {
        popgreenball();
        greenBalltimer = 0f; // reset the timer
    }

    // check if 2 minutes have passed and difficulty is not yet increased
    if (timer > 300f && !isDifficultyIncreased)
    {
        // increase difficulty by setting the flag to true
        isDifficultyIncreased = true;
        timer = 0f; // reset the timer
    }

    // check if 10 minutes have passed and difficulty is increased
    if (timer > 600f && isDifficultyIncreased)
    {
        // keep the difficulty constant by not reducing the time between ball spawns
        timer = 0f; // reset the timer
    }

    // while(numberofInvokes <= 3)
    // {
    //     popredball();
    //     numberofInvokes +=1;
    // }
    // if(numberofCalls == 3 && functioncalled == false)
    // {
    //    popyellowball();
    //    popgreenball();
    //    popyellowball();
    //    popgreenball();
    //    popyellowball();
    //    popgreenball();
    //    popyellowball();
    //    popgreenball();
    //    popyellowball();
    //    popgreenball();
    //    popyellowball();
    //    popgreenball();
    //     functioncalled = true;
    // }
    
    if(ArrowsLeft.used == +1)
    {
        //Debug.Log("Make A EndGame Popup due to arrows");
    }
    // if (TimeLeft.remainingTime <= 0)
    //     {
    //      timeranoutUI.SetActive(true);
    //      Debug.Log("Make A EndGame Popup due to time");
    //         // Timer has elapsed, do something
    //     }

    void popredball()
    {
       Vector3 randomSpawnPosition = new Vector3(Random.Range(0, 10), 5, Random.Range(0, 10));
       Ball = Instantiate(RedBall, randomSpawnPosition, Quaternion.identity);
    }

    void popyellowball()
    {
       Vector3 randomSpawnPosition = new Vector3(Random.Range(0, 10), 5, Random.Range(0, 10));
       Ball2 = Instantiate(YellowBall, randomSpawnPosition, Quaternion.identity);
    }

    void popgreenball()
    {
       Vector3 randomSpawnPosition = new Vector3(Random.Range(0, 10), 5, Random.Range(0, 10));
       Ball3 = Instantiate(GreenBall, randomSpawnPosition, Quaternion.identity);
    }
    }

   
}
