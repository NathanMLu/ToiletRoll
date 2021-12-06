using System;
using UnityEngine;
using TMPro;

public class DisplayManager : MonoBehaviour {
	public TMP_Text Title;
	public TMP_Text MainText;
	public PhotonView PhotonView;
	public GameObject DisplayCanvas;
	private GameObject GameManager;

	public void DisplayPanelOn() {
		if (PhotonView.isMine) {
			DisplayCanvas.SetActive(true);
		}
	}

	public void DisplayPanelOff() {
		DisplayCanvas.SetActive(false);
	}

	public void DisplaySomething(string title, string mainText) {
		if (PhotonView.isMine) {
			Title.text = title;
			MainText.text = mainText;

			DisplayPanelOn();
		}
	}

	void Start() {
		GameManager = GameObject.FindGameObjectWithTag("GameController");
	}
	
	private void Update() {
		if (Input.GetKeyDown(KeyCode.W) ||
		    Input.GetKeyDown(KeyCode.A) ||
		    Input.GetKeyDown(KeyCode.S) ||
		    Input.GetKeyDown(KeyCode.D) ||
		    Input.GetKeyDown(KeyCode.RightArrow) ||
		    Input.GetKeyDown(KeyCode.LeftArrow) ||
		    Input.GetKeyDown(KeyCode.DownArrow) ||
		    Input.GetKeyDown(KeyCode.UpArrow)) {
			
			DisplayPanelOff();
		}

		if (GameManager.GetComponent<GameManager>() == false) {
			DisplayPanelOff();
		}
	}
}