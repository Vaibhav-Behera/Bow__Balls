
using UnityEngine;

public class Move : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed = 2;
    void Update()
    {
    float x = Input.GetAxis("Vertical");
    float z = Input.GetAxis("Horizontal");
    Vector3 movement = new Vector3(-x, 0, -z);
    transform.Translate(movement * speed * Time.deltaTime);
    }
}
