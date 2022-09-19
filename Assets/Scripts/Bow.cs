using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bow : MonoBehaviour
{
    public KeyCode fireButton;

    public Transform spawn;
    public Rigidbody arrowObj;

    Rigidbody arrow;

    float _charge;

    public float chargeMax;
    public float chargeRate;

    

    void popup()
    {
        arrow = Instantiate(arrowObj, spawn.position, transform.rotation * Quaternion.Euler(270, 180, 0)) as Rigidbody;
    }

    void Update()
    {
        if (Input.GetKeyDown(fireButton) )
        {
            popup();
            arrow.useGravity=false;
        }
        if (Input.GetKey(fireButton) && _charge < chargeMax)
        {
            _charge += Time.fixedDeltaTime * chargeRate;
            
            //add gravity to the tip of the arrow
            arrow.useGravity=false;
            arrow.position += new Vector3(0, 0, 0.0099955f); 
            // the charge rate will increase the force of the arrow
            // the position will reflect how fast the arrow is moving backwards          
            Debug.Log(_charge.ToString());
        }
        if (Input.GetKeyUp(fireButton))
        {  
            arrow.useGravity=true;
            arrow.AddForce(spawn.forward * _charge, ForceMode.Impulse);
            _charge = 0;
        }
    }
    
    
    
    
    
    
    //Stuff to do
    // Rotate the transform of bow by 180 degrees in x axis upon a button press
    // Enable moving the bow

    // Make the string of the bow work
    // Make the crosshair of bow , shooting where the crosshair is

    //  Make the arrows instantiate using Object Pooling
    // I can make the bow move after enabling that I can increase the difficulty by adding some objects which will hit 
    // the bow and u can only dodge them.
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    // float _charge;

    // public float chargeMax;
    // public float chargeRate;

    // public KeyCode fireButton;

    // public Transform spawn;
    // public Rigidbody arrowObj;
    

    // Rigidbody arrow;

    // // void Start()
    // // {
    // //     arrow = Instantiate(arrowObj, spawn.position, transform.rotation * Quaternion.Euler(270, 180, 0)) as Rigidbody;
    // // }
    // void Update()
    // {
    //     if(Input.GetKey(fireButton) && _charge < chargeMax)
    //     {
    //         _charge += Time.deltaTime * chargeRate;
    //         //arrow = Instantiate(arrowObj, spawn.position, transform.rotation * Quaternion.Euler(270, 180, 0)) as Rigidbody;
    //         // arrow.position += Vector3.back * 2;
    //         Debug.Log(_charge.ToString());
    //     }

    //     if (Input.GetKeyUp(fireButton))
    //     {
    //         arrow = Instantiate(arrowObj, spawn.position, transform.rotation * Quaternion.Euler(270, 180, 0)) as Rigidbody;   
    //         arrow.AddForce(spawn.forward * _charge, ForceMode.Impulse);
    //         _charge = 0;
    //     }
       
    // }
}
