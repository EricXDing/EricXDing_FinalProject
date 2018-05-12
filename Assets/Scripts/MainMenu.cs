using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {

	void Update () {

	}

	public void StartGame()
	{
		SceneManager.LoadScene("Intro");
	}

	public void Collection()
	{
		SceneManager.LoadScene("Collection");
	}

	public void QuitGame()
	{
		Application.Quit();
	}
}
