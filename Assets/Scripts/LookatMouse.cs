using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookatMouse : MonoBehaviour
{
    [SerializeField]
    //private Transform arrowtip;
    // Start is called before the first frame update
    private Ok script;
    public GameObject arrowtip;
    private void Start() {
        script = arrowtip.GetComponent<Ok>();
    }
    // Update is called once per frame
    void FixedUpdate()
    {
        Ray rayOrigin = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hitinfo;
        if(Physics.Raycast(rayOrigin, out hitinfo))
        {
            if(hitinfo.collider != null)
            {
            script.arrow.transform.rotation = Quaternion.LookRotation(hitinfo.point);
            }
        }
    }
}
