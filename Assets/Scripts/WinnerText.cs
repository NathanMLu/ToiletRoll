using TMPro;
using UnityEngine;

public class WinnerText : MonoBehaviour {
	[SerializeField] private TMP_Text WinnerName;
	[SerializeField] private GameObject WinnerCanvas;
	[SerializeField] private PhotonView PhotonView;

	public void setWinnerName(string name) {
		PhotonView.RPC("WinnerHelper", PhotonTargets.AllBuffered, name);
		WinnerHelper(name);
	}

	[PunRPC]
	void WinnerHelper(string name) {
		WinnerName.text = name;
		WinnerPanelOn();
	}

	public void WinnerPanelOff() {
		WinnerCanvas.SetActive(false);
	}

	public void WinnerPanelOn() {
		WinnerCanvas.SetActive(true);
	}
	
}
