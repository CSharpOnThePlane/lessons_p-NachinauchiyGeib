using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CaemereConrolir : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}

	// Update is called once per frame
	public GameObject cube;
	void Update () {
		Vector3 cubeCoordinats = cube.transform.position;
		transform.position = new Vector3(transform.position.x,transform.position.y,cubeCoordinats.z);
	}
}
