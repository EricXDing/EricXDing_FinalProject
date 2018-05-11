using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menu : MonoBehaviour {

	public static bool GameIsPaused = false;
	public GameObject FPC;
	public GameObject MenuUI;



	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.P))
		{
			if (GameIsPaused)
			{
				Resume();
			} else
			{
				Pause();
			}
		}
	}

	void Resume()
	{
		MenuUI.SetActive(false);
		Time.timeScale = 1f;
		GameIsPaused = false;
		FPC.GetComponent<UnityStandardAssets.Characters.FirstPerson.FirstPersonController> ().m_MouseLook.m_cursorIsLocked = true;
		FPC.GetComponent<UnityStandardAssets.Characters.FirstPerson.FirstPersonController> ().m_MouseLook.XSensitivity = 2f;
		FPC.GetComponent<UnityStandardAssets.Characters.FirstPerson.FirstPersonController> ().m_MouseLook.YSensitivity = 2f;
	}

	void Pause()
	{
		MenuUI.SetActive(true);
		Time.timeScale = 0f;
		GameIsPaused = true;
		FPC.GetComponent<UnityStandardAssets.Characters.FirstPerson.FirstPersonController> ().m_MouseLook.m_cursorIsLocked = false;
		FPC.GetComponent<UnityStandardAssets.Characters.FirstPerson.FirstPersonController> ().m_MouseLook.XSensitivity = 0f;
		FPC.GetComponent<UnityStandardAssets.Characters.FirstPerson.FirstPersonController> ().m_MouseLook.YSensitivity = 0f;
	}

}
