using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour {

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	int nomirwoliy = 0;
	float newTime = 0;
	void Update () {
		
		float oldTime = Time.deltaTime;	
		newTime = oldTime + newTime;
		int intTime = (int)newTime;

		if (intTime == 15) {
			
			print (nomirwoliy + "Новая волна монстров");	
			newTime = 0;
			nomirwoliy = nomirwoliy + 1;
		}




	}
}
