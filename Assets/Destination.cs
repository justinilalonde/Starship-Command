using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destination : MonoBehaviour {
    private GameObject destination;
	// Update is called once per frame
	void Update ()
    {
	    if (Input.GetButtonDown("move"))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray))
                Instantiate(destination, transform.position, transform.rotation);
        }	
	}
}
