using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {
    public GameObject PlayerPrefab;
    public GameObject SceneCamera;
    public GameObject PauseCanvas;

    private bool running = false;

    private void Start() {
        SpawnPlayer();
    }
    
    private void SpawnPlayer() {
        PhotonNetwork.Instantiate(PlayerPrefab.name, new Vector3(0,0,0), Quaternion.identity, 0);
        SceneCamera.SetActive(false);
    }

    public bool IsRunning() {
        return running;
    }

    public void PauseGame() {
        PauseCanvas.SetActive(true);
        running = false;
    }

    public void StartGame() {
        running = true;
        PauseCanvas.SetActive(false);
    }

    public void ShowMenu() {
        PauseCanvas.SetActive(true);
    }
        
    public void BackToMenu() {
        PhotonNetwork.LeaveRoom();
        PauseCanvas.SetActive(false);
        PhotonNetwork.LoadLevel("MainMenu");
    }
}
