using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManage : MonoBehaviour {
    public GameObject PlayerPrefab;
    public GameObject SceneCamera;
    private int count = 0;

    public void Start() {
        SpawnPlayer();
    }
    
    public void SpawnPlayer() {
        GameObject temp = PhotonNetwork.Instantiate(PlayerPrefab.name, new Vector3(0,0,0), Quaternion.identity, 0);
        temp.name = count.ToString();
        SceneCamera.SetActive(false);
        count++;
    }
}
