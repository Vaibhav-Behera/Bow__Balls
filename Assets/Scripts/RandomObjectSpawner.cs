using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomObjectSpawner : MonoBehaviour
{   
    public GameObject[] myObjects;
    public float pool;
    public float f;

    void Update()
    {
        while (pool<f)
        {
            int randomIndex = Random.Range(0, myObjects.Length);
            Vector3 randomSpawnPosition = new Vector3(Random.Range(0, 10), 5, Random.Range(0, 10));

            Instantiate(myObjects[randomIndex], randomSpawnPosition, Quaternion.identity);
            pool++;
        }
    } 
}
