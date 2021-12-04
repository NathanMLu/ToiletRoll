using UnityEngine;
using TMPro;

public class MovePlayer : Photon.MonoBehaviour {
    private Rigidbody myRigidbody;
    private float mySpeed;
    
    private Vector3 forward;
    private Vector3 back;
    private Vector3 right;
    private Vector3 left;
    private Vector3[] spawnPoints = new Vector3[4];
    
    public PhotonView photonView;
    public GameObject PlayerCamera;
    public TextMeshPro PlayerNameText;
    public TrackPlayer TrackPlayer;

    private GameObject GameManager;

    private void Awake() {
        myRigidbody = GetComponent<Rigidbody>();
        mySpeed = 3.5f;
        
        forward = new Vector3(0, 0, 1);
        back = new Vector3(0, 0, -1);
        right = new Vector3(1, 0, 0);
        left = new Vector3(-1, 0, 0);
        
        spawnPoints[0] = new Vector3(11f, 0.25f, -11f);
        spawnPoints[1] = new Vector3(11f, 0.25f, 11f);
        spawnPoints[2] = new Vector3(-11f, 0.25f, -11f);
        spawnPoints[3] = new Vector3(-11f, 0.25f, 11f);
        
        transform.position = spawnPoints[Random.Range(0, 3)];
        
        GameManager = GameObject.FindGameObjectWithTag("GameController");
        Debug.Log(GameManager);
        
        if (photonView.isMine) {
            // The most important line :)
            PlayerCamera.SetActive(true);
            
			PlayerNameText.text = PhotonNetwork.playerName;
        } else {
			PlayerNameText.text = photonView.owner.NickName;
			PlayerNameText.color = Color.cyan;
		}

        GameManager.GetComponent<GameManager>().StartGame();
    }

    public void Update() {
        if (photonView.isMine && GameManager.GetComponent<GameManager>().IsRunning() && TrackPlayer.reachedStartingPosition()) {
            if ((Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.W)) && transform.position.y < 1.1f) {
                myRigidbody.velocity = forward * mySpeed;
            }
            else if ((Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.S)) && transform.position.y < 1.1f) {
                myRigidbody.velocity = back * mySpeed;
            }
            else if ((Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D)) && transform.position.y < 1.1f) {
                myRigidbody.velocity = right * mySpeed;
            }
            else if ((Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A)) && transform.position.y < 1.1f) {
                myRigidbody.velocity = left * mySpeed;
            }
        }
    }
}
