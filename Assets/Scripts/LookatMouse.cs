using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookatMouse : MonoBehaviour
{
    [SerializeField]
    private GameObject _bow;
    // Start is called before the first frame update
    public Bow script;

    // Update is called once per frame
    void FixedUpdate()
    {
        Ray rayOrigin = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hitinfo;
        if(Physics.Raycast(rayOrigin, out hitinfo))
        {
            if(hitinfo.collider != null)
            {
                Vector3 direction = hitinfo.point - script.arrow.transform.position;
                script.arrow.transform.rotation = Quaternion.LookRotation(direction);
            }
        }
    }
}
