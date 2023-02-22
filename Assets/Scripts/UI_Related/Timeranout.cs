using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timeranout : MonoBehaviour
{
    public GameObject timeranoutUI;
    public GameObject canvas;
   

    // Start is called before the first frame update
    void Start()
    {
        // Check if the remaining time is already zero
        if (TimeLeft.remainingTime <= 0)
        {
            timeranoutUI.SetActive(true);
        }
        else
        {
            // Deactivate the timeranoutUI GameObject
            timeranoutUI.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (TimeLeft.remainingTime < 0)
        {
            timeranoutUI.SetActive(true);
            canvas.SetActive(false);
        }
    }
}

