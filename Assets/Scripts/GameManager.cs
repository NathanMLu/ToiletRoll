using UnityEngine;

public class GameManager : MonoBehaviour {
    [SerializeField] private GameObject PlayerPrefab;
    [SerializeField] private GameObject SceneCamera;
    
    [SerializeField] private PanelController PanelController;
    [SerializeField] private WinnerText WinnerText;

    private bool running;
    
    private void Start() {
        SpawnPlayer();
        
        PanelController.PauseCanvasOn();
        PanelController.MenuCanvasOff();
        WinnerText.WinnerPanelOff();
        
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
        PanelController.MenuCanvasOn();
    }

    public void Winner(string playerName) {
        running = false;
        
        PanelController.PauseCanvasOff();
        PanelController.MenuCanvasOff();
        
        WinnerText.setWinnerName(playerName);
    }

    public void StartGame() {
        running = true;
        
        PanelController.PauseCanvasOn();
        PanelController.MenuCanvasOff();
        WinnerText.WinnerPanelOff();
    }

    public void BackToMenu() {
        running = false;
        PhotonNetwork.LeaveRoom();
        
        PanelController.PauseCanvasOff();
        PanelController.MenuCanvasOff();
        WinnerText.WinnerPanelOff();

        PhotonNetwork.LoadLevel("MainMenu");
    }
}
