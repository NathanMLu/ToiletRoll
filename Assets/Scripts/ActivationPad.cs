using UnityEngine;

public class ActivationPad : MonoBehaviour {
	[SerializeField] private Material green;
	private bool activated = false;
	
	private void OnCollisionEnter(Collision collision) {
		if (collision.gameObject.name == "ToiletPaper") {
			gameObject.GetComponent<MeshRenderer>().material = green;
			activated = true;
		}
	}

	public bool hasBeenActivated() {
		return activated;
	}
}