using System;
using UnityEngine;
using TMPro;

public class DisplayManager : MonoBehaviour {
	public TMP_Text Title;
	public TMP_Text MainText;
	public PhotonView PhotonView;

	public void DisplayPanelOn() {
		gameObject.SetActive(true);
	}

	public void DisplayPanelOff() {
		gameObject.SetActive(false);
	}

	public void DisplaySomething(string title, string mainText) {
		if (PhotonView.isMine) {
			Title.text = title;
			MainText.text = mainText;

			DisplayPanelOn();
		}
		
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
	}
}