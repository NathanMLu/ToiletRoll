using UnityEngine;

public class HandleBlocker : MonoBehaviour {
    [SerializeField] private ActivationPad activationPad;

    private void OnCollisionEnter(Collision collision) {
        if (collision.gameObject.name == "ToiletPaper") {
            collision.gameObject.transform.Find("DisplayPanel").GetComponent<DisplayManager>().DisplaySomething("You can't pass", "Step on the trigger to move this couch!");
        }
    }
    
    private void Update() {
        if (activationPad.hasBeenActivated()) {
            gameObject.SetActive(false);
        }
    }
}
