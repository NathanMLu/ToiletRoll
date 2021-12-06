using System;
using UnityEngine;
using TMPro;

public class PanelController : MonoBehaviour {
	[SerializeField] private GameObject MenuCanvas;
	[SerializeField] private GameObject PauseCanvas;

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
}
