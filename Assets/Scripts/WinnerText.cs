using TMPro;
using UnityEngine;

public class WinnerText : MonoBehaviour {
	[SerializeField] private TMP_Text WinnerName;
	[SerializeField] private GameObject WinnerCanvas;
	[SerializeField] PhotonView PhotonView;

	public void setWinnerName(string name) {
		PhotonView.RPC("WinnerHelper", PhotonTargets.All, name);
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
