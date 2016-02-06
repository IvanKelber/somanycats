using UnityEngine;
using System.Collections;

public class MovementScript : MonoBehaviour {
	bool shouldMove = false;

	// Use this for initialization
	void Start () {
	}

	// Update is called once per frame
	void Update () 
	{
		if (shouldMove) {
			Vector3 towardYouVec = new Vector3 (0, 0.1f, 0);
			transform.Translate (0, 0.1f, 0);
		}
	}


	void OnBecameVisible() {
		shouldMove = false;
	}

	void OnBecameInvsible() {
		shouldMove = true;
	}

}