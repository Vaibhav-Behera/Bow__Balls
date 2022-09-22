using UnityEngine;

public class Shoot : MonoBehaviour
{
    public float damage = 10f ;
    public float range = 100f ;

    public Camera fpsCam;

    void Update()
    {
        if(Input.GetButtonDown("Fire1"))
        {
           Shooot(); 
        }
    }

    void Shooot()
    {
        RaycastHit hit;

        if(Physics.Raycast(fpsCam.transform.position,fpsCam.transform.forward,out hit, range))
        {
            Debug.Log(hit.transform.name);
        }
    }

}
