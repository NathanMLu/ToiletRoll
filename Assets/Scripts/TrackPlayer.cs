using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrackPlayer : MonoBehaviour {
    
    public GameObject Player;
    public float follow_speed = 3f;
    private Vector3 distance_from_player;

    void Update(){
        distance_from_player = new Vector3(0f, 4.625f, -1.2f);
        distance_from_player = Player.transform.position + distance_from_player;
        distance_from_player = Vector3.MoveTowards(transform.position, distance_from_player, follow_speed*Time.deltaTime);
        transform.position = distance_from_player;
        
    }
}
