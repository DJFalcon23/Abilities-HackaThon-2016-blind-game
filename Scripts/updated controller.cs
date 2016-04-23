

using UnityEngine;

using System.Collections;



public class AccelerometerInput : MonoBehaviour {

	private Rigidbody rb;


	void Start () 

	{

		rb = GetComponent<Rigidbody> ();

	}



	void Update () 

	{

		transform.Translate ((Input.acceleration.x)/2, 0, (-Input.acceleration.z)/2);

	}



	void FixedUpdate () 

	{

		float moveHorizontal = Input.GetAxis ("Horizontal");

		float moveVertical = Input.GetAxis ("Vertical");



		Vector3 movement = new Vector3 (moveHorizontal, 0.0f, moveVertical);



		rb.AddForce (movement);

	}



}

