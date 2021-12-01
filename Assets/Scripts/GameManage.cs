using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManage : MonoBehaviour {
    public GameObject PlayerPrefab;
    public GameObject SceneCamera;

    public void Start() {
        SpawnPlayer();
    }
    
    public void SpawnPlayer() {
        Debug.Log("Trying to spawn player");

        PhotonNetwork.Instantiate(PlayerPrefab.name, new Vector3(0,0,0), Quaternion.identity, 0);
        
        SceneCamera.SetActive(false);
        
    }
}
