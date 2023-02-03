using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int numberofInvokes = 0;
    public static int numberofCalls = 0;
    private GameObject Ball;
    private GameObject Ball2;
    private GameObject Ball3;
    public GameObject RedBall;
    public GameObject YellowBall;
    public GameObject GreenBall;
    bool functioncalled = false;
    
    // Start is called before the first frame update
    void Start()
    {
        numberofCalls = 0;
    }

    // Update is called once per frame
    void Update()
    {
    
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

    while(numberofInvokes <= 3)
    {
        popredball();
        numberofInvokes +=1;
    }
    if(numberofCalls == 3 && functioncalled == false)
    {
       popyellowball();
       popgreenball();
       popyellowball();
       popgreenball();
       popyellowball();
       popgreenball();
       popyellowball();
       popgreenball();
       popyellowball();
       popgreenball();
       popyellowball();
       popgreenball();
        functioncalled = true;
    }

    if(ArrowsLeft.left == -1)
    {
        Debug.Log("Make A EndGame Popup due to arrows");
    }
    if (TimeLeft.remainingTime <= 0)
        {
         Debug.Log("Make A EndGame Popup due to time");
            // Timer has elapsed, do something
        }
    }

   
}
