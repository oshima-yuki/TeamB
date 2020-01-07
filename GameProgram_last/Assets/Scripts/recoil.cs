using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class recoil : MonoBehaviour
{
    Vector3 rotationAngles;
    Quaternion rote;
    float rotationCalc;
    Vector3 m_posi;
    Vector3 w_mposi;

    // Start is called before the first frame update
    void Start()
    {
        rotationCalc = rotationAngles.x;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        rote = this.transform.localRotation;
        rotationAngles = rote.eulerAngles;
        m_posi = Input.mousePosition;

        w_mposi = Camera.main.ScreenToWorldPoint(m_posi);


        //Debug.Log("angle:"+rotationAngles.x);
        //Debug.Log("rote:"+rote.x);
        //Debug.Log("mouse" + m_posi);
        //Debug.Log("mouse" + w_mposi);

        if (Input.GetMouseButton(0))
        {
            if (rote.x < 0.6)
            {
                rotationAngles.x -= 0.3f;
                rote = Quaternion.Euler(rotationAngles);
                //Debug.Log(rotationAngles.x);
                //Debug.Log(rote.x);
                this.transform.localRotation = rote;
            }
        }else if (rote.x>0.6)
        {
            rotationAngles.x = 0;
            rote = Quaternion.Euler(rotationAngles);
            this.transform.localRotation = rote;
        }
    }

}