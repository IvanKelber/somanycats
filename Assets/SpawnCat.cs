using UnityEngine;
using System.Collections;

public class SpawnCat : MonoBehaviour {

	public GameObject[] cats = new GameObject[3];
	public float timer = 0.0f;
	public Vector3 spawn_position;

	void spawnCat(){
		spawn_position = new Vector3 (Random.Range (-2, 2), 1, Random.Range (-10, 10));
		GameObject tmpcat = Instantiate (cats[Random.Range(0,3)], spawn_position, transform.rotation*Quaternion.Euler(180,180,0)) as GameObject;
		//tmpcat.transform.Rotate (90, 0, 0);
		tmpcat.tag = "cat";
		//tmpcat.AddComponent<MovementScript>();
	}
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		timer += Time.deltaTime;
		if (timer > 1) {
			spawnCat();
			timer = 0;

		}
	}
}
