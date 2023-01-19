using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ok : MonoBehaviour
{
    // The Button which spawns arrow
    public KeyCode fireButton;
    // The transform where the arrow will spawn
    public Transform spawn;

    //Use of Arrow Prefab
    public GameObject arrowObj;
    public GameObject arrow;

    //The arrows get spawned in this container
    [SerializeField] private GameObject ArrowContainer;

    public Vector2 turn;
   float _charge = 60;

    
    
    //Arrow Spawn function
    void popup()
    {
       arrow = Instantiate(arrowObj, spawn.position, transform.rotation * Quaternion.Euler(270, 180, 0)) as GameObject;// 270 180 0
       arrow.transform.parent =  ArrowContainer.transform;
    }
    
    void Update()
    {
        if (Input.GetKeyDown(fireButton))
        {
            popup();
        // }
        // // Ray rayOrigin = Camera.main.ScreenPointToRay(Input.mousePosition);
        // // RaycastHit hitinfo;
        // // if(Physics.Raycast(rayOrigin, out hitinfo))
        // // {
        // //     if(hitinfo.collider != null)
        // //     {
        // //     Vector3 direction = hitinfo.point - arrow.transform.position;
        // //     arrow.transform.rotation = Quaternion.LookRotation(direction);
        // //     }
        // // }
        // // if(Input.GetKey(fireButton))
        // // {
        // //     turn.x += Input.GetAxis("Mouse X");
        // //     turn.y += Input.GetAxis("Mouse Y");
        // //     arrow.transform.localRotation = Quaternion.Euler(-turn.y, turn.x, 0);
        // // }
        // if (Input.GetKeyUp(fireButton))
        // { 
            arrow.GetComponent<Rigidbody>().useGravity = true; 
           arrow.GetComponent<Rigidbody>().AddForce(spawn.forward * _charge, ForceMode.Impulse);
           //arrow.GetComponent<Rigidbody>().centerOfMass = localcentreofmass;
          // arrow.GetComponent<Rigidbody>().useGravity = true;
           
        }

        //4.73 , 6.73, 32.62

        
    }
}
