using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if(Input.GetKey(KeyCode.D))
        {
            Vector3 v = transform.position;
            v.x = v.x + 0.05f;
            transform.position = v;
        }

        else if (Input.GetKey(KeyCode.A))
        {
            Vector3 v = transform.position;
            v.x = v.x - 0.05f;
            transform.position = v;
        }

    }
}
