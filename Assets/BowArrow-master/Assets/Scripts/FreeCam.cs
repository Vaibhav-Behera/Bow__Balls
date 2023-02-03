using System.Collections;
using UnityEngine;

namespace BowArrow
{
    public class FreeCam : MonoBehaviour
    {
        [SerializeField] private float speed = 10.0f;
        [SerializeField] private float sensitivity = 1.0f;
        [SerializeField] private float dashSpeed = 20.0f;
        [SerializeField] private float dashDuration = 0.5f;

        private bool isDashing = false;
        private float dashTimer = 0.0f;

        void Update()
        {
            Cursor.lockState = CursorLockMode.Locked;

            // rotation
            Vector3 rotCam = transform.rotation.eulerAngles;
            rotCam.x -= Input.GetAxis("Mouse Y") * sensitivity;
            rotCam.y += Input.GetAxis("Mouse X") * sensitivity;
            transform.rotation = Quaternion.Euler(rotCam);

            // dash
            if (Input.GetKeyDown(KeyCode.Space) && !isDashing)
            {
                isDashing = true;
                dashTimer = 0.0f;
            }

            if (isDashing)
            {
                dashTimer += Time.deltaTime;
                transform.Translate(Vector3.forward * Time.deltaTime * dashSpeed);
                if (dashTimer >= dashDuration)
                {
                    isDashing = false;
                }
            }
            else
            {
                // translation
                Vector3 transCam = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
                transCam = transCam * Time.deltaTime * speed * sensitivity;
                transform.Translate(transCam);

                // vertical movement
                if (Input.GetKey(KeyCode.Q))
                {
                    transform.Translate(Vector3.down * Time.deltaTime * speed * sensitivity, Space.World);
                }
                if (Input.GetKey(KeyCode.E))
                {
                    transform.Translate(Vector3.up * Time.deltaTime * speed * sensitivity, Space.World);
                }
            }
        }
    }
}


