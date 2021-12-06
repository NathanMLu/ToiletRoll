using UnityEngine;

public class LavaWalls : MonoBehaviour {
    [SerializeField] private GameObject Lava;
    private bool lavafied = false;
    [SerializeField] private Material lavaMaterial;

    private void OnCollisionEnter(Collision collision) {
        if (collision.gameObject.name == "ToiletPaper") {
            collision.gameObject.transform.Find("DisplayPanel").GetComponent<DisplayManager>().
                DisplaySomething("You're so close", "yet so far. Touch the walls, and you\nwill be forced to restart!");
                gameObject.SetActive(false);
            if (!lavafied) {
                foreach (Transform child in Lava.transform) {
                    child.gameObject.GetComponent<MeshRenderer>().material = lavaMaterial;
                }
            }
        }
    }

    public bool isLavafied() {
        return lavafied;
    }
}
