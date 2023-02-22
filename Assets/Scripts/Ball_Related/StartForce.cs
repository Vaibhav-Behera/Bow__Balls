using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartForce : MonoBehaviour
{
    public ParticleSystem particleSys;
    public Vector3 startForce;
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Wall")
        {   
            Debug.Log("Hit");
            //particleSys.Play();
            FindObjectOfType<AudioManager>().Play("Bounce");
        }
    }
    void Start()
    {
        Rigidbody rigidbody = GetComponent<Rigidbody>();
        rigidbody.AddForce(startForce, ForceMode.Impulse);
    }
    

    public void onDestroy() 
    {
     //Working ig
     //particleSys.Play();
    }


   
}
