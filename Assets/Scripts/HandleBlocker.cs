using UnityEngine;

public class HandleBlocker : MonoBehaviour {
    [SerializeField] private ActivationPad activationPad;
    [SerializeField] private AudioHandler AudioHandler;

    private void OnCollisionEnter(Collision collision) {
        if (collision.gameObject.name == "ToiletPaper") {
            AudioHandler.PlayError();
            collision.gameObject.transform.Find("DisplayPanel").GetComponent<DisplayManager>().DisplaySomething("You can't pass", "Step on the trigger to move this couch!");
        }
    }
    
    private void Update() {
        if (activationPad.hasBeenActivated()) {
            gameObject.SetActive(false);
        }
    }
}
