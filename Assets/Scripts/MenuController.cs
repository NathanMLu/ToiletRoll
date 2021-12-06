using UnityEngine;
using TMPro;

public class  MenuController : MonoBehaviour {
    [SerializeField] private string VersionName = "0.1";
    [SerializeField] private GameObject UsernameMenu;
    [SerializeField] private GameObject ConnectPanel;
    
    [SerializeField] private TMP_InputField UsernameInput;
    [SerializeField] private TMP_InputField CreateGameInput;
    [SerializeField] private TMP_InputField JoinGameInput;
    
    [SerializeField] private GameObject StartButton;

    public void Awake() {
        PhotonNetwork.ConnectUsingSettings(VersionName);
    }

    private void Start() {
        UsernameMenu.SetActive(true);
    }

    public void OnConnectedToMaster() {
        Debug.Log("Connected to Photon!");
        PhotonNetwork.JoinLobby(TypedLobby.Default);
    }

    public void ChangeUsernameInput() {
        if (UsernameInput.text.Length is >= 3 and <= 12) {
            StartButton.SetActive(true);
        } else {
            StartButton.SetActive(false);
        }
    }

    public void SetUserName() {
        UsernameMenu.SetActive(false);
        PhotonNetwork.playerName = UsernameInput.text;
    }
    
    public void CreateGame() {
        PhotonNetwork.CreateRoom(CreateGameInput.text, new RoomOptions() { MaxPlayers = 19 }, null);
    }

    public void JoinGame() {
        RoomOptions roomOptions = new RoomOptions();
        roomOptions.MaxPlayers = 5;
        PhotonNetwork.JoinOrCreateRoom(JoinGameInput.text, roomOptions, TypedLobby.Default);
    }

    private void OnJoinedRoom() {
        PhotonNetwork.LoadLevel("MainGame");
    }
}
