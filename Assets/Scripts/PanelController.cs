using System;
using UnityEngine;
using TMPro;

public class PanelController : MonoBehaviour {
	[SerializeField] private GameObject MenuCanvas;
	[SerializeField] private GameObject PauseCanvas;
	[SerializeField] private GameObject DisplayPanel;

	[SerializeField] private TMP_Text Title;
	[SerializeField] private TMP_Text MainText;

	public void PauseCanvasOn() {
		PauseCanvas.SetActive(true);
	}

	public void PauseCanvasOff() {
		PauseCanvas.SetActive(false);
	}

	public void MenuCanvasOn() {
		MenuCanvas.SetActive(true);
	}

	public void MenuCanvasOff() {
		MenuCanvas.SetActive(false);
	}
	
	public void DisplayPanelOn() {
		DisplayPanel.SetActive(true);
	}

	public void DisplayPanelOff() {
		DisplayPanel.SetActive(false);
	}

	public void DisplaySomething(string title, string mainText) {
		Title.text = title;
		MainText.text = mainText;

		DisplayPanelOn();
	}
}
