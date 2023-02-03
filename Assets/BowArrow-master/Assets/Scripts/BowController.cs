using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
namespace BowArrow
{

    public class BowController : MonoBehaviour
    {
        // the prefab to use as a projectile - needs to have an ArrowController.cs attached to it
        [SerializeField] private GameObject projectilePF = null;
        [SerializeField] private GameObject projectilePF2 = null;
        [SerializeField] private GameObject projectilePF3 = null;
        // draw distance is measured from the grip to the string at max pull (make sure arrows are long enough)
        [SerializeField] private float maxDrawDistance = 0.74f;
        // the force required to fully draw the string
        [SerializeField] private float maxDrawForce = 450.0f;
        // this is the time it takes the user to fully draw the bow in seconds
        [SerializeField] private float maxDrawTime = 1.0f;
        // brace height is the distance from the grip to the unloaded string position (geometry dependent)
        [SerializeField] private float braceHeight = 0.18f;
        // Time it takes to reload arrow
        [SerializeField] private float reloadTime = 0.5f;

        private bool readyToFire = false;
        private GameObject spawnPoint = null;
        private ArrowController projectileController = null;
        private float actualMaxDraw = 0;
        private float drawDistance = 0;
        private float drawRate = 0;
        public static int arrowcount = 0;

        void Start()
        {
            actualMaxDraw = maxDrawDistance - braceHeight;
            spawnPoint = transform.Find("DrawPoint").gameObject;
            SpawnProjectile();
            drawRate = (actualMaxDraw) / maxDrawTime;
            readyToFire = true;
        }

        void OnCollisionEnter(Collision collision)
        {
        //Check for a match with the specified name on any GameObject that collides with your GameObject
        if (collision.gameObject.tag == "Red_Ball" || collision.gameObject.tag == "Yellow_Ball" || collision.gameObject.tag == "Green_Ball")
        {
            //Add game over script
            Application.Quit();
            Debug.Log("Working");
        }
        }

        void Update()
        {
            if (Input.GetMouseButton(0) && readyToFire && drawDistance < actualMaxDraw)
            {
                drawDistance += drawRate * Time.deltaTime;
                UpdateDrawPoint(drawDistance);
            }
            else if (Input.GetMouseButtonUp(0) && drawDistance > 0.05f)
            {
                FireProjectile();
                drawDistance = 0;
                UpdateDrawPoint(drawDistance);
                readyToFire = false;
                StartCoroutine(ReloadTimer());
            }
            else if (Input.GetMouseButtonUp(0))
            {
                drawDistance = 0;
                UpdateDrawPoint(drawDistance);
            }
            else if (Input.GetMouseButtonDown(1) && readyToFire)
            {
                DestroyProjectile();
            }
        }

        void DestroyProjectile()
        {
            if (projectileController != null)
            {
            Destroy(projectileController.gameObject);
            projectileController = null;
            SpawnProjectile();
            }
        }


        IEnumerator ReloadTimer()
        {
            yield return new WaitForSeconds(reloadTime);
            //int index = UnityEngine.Random.Range(0, functionList.Count);
            //functionList[index]();
            SpawnProjectile();
            readyToFire = true;
        }

        void UpdateDrawPoint(float drawDistance)
        {
            float z = -braceHeight - drawDistance;
            spawnPoint.transform.localPosition = new Vector3(0, 0, z);
        }

            void SpawnProjectile()
            {
              arrowcount++;
              int randomnumber = UnityEngine.Random.Range(0, 3);
              GameObject[] projectiles = new GameObject[] { projectilePF, projectilePF2, projectilePF3 };
              GameObject projectile = Instantiate(projectiles[randomnumber], spawnPoint.transform); 
              projectileController = projectile.GetComponent<ArrowController>();
              float length = projectileController.Length;
              projectile.transform.position = projectile.transform.position + transform.forward * length / 2;
            }

        

        void FireProjectile()
        {
            float fractionOfMax = drawDistance / actualMaxDraw;
            float energy = 0.5f * drawDistance * maxDrawForce * fractionOfMax;
            float mass = projectileController.RB.mass;
            float vel = Mathf.Sqrt(2 * energy / mass);
            projectileController.Launch(vel);
        }

        

    }
}