using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class QuestionManager : MonoBehaviour {

	// public Text nameText;
	public Text dialogue;
	public Text sidelog;
	public Button B1;
	public Button B2;
	public Text TextB1;
	public Text TextB2;

	private Queue<string> sentences;

	// Use this for initialization
	void Start () {
		sentences = new Queue<string>();
		B1.gameObject.SetActive(false);
		B2.gameObject.SetActive(false);

	}

	public void StartQuestion (Question dialogue)
	{
		// nameText.text = dialogue.name;
		sentences.Clear();
		foreach (string sentence in dialogue.sentences)
		{
			sentences.Enqueue(sentence);
		}
		B1.gameObject.SetActive(true);
		B2.gameObject.SetActive(true);
		DisplayNextSentence();
	}

	public void DisplayMistake ()
	{
		sidelog.text = "Are you sure? Think again...";
	}

	public void DisplayReason ()
	{
		if (sentences.Count == 6)
		{
			sidelog.text = "";
		}
		if (sentences.Count == 5)
		{
			sidelog.text = "In generally, everyone has the duty not to harm; however, when A is an invitee of B, B's duty is elevated to duty to protect.";
		}
		if (sentences.Count == 4)
		{
			sidelog.text = "If A has the duty to protect, then failure to reduce a risk (even thought that risk was created by another) is a breach of that duty";
		}
		if (sentences.Count == 3)
		{
			sidelog.text = "If the victim would not have been injury but-for the perptrator's action/inaction, then the perptrator's action is an causation";
		}
		if (sentences.Count == 2)
		{
			sidelog.text = "Victims can claim special damages, which are any damage that can be measured with reasonable certainty.";
		}
		if (sentences.Count == 1)
		{
			sidelog.text = "";
		}
	}


	public void DisplayNextSentence ()
	{
		if (sentences.Count == 0)
		{
			EndDialogue();
			return;
		}
		if (sentences.Count == 6)
		{
			B1.gameObject.SetActive(false);
			B2.gameObject.SetActive(true);
			TextB2.text = "continue";
			DisplayReason ();
		}
		if (sentences.Count == 5)
		{
			B1.gameObject.SetActive(true);
			B2.gameObject.SetActive(true);
			TextB1.text = "Duty to Not Harm";
			TextB2.text = "Duty to Protect";
			DisplayReason ();
		}
		if (sentences.Count == 4)
		{
			B1.gameObject.SetActive(true);
			B2.gameObject.SetActive(true);
			TextB1.text = "No; C is not liable for action of another person";
			TextB2.text = "Yes; C didn't clean up the puddle";
			DisplayReason ();
		}
		if (sentences.Count == 3)
		{
			B1.gameObject.SetActive(true);
			B2.gameObject.SetActive(true);
			TextB1.text = "No; there would be no injury if B had not pushed you";
			TextB2.text = "Yes; C is still a part of the CAUSE";
			DisplayReason ();
		}
		if (sentences.Count == 2)
		{
			B1.gameObject.SetActive(true);
			B2.gameObject.SetActive(true);
			TextB1.text = "$100; the medical bill";
			TextB2.text = "$300; the medical bill and lost wages";
			DisplayReason ();
		}
		if (sentences.Count == 1)
		{
			B1.gameObject.SetActive(false);
			B2.gameObject.SetActive(true);
			TextB2.text = "Return to Main Game Menu";
		}
		string sentence = sentences.Dequeue();
		dialogue.text = sentence;
		print(sentences.Count);
	}


	void EndDialogue()
	{
		// Debug.Log("End of the Conversation");
		SceneManager.LoadScene("Main");
	}

}
