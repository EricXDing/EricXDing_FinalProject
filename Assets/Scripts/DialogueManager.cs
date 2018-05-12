using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class DialogueManager : MonoBehaviour {

	public Text nameText;
	public Text dialogue;
	public Button StartGame;
	public Button NextStence;
	public Button OpenDialogue;

	private Queue<string> sentences;

	// Use this for initialization
	void Start () {
		sentences = new Queue<string>();
		StartGame.gameObject.SetActive(false);
		NextStence.gameObject.SetActive(false);
		OpenDialogue.gameObject.SetActive(true);
	}

	public void StartDialogue (Dialogue dialogue)
	{
		// Debug.Log("This is an issue about: " + dialogue.name);
		NextStence.gameObject.SetActive(true);
		OpenDialogue.gameObject.SetActive(false);
		nameText.text = dialogue.name;

		sentences.Clear();

		foreach (string sentence in dialogue.sentences)
		{
			sentences.Enqueue(sentence);
		}

		DisplayNextSentence();
	}

	public void DisplayNextSentence ()
	{
		if (sentences.Count == 0)
		{
			EndDialogue();
			return;
		}

		string sentence = sentences.Dequeue();
		// Debug.Log(sentence);
		dialogue.text = sentence;
	}

	void EndDialogue()
	{
		Debug.Log("End of the Conversation");
		StartGame.gameObject.SetActive(true);
		NextStence.gameObject.SetActive(false);
		OpenDialogue.gameObject.SetActive(true);
	}

}
