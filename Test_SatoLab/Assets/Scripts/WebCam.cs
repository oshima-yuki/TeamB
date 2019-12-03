using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WebCam : MonoBehaviour
{
    void Start()
    {   // ...(1)
        WebCamDevice[] devices = WebCamTexture.devices;   // ...(2)
        if (devices.Length > 0)   // ...(3)
        {
            WebCamTexture myWebCameTexture = new WebCamTexture(devices[0].name);
            GameObject cube = GameObject.Find("Cube");  // ...(4)
            GameObject sphere = GameObject.Find("Sphere");  // ...(4)
            GameObject plane = GameObject.Find("Plane");  // ...(4)
            //cube.GetComponent<Renderer>().material.mainTexture = myWebCameTexture;
            //sphere.GetComponent<Renderer>().material.mainTexture = myWebCameTexture;
            plane.GetComponent<Renderer>().material.mainTexture = myWebCameTexture;
            myWebCameTexture.Play();
        }
        else
        {
            Debug.LogError("Webカメラが検出できません！");
        }
    }
}
