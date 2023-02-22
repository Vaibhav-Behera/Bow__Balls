using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public GameObject ControlsUI;
    public GameObject MenuUI;
    public GameObject RulesUI;
    void Update()
    {
    if (Input.GetKeyDown(KeyCode.Return))
    {
        Collide_Red.points_red = 0; 
        Collide_Yellow.points_yellow = 0; 
        Collide_Green.points_green = 0;
        //ArrowsLeft.used = 0;
        BowArrow.BowController.arrowcount = 0;
        TimeLeft timeLeft = FindObjectOfType<TimeLeft>();
        if (timeLeft != null)
        {
            timeLeft.ResetTimer();
        }
        PlayGame();
    }
    if (Input.GetKeyDown(KeyCode.P))
    {
        QuitGame();
    }
    if (Input.GetKeyDown(KeyCode.C))
    {
        RulesUI.SetActive(false);
        MenuUI.SetActive(false);
        ControlsUI.SetActive(true);
        
    }
    if (Input.GetKeyDown(KeyCode.B))
    {
        RulesUI.SetActive(false);
        ControlsUI.SetActive(false);
        MenuUI.SetActive(true);
    }
    if (Input.GetKeyDown(KeyCode.R))
    {
        MenuUI.SetActive(false);
        ControlsUI.SetActive(false);
        RulesUI.SetActive(true);
    }


    }
    public void PlayGame ()
    {
        TimeLeft.remainingTime = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void QuitGame ()
    {
        Application.Quit();
        Debug.Log("Working");
    }
}
