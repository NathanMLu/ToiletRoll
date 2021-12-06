using UnityEngine;

public class Bed : MonoBehaviour {
	
	private void OnCollisionEnter(Collision collision) {
		if (collision.gameObject.name == "ToiletPaper") {
			collision.gameObject.transform.Find("DisplayPanel").GetComponent<DisplayManager>().
				DisplaySomething("Push me away", "You'll probably need help from other players,\nI'm pretty heavy :)");
		}
	}
}