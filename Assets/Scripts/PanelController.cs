using System;
using UnityEngine;
using TMPro;

public class PanelController : MonoBehaviour {
	[SerializeField] private GameObject MenuCanvas;
	[SerializeField] private GameObject PauseCanvas;
	[SerializeField] private GameObject DisplayPanel;
	[SerializeField] private GameObject WinnerCanvas;
	
	
	[SerializeField] private TMP_Text Title;
	[SerializeField] private TMP_Text MainText;
	[SerializeField] private TMP_Text WinnerNameText;

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
	
	public void WinnerCanvasOff() {
		WinnerCanvas.SetActive(false);
	}
	
	public void WinnerCanvasOn() {
		WinnerCanvas.SetActive(true);
	}

	public void DisplaySomething(string title, string mainText) {
		Title.text = title;
		MainText.text = mainText;

		DisplayPanelOn();
	}

	public void SetWinner(string name) {
		WinnerNameText.text = name;
		
		WinnerCanvasOn();
	}

	private void Update() {
		if (Input.GetKey(KeyCode.Return)) {
			MenuCanvasOff();
			DisplayPanelOff();
		}
	}
}
