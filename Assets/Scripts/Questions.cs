using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[System.Serializable]

public class Question {

	public string name;
	public string QuestionNumber;

	[TextArea(3, 10)]
	public string[] sentences;

	

	// GameObject.Find("buttonName").GetComponentInChildren<Text>().text = "la di da";

}
