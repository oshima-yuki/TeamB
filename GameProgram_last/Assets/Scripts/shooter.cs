using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shooter : MonoBehaviour
{
    public GameObject bullet;

    public Transform muzzle;

    public float speed = 1000;

    public GameObject cam;

    private float timeleft;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //Quaternion rote = this.transform.localRotation;
        //Quaternion roteg = this.transform.localRotation;


        //Vector3 rotationAngles = rote.eulerAngles;
        //Vector3 rotationAngles_gun = rote.eulerAngles;
        if (Input.GetMouseButton(0))
        {
            timeleft -= Time.deltaTime;
            GameObject bullets = Instantiate(bullet) as GameObject;

            Vector3 force;
            if (timeleft <= 0.0)
            {
                force = this.gameObject.transform.forward * speed;

                bullets.GetComponent<Rigidbody>().AddForce(force);

                bullets.transform.position = muzzle.position;
                timeleft = 0.1f;
            }

        //    if (rotationAngles.x > -30.0f)
        //    {
        //        rotationAngles.x -= 0.3f;
        //    }
        //    else
        //    {
        //        rotationAngles.x = 0.3f;

        //    }
        //    rotationAngles.y = 0;
        //    rotationAngles.z = 0;
        //    rote = Quaternion.Euler(rotationAngles);
        //    this.transform.localRotation = rote;
        //}
        //else
        //{
        //    rotationAngles.x = 0;
        //    rote = Quaternion.Euler(rotationAngles);
        //    this.transform.localRotation = rote;
        }
    }

 

}
