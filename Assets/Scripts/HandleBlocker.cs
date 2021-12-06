using UnityEngine;

public class HandleBlocker : MonoBehaviour {
    [SerializeField] private ActivationPad activationPad;
    [SerializeField] private PanelController panelController;
    [SerializeField] private DisplayManager DisplayManager;
    
    private void OnCollisionEnter(Collision collision) {
        if (collision.gameObject.name == "ToiletPaper") {
            Debug.Log(collision.gameObject);
            Debug.Log(collision.gameObject.transform.Find("DisplayPanel").GetComponent<DisplayManager>());
            collision.gameObject.transform.Find("DisplayPanel").GetComponent<DisplayManager>().DisplaySomething("You can't pass", "Step on the trigger to move this couch!");
        }
    }
    
    private void Update() {
        if (activationPad.hasBeenActivated()) {
            gameObject.SetActive(false);
        }
    }
}
