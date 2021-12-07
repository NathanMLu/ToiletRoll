using UnityEngine;
using TMPro;

public class  MenuController : MonoBehaviour {
    [SerializeField] private string VersionName = "0.1";
    [SerializeField] private GameObject UsernameMenu;
    [SerializeField] private GameObject ConnectPanel;
    [SerializeField] private AudioHandler AudioHandler;
    
    [SerializeField] private TMP_InputField UsernameInput;
    [SerializeField] private TMP_InputField CreateGameInput;
    [SerializeField] private TMP_InputField JoinGameInput;
    
    [SerializeField] private GameObject StartButton;

    public void Awake() {
        PhotonNetwork.automaticallySyncScene = true;
    }

    private void Start() {
        AudioHandler.PlayClick();
        UsernameMenu.SetActive(true);
        PhotonNetwork.ConnectUsingSettings(VersionName);
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
        AudioHandler.PlayClick();
        PhotonNetwork.playerName = UsernameInput.text;
    }
    
    public void CreateGame() {
        AudioHandler.PlayClick();
        PhotonNetwork.CreateRoom(CreateGameInput.text, new RoomOptions() { MaxPlayers = 19 }, null);
    }

    public void JoinGame() {
        AudioHandler.PlayClick();
        RoomOptions roomOptions = new RoomOptions();
        roomOptions.MaxPlayers = 5;
        PhotonNetwork.JoinOrCreateRoom(JoinGameInput.text, roomOptions, TypedLobby.Default);
    }

    private void OnJoinedRoom() {
        PhotonNetwork.LoadLevel("MainGame");
    }
}
