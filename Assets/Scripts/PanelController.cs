using System;
using UnityEngine;
using TMPro;

public class PanelController : MonoBehaviour {
	[SerializeField] private GameObject MenuCanvas;
	[SerializeField] private GameObject PauseCanvas;
	[SerializeField] private GameObject DisplayPanel;

	[SerializeField] private TMP_Text Title;
	[SerializeField] private TMP_Text MainText;
	
	[SerializeField] private PhotonView photonView;

	public void PauseCanvasOn() {
		if (photonView.isMine) {
			PauseCanvas.SetActive(true);
		}
	}

	public void PauseCanvasOff() {
		if (photonView.isMine) {
			PauseCanvas.SetActive(false);
		}
	}

	public void MenuCanvasOn() {
		if (photonView.isMine) {
			MenuCanvas.SetActive(true);
		}
	}

	public void MenuCanvasOff() {
		if (photonView.isMine) {
			MenuCanvas.SetActive(false);
		}
	}

	public void DisplayPanelOff() {
		if (photonView.isMine) {
			DisplayPanel.SetActive(false);
		}
	}

	public void DisplaySomething(string title, string mainText) {
		Title.text = title;
		MainText.text = mainText;

		DisplayPanelOn();
	}

	public void DisplayPanelOn() {
		if (photonView.isMine) {
			DisplayPanel.SetActive(true);
		}
	}
}
