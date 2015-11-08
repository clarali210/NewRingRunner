using UnityEngine;
using System.Collections;

public class Obstacles : MonoBehaviour {

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void FixedUpdate () {
	}

	void OnCollisionEnter2D(Collision2D obs){
		if (obs.gameObject.name == "Obstacles") {
			Destroy (this.gameObject);
		}
	}

}

