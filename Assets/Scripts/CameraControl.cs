using UnityEngine;
using System.Collections;

public class CameraControl : MonoBehaviour {
	public float m_DampTime = 0.2f;                 // Approximate time for the camera to refocus.                
	public Transform m_Targets;     
	private Vector3 m_MoveVelocity;                 // Reference velocity for the smooth damping of the position.
	private Vector3 m_DesiredPosition; 
	// Use this for initialization
	void Start () {
	
	}

	void FixedUpdate ()
	{
		Move ();
	}
	
	
	private void Move ()
	{
		// Find the average position of the targets.
		FindAveragePosition ();
		// Smoothly transition to that position.
		transform.position = Vector3.SmoothDamp(transform.position, m_DesiredPosition, ref m_MoveVelocity, m_DampTime);
	}
	
	
	private void FindAveragePosition ()
	{
		Vector3 averagePos = new Vector3 ();
		averagePos += m_Targets.position;
		averagePos.z = transform.position.z;
		// The desired position is the average position;
		m_DesiredPosition = averagePos;
		Debug.Log (m_DesiredPosition);
	}
}
