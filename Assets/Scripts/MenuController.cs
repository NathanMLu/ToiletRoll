using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuController : MonoBehaviour {
    [SerializeField] private string VersionName = "0.1";
    [SerializeField] private GameObject UsernameMenu;
    [SerializeField] private GameObject ConnectPanel;
    
    [SerializeField] private TMP_InputField UsernameInput;
    [SerializeField] private TMP_InputField CreateGameInput;
    [SerializeField] private TMP_InputField JoinGameInput;

    public void Awake() {
        PhotonNetwork.ConnectUsingSettings(VersionName);
    }

    private void Start() {
        UsernameMenu.SetActive(true);
    }

    private void OnConnectedToMaster() {
        PhotonNetwork.JoinLobby(TypedLobby.Default);
        Debug.Log("Connected!");
    }
}
