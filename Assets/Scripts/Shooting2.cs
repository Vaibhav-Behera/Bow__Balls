using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting2 : MonoBehaviour
{
    public KeyCode fireButton;
        

    public Transform spawn;
    public GameObject arrowObj;
   

    public GameObject arrow;

    float _charge = 80;

    public float chargeMax;
    public float chargeRate;

    //public Vector3 localcentreofmass;
    

    
    [SerializeField] private GameObject ArrowContainer;

    private Camera _mainCamera;

    public Bow script;
    // Start is called before the first frame update
    void Start()
    {
        _mainCamera = Camera.main;
    }

     void popup()
    {
       arrow = Instantiate(arrowObj, spawn.position, transform.rotation * Quaternion.Euler(270, 180, 0)) as GameObject;
       arrow.transform.parent =  ArrowContainer.transform;
       arrow.GetComponent<Rigidbody>().AddForce(spawn.forward * _charge, ForceMode.Impulse);
    }

    // Update is called once per frame
    void Update()
    {
        //  if (Input.GetKeyDown(fireButton) )
        //  {
            // RaycastHit hitt;
            // Ray ray1 = _mainCamera.ScreenPointToRay(Input.mousePosition);
        //     if(Physics.Raycast(ray1, out hitt))
        //     {
        //         popup(hitt.point);
        //     }
        //  }
    }
}
