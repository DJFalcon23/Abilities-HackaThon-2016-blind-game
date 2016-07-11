using UnityEngine;
using System.Collections;

public class AudioCollision1Script : MonoBehaviour {

	public AudioClip audioCollision;

	void OnTriggerEnter(Collider other) {

		AudioSource audio = GetComponent<AudioSource> ();
		audio.PlayOneShot(audioCollision);
	}	
}
