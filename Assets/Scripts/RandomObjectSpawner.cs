using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomObjectSpawner : MonoBehaviour
{   
    public GameObject[] myObjects;
    public float pool;
    public float f;
    public float counter;

    void spawn()
    {
        int randomIndex = Random.Range(0, myObjects.Length);//new stuff
        Vector3 randomSpawnPosition = new Vector3(Random.Range(0, 10), 5, Random.Range(0, 10));

        Instantiate(myObjects[randomIndex], randomSpawnPosition, Quaternion.identity);
        pool++;
    }
    void Update()
    {
        while (pool<f)
        {
            spawn();
            counter++;
        }

        if (counter==15)
        {
            spawn();
        }
    } 
}
