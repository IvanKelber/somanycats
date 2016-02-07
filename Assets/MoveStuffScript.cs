using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class MoveStuffScript : MonoBehaviour {


	public int lifeCounter = 9;
	public Text text;
	public Texture catTexture;
	// Use this for initialization
	void Start () {
		text = GetComponent<Text>();
		text.text = lifeCounter.ToString ();

	}
	
	// Update is called once per frame
	void Update () 
	{
		//GUI.TextArea(new Rect(2,2,6,6), lifeCounter.ToString());

		handleMove ();
		handleScore ();
	
	}

	void handleScore() {
//		GameObject[] allObjects = GameObject.FindGameObjectsWithTag ("cat");
//		GameObject[] allObjects2 = allObjects.Clone () as GameObject[];
//		for (int i = allObjects2.Length; i >= 0; i--) {
//			if (allObjects2 [i].transform.position.z == 0) {
//				Destroy (allObjects [i]);
//				lifeCounter--;
//			}
//		}
		if (lifeCounter <= 0) {
//			Application.Quit;
		}


	}
	void shootLasers() {

	}
	void handleMove() {
		GameObject[] allObjects = GameObject.FindGameObjectsWithTag ("cat");
		int updateNum = 0;
		foreach (GameObject obj in allObjects) 
		{
			float moveAmount = 0.01f;
			Vector3 v1 = new Vector3 (transform.forward.x, 2, transform.forward.z);
			moveAmount *= Random.Range (1, 3.1f);
			if (obj.transform.position.z < .01 && obj.transform.position.z > -.01) {
				Destroy (obj);
				lifeCounter--;
				text.text = lifeCounter.ToString();
			}

			else if (obj.transform.position.z < 0) 
			{
				moveAmount *= -1;
			}
			if (v1.z * moveAmount < 0) {
				obj.transform.Translate (0, moveAmount, 0);

			} else {
					float rand = Random.Range (0, 8000);
					if (rand <= 25) {
						explodeCat (obj);
					Object.Destroy (obj, 1);
//						float timer = 0.0f;
//						timer += Time.deltaTime;
//						if (timer > .5f) {
//							Destroy (obj);
//						}
		}




			}

			if (lifeCounter <= 0) {
				Application.Quit ();
			}
		}
	}

	void explodeCat(GameObject cat) {
		Material catMat = cat.GetComponent<Renderer>().material;
		catMat.mainTexture = catTexture;
	}

//	void OnGUI() {
//		GUI.Label (new Rect (2,2, 6, 6), lifeCounter.ToString());
//
//	}
}
