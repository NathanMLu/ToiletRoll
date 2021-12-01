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
        float random_location = Random.Range(-1f, 1f);
        
        PhotonNetwork.Instantiate(PlayerPrefab.name, new Vector3(
                transform.position.x * random_location,
                transform.position.y,
                transform.position.z * random_location),
            Quaternion.identity, 0);
        
        SceneCamera.SetActive(false);
    }
}
