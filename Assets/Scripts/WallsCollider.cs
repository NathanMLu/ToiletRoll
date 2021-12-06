using System;
using UnityEngine;
using Random = UnityEngine.Random;

public class WallsCollider : MonoBehaviour {
	[SerializeField] private LavaWalls lavaWalls;
	private Vector3[] spawnPoints = new Vector3[4];

	private void Start() {
		spawnPoints[0] = new Vector3(11f, 0.25f, -11f);
		spawnPoints[1] = new Vector3(11f, 0.25f, 11f);
		spawnPoints[2] = new Vector3(-11f, 0.25f, -11f);
		spawnPoints[3] = new Vector3(-11f, 0.25f, 11f);
	}

	private void OnCollisionEnter(Collision collision) {
		if (collision.gameObject.name == "ToiletPaper" && lavaWalls.isLavafied()) {
			collision.gameObject.transform.position = spawnPoints[Random.Range(0, 3)];
		}
	}
}
