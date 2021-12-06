using UnityEngine;

public class HandleSink : MonoBehaviour {
	[SerializeField] private ActivationPad activationPad1;
	[SerializeField] private ActivationPad activationPad2;
	[SerializeField] private AudioHandler AudioHandler;

	private void OnCollisionEnter(Collision collision) {
		if (collision.gameObject.name == "ToiletPaper") {
			AudioHandler.PlayError();
			collision.gameObject.transform.Find("DisplayPanel").GetComponent<DisplayManager>().
				DisplaySomething("You can't pass", "Step on both triggers at the same\ntime to move this sink!");
		}
	}
    
	private void Update() {
		if (activationPad1.hasBeenActivated() && activationPad2.hasBeenActivated()) {
			gameObject.SetActive(false);
		}
	}
}