using UnityEngine;
using System.Collections;

public class SpawnCat : MonoBehaviour {

	public GameObject cat;
	public float timer = 0.0f;
	public Vector3 spawn_position;

	void spawnCat(){
		spawn_position = new Vector3 (Random.Range (-2, 2), 1, Random.Range (-10, 10));
		Instantiate (cat, spawn_position, Quaternion.identity);
	}
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		timer += Time.deltaTime;
		if (timer > 5) {
			spawnCat();
			timer = 0;
		}
	}
}
