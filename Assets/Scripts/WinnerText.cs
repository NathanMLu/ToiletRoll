using TMPro;
using UnityEngine;

public class WinnerText : MonoBehaviour {
	[SerializeField] private TMP_Text WinnerName;
	[SerializeField] private GameObject WinnerCanvas;

	public void setWinnerName(string name) {
		PhotonView photonView = PhotonView.Get(this);
		photonView.RPC("WinnerHelper", PhotonTargets.All, name);
	}

	[PunRPC]
	void WinnerHelper(string name) {
		WinnerName.text = name;
		WinnerCanvas.SetActive(true);
	}

	public void WinnerPanelOff() {
		WinnerCanvas.SetActive(false);
	}
}
