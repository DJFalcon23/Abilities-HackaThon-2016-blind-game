using UnityEngine;
using System.Collections;

public class CameraController2 : MonoBehaviour {


	public GameObject player1;

	private Vector3 offset;

	// Use this for initialization
	void Start () {
		offset = transform.position - player1.transform.position;
	}
	
	// Update is called once per frame
	void LateUpdate () {
		transform.position = player1.transform.position + offset;
	}
}
