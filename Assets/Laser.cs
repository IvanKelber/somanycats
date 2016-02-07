using UnityEngine;
using System.Collections;

public class Laser : MonoBehaviour {


	LineRenderer lr;
	// Use this for initialization
	void Start () {
		lr = GetComponent<LineRenderer> ();
		lr.enabled = true;
		lr.SetColors (Color.red, Color.blue);
		lr.SetWidth (.2f,.2f);
	}
	
	// Update is called once per frame
	void Update () {
		RaycastHit hit;

		lr.SetPosition (0, transform.position);

		if(Physics.Raycast(transform.position,transform.forward, out hit)) {
			if(hit.collider) {
				//lr.SetPosition(1,new Vector3(transform.position.x,transform.position.y,hit.distance));
				lr.SetPosition(1, hit.collider.transform.position);
			} else {
				//lr.SetPosition(1, new Vector3(transform.position.x,transform.position.y,5000));
				lr.SetPosition(1, transform.forward);
			}
		}
			
	
	}
			}

