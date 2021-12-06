using System;
using UnityEngine;
using TMPro;

public class PanelController : MonoBehaviour {
	[SerializeField] private AudioHandler AudioHandler;
	[SerializeField] private GameObject MenuCanvas;
	[SerializeField] private GameObject PauseCanvas;

	public void PauseCanvasOn() {
		PauseCanvas.SetActive(true);
		AudioHandler.PlayClick();
	}

	public void PauseCanvasOff() {
		PauseCanvas.SetActive(false);
		AudioHandler.PlayClick();
	}

	public void MenuCanvasOn() {
		MenuCanvas.SetActive(true);
		AudioHandler.PlayClick();
	}

	public void MenuCanvasOff() {
		MenuCanvas.SetActive(false);
		AudioHandler.PlayClick();
	}
}
