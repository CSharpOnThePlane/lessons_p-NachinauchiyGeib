using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RollerBallIsNowYourEnemy : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	public Transform rollerBall;
	void Update () {
		float dist = Vector3.Distance(rollerBall.transform.position, transform.position);
		if (dist < 2) {
			rollerBall.position = new Vector3(25.17595f, 2.85f, 20.78815f);
		}
	}
}
