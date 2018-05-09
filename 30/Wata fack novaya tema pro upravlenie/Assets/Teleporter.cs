using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleporter : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void OnTriggerEnter(Collider other) {
		if (other.name == "Cube") {
			other.transform.position = new Vector3(0.09f, 1.95f, 287.79f);
		}
	}
}
