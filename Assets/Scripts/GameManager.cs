using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {
    public GameObject PlayerPrefab;
    public GameObject SceneCamera;

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
        running = false;
    }

    public void StartGame() {
        running = true;
    }
}
