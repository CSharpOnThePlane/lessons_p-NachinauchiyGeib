using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameRestarter : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	int Timer = 20;
	float time = 0;
	void Update () {
			
		time = time + Time.deltaTime;
		int seconds = (int)time;	
		int TimeDoSliva = Timer - seconds;

		if (TimeDoSliva == 0) {
			print("время вышло");	
			transform.position = new Vector3(25.17595f, 2.85f, 20.78815f);

		}
		if (TimeDoSliva < 0) {
			TimeDoSliva = 0;
			transform.position = new Vector3(25.17595f, 2.85f, 20.78815f);
		}

	}
}
