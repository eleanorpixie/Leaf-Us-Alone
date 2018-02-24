using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ButtonManager : MonoBehaviour {
	public Button begin=null;
	public Button play=null;
	public Button credits=null;
	public Button exit=null;
	public Button menu=null;
	// Use this for initialization
	void Start () {
		if (begin != null) {
			Button btn = begin.GetComponent<Button> ();
			btn.onClick.AddListener (TaskOnClick);
		}

		if (play != null) {
			Button btn1 = play.GetComponent<Button> ();
			btn1.onClick.AddListener (TaskOnClick1);
		}

		if (credits != null) {
			Button btn2 = credits.GetComponent<Button> ();
			btn2.onClick.AddListener (TaskOnClick2);
		}

		if (exit != null) {
			Button btn3 = exit.GetComponent<Button> ();
			btn3.onClick.AddListener (TaskOnClick3);
		}

		if (menu != null) {
			Button btn4 = menu.GetComponent<Button> ();
			btn4.onClick.AddListener (TaskOnClick4);
		}
	}
		
	

	void TaskOnClick () {

		SceneManager.LoadScene ("Instructions");
		
	}

	void TaskOnClick1 () {

		SceneManager.LoadScene ("PlayerTesting");

	}

	void TaskOnClick2 () {

		SceneManager.LoadScene ("Credits");

	}

	void TaskOnClick3 () {

		Application.Quit ();

	}

	void TaskOnClick4 () {

		SceneManager.LoadScene ("Menu");

	}
}
