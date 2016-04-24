using UnityEngine;
using System.Collections;

public class Audio2 : MonoBehaviour {
	public GameObject player;
	public AudioSource AssistantSound;
	public float distX = 1.4f;

	void Awake(){
		if (AssistantSound == null) {
			AssistantSound = GameObject.Find ("Audio Trigger").GetComponent<AudioSource> ();
		
		}				
					}
	void OnMouseDown(){
		float dist = Vector3.Distance (player.transform.position, transform.position);
		Debug.Log ("dist : " + dist);

		if (dist <= distX) {

		}
	}
}