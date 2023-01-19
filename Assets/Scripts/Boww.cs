using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boww : MonoBehaviour
{
    // Start is called before the first frame update
   public KeyCode fireButton;

    public Transform spawn;
    public GameObject arrowObj;
   

    public GameObject arrow;

    float _charge = 80;

    public float chargeMax;
    public float chargeRate;

    //public Vector3 localcentreofmass;
    

    
    [SerializeField] private GameObject ArrowContainer;
    

    void popup()
    {
       arrow = Instantiate(arrowObj, spawn.position, transform.rotation * Quaternion.Euler(270, 180, 0)) as GameObject;
       //arrow.transform.parent =  ArrowContainer.transform;
       arrow.GetComponent<Rigidbody>().AddForce(spawn.forward * _charge, ForceMode.Impulse);
    }
   void update()
   {
        // if (Input.GetKey(fireButton)&& _charge < chargeMax)
        // {
        //     //popup();
        //     // arrow.GetComponent<Rigidbody>().useGravity = false;
        //     // arrow.GetComponent<Rigidbody>().AddForce(spawn.forward * _charge, ForceMode.Impulse);
        //     // arrow.GetComponent<Rigidbody>().useGravity = true;
        //     Debug.Log("Hell");
        // }
   }
        // if (Input.GetKey(fireButton) && _charge < chargeMax)
        // {
        //     _charge += Time.fixedDeltaTime * chargeRate;
        //     arrow.GetComponent<Rigidbody>().useGravity = false;
        //     arrow.transform.position += new Vector3(0,0,0.0091955f);  

        //     Debug.Log(_charge.ToString());
        // }
        // if (Input.GetKeyUp(fireButton))
        // {  
        //    arrow.GetComponent<Rigidbody>().AddForce(spawn.forward * _charge, ForceMode.Impulse);
        //    //arrow.GetComponent<Rigidbody>().centerOfMass = localcentreofmass;
        //    arrow.GetComponent<Rigidbody>().useGravity = true;
        //    _charge = 0;
        // }

}
