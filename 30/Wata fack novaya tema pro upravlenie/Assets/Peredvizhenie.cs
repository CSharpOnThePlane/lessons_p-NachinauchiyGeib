using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Peredvizhenie : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		Rigidbody rigid = GetComponent<Rigidbody> ();

		if (Input.GetKey(KeyCode.Space)){
			
			rigid.velocity = new Vector3(0f, 10f,-1f);
		}
	}
}
