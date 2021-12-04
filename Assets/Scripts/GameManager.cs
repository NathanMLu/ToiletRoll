using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {
    public GameObject PlayerPrefab;
    public GameObject SceneCamera;
    public PanelController PanelController;

    private bool running;
    
    private void Start() {
        SpawnPlayer();
        
        PanelController.PauseCanvasOn();
        PanelController.DisplayPanelOff();
        PanelController.MenuCanvasOff();
        SceneCamera.SetActive(false);
    }
    
    private void SpawnPlayer() {
        PhotonNetwork.Instantiate(PlayerPrefab.name, new Vector3(0,0,0), Quaternion.identity, 0);
    }

    public bool IsRunning() {
        return running;
    }

    public void PauseGame() {
        running = false;
        
        PanelController.PauseCanvasOff();
        PanelController.DisplayPanelOff();
        PanelController.MenuCanvasOn();
    }

    public void StartGame() {
        running = true;
        
        PanelController.PauseCanvasOn();
        PanelController.DisplayPanelOff();
        PanelController.MenuCanvasOff();
    }

    public void BackToMenu() {
        PhotonNetwork.LeaveRoom();
        
        PanelController.PauseCanvasOff();
        PanelController.MenuCanvasOff();
        PanelController.DisplayPanelOff();
        
        PhotonNetwork.LoadLevel("MainMenu");
    }
}
