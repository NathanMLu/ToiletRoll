using UnityEngine;

public class TrackPlayer : MonoBehaviour {
    private float followSpeed = 2.5f;
    private bool started = false;
    
    private Vector3 distanceFromPlayer;
    public GameObject Player;
    private GameObject GameManager;

    private void Start() {
        GameManager = GameObject.FindGameObjectWithTag("GameController");
    }

    private void Update(){
        if (GameManager.GetComponent<GameManager>().IsRunning()) {
            distanceFromPlayer = new Vector3(0f, 4.625f, -1.2f);
            distanceFromPlayer = Player.transform.position + distanceFromPlayer;
            distanceFromPlayer = Vector3.MoveTowards(transform.position, distanceFromPlayer, followSpeed * Time.deltaTime);
            transform.position = distanceFromPlayer;
        }
    }
}
