using UnityEngine;
using UnityEngine.UI;

public class Collide_Green : MonoBehaviour
{
public static int points_green;

void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Wall")
        {   
            Debug.Log("Hit");
            FindObjectOfType<AudioManager>().Play("Bounce");
        }
        if (collision.gameObject.tag == "Green_Ball")
        {
            //If the GameObject's name matches the one you suggest, output this message in the console
            Destroy(this.gameObject);
            Destroy(collision.gameObject);
            FindObjectOfType<AudioManager>().Play("Pop");
            Debug.Log("Do something here");
            points_green +=100;
            //GameManager.numberofCalls +=1;
        }

        if (collision.gameObject.tag == "Yellow_Ball" || collision.gameObject.tag == "Red_Ball")
        {
            points_green -=50;
            FindObjectOfType<AudioManager>().Play("ArrowHit");
        }
       

    }
}
