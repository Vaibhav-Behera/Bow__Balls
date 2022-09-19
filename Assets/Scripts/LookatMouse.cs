using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookatMouse : MonoBehaviour
{
    [SerializeField]
    private Transform _bow;
    // Start is called before the first frame update
   

    // Update is called once per frame
    void FixedUpdate()
    {
        Ray rayOrigin = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hitinfo;
        if(Physics.Raycast(rayOrigin, out hitinfo))
        {
            if(hitinfo.collider != null)
            {
                Vector3 direction = hitinfo.point - _bow.position;
                _bow.rotation = Quaternion.LookRotation(direction);
            }
        }
    }
}
