using UnityEngine;
using System.Collections;

public class DestroyEffect : MonoBehaviour {

    public GameObject explode;


	void Update ()
	{

		if(Input.GetKeyDown(KeyCode.Z) || Input.GetKeyDown(KeyCode.X) || Input.GetKeyDown(KeyCode.C))
		   Destroy(transform.gameObject);
        Instantiate(explode, this.transform.position, Quaternion.identity);
	}
}
