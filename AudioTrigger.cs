using UnityEngine;
using System.Collections;

public class AudioTrigger : MonoBehaviour {
	//public GameObject player;
	public AudioSource source;
	public AudioClip clip;
	private bool isPlayed;

	void awake() {
		//if (AssistantSound == null) {
			//AssistantSound = GameObject.Find("AudioTrigger").GetComponent<AudioSource> ();

		source = GetComponent<AudioSource> ();
		isPlayed = false;

	}

	//void playSound () {
		//AssistantSound.Play ();

public void onTriggerEnter(Collider other) {
		if (!isPlayed) {
			source.Play ();
			isPlayed = true;
		}

	}

	public void onTriggerExit(Collider other) {
		if (source.isPlaying) {
			source.Stop ();
		}
	}
		

}				
