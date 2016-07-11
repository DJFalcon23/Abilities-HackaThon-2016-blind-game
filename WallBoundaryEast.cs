using UnityEngine;
using System.Collections;

public class WallBoundaryEast : MonoBehaviour {

	public AudioClip wallCollision;

	void OnTriggerEnter(Collider other) {

		Vector3 pos = other.gameObject.transform.position;
		pos.z = (pos.z + 0.5f);
		other.gameObject.transform.position = pos;

		AudioSource audio = GetComponent<AudioSource> ();
		audio.PlayOneShot(wallCollision);
	}	

}
