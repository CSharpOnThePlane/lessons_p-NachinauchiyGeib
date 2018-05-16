using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	static public int redScore = 0;
	static public int blueScore = 0;
	// Update is called once per frame
	void Update () {
		
		Text textField = GetComponent<Text>();
		// красиво форматируем очки 
		// и выводим в текстовое поле
		textField.text = redScore + ":" + blueScore;

	
	
	}
}
