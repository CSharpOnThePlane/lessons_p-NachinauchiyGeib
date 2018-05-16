using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GatesOfHellScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	public GameObject Ball;
	void Update () {
		
	}
	void OnTriggerEnter (Collider other) {
		if (other.tag == "BallTag") {
			// то самоуничтожаемся через секунду
			Destroy(other.gameObject);
			Instantiate(Ball, new Vector3(52.87341f, 2.953f, 38.49698f), Quaternion.identity);
			Score.blueScore++;
		}
	}
}