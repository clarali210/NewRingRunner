using UnityEngine;
using System.Collections;

public class PlayerBehavior : MonoBehaviour {
	public Rigidbody2D rb;
	public GameObject planet;
	private float acceleration = 9.8f;
	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody2D> ();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		if (Input.GetKey (KeyCode.Space)) {
			Debug.Log (5);
			transform.Translate (Vector3.up*10*Time.deltaTime);
		}
		transform.Translate (-Vector3.right * 5 * Time.deltaTime);
		rb.AddForce((planet.transform.position - transform.position).normalized * acceleration);
	}
}
