using System;
using UnityEngine;

public class ActivationPad : MonoBehaviour {
	[SerializeField] private Material green;
	[SerializeField] private Material red;
	[SerializeField] private AudioHandler AudioHandler;
	private bool activated = false;
	
	private void OnCollisionEnter(Collision collision) {
		if (collision.gameObject.name == "ToiletPaper") {
			AudioHandler.PlaySuccess();
			gameObject.GetComponent<MeshRenderer>().material = green;
			activated = true;
		}
	}

	private void OnCollisionExit(Collision col) {
		if (col.gameObject.name == "ToiletPaper") {
			gameObject.GetComponent<MeshRenderer>().material = red;
			activated = false;
		}
	}

	public bool hasBeenActivated() {
		return activated;
	}
}