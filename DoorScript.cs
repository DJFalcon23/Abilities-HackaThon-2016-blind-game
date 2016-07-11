using UnityEngine;
using System.Collections;

public class DoorScript: MonoBehaviour {

	public AudioClip doorCollision;

	void OnTriggerEnter(Collider other) {

		Vector3 pos = other.gameObject.transform.position;
		pos.x = (pos.x - 0.5f);
		other.gameObject.transform.position = pos;		

		AudioSource audio = GetComponent<AudioSource> ();
		audio.PlayOneShot(doorCollision);

		Destroy (other.attachedRigidbody);
	}	
}
