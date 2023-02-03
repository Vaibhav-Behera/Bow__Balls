using UnityEngine;
using UnityEngine.UI;
public class Collide_Red : MonoBehaviour
{
public static int points_red;

void OnCollisionEnter(Collision collision)
    {
        //Check for a match with the specified name on any GameObject that collides with your GameObject
        if (collision.gameObject.tag == "Red_Ball")
        {
            //If the GameObject's name matches the one you suggest, output this message in the console
            Destroy(this.gameObject);
            Destroy(collision.gameObject);
            points_red +=100;
            GameManager.numberofCalls +=1;
        }
        if (collision.gameObject.tag == "Yellow_Ball" || collision.gameObject.tag == "Green_Ball")
        {
            points_red -=50;
        }
       

    }
}
