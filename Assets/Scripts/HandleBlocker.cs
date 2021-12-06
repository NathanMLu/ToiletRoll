using UnityEngine;

public class HandleBlocker : MonoBehaviour {
    [SerializeField] private ActivationPad activationPad;
    [SerializeField] private PanelController panelController;
    
    private void OnCollisionEnter(Collision collision) {
        if (collision.gameObject.name == "ToiletPaper") {
            panelController.DisplaySomething("You can't pass", "Step on the trigger to move this couch!");
        }
    }
    
    private void Update() {
        if (activationPad.hasBeenActivated()) {
            gameObject.SetActive(false);
        }
    }
}
