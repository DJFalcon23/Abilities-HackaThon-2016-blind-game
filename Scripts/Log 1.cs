using UnityEngine;
using System.Collections;

public class Log1 : MonoBehaviour {
	public GameObject player;
	public AudioSource Commander_audio_log;
	public float distX = 1.4f;

	// Use this for initialization
	void Awake() {
		if (Commander_audio_log == null) {
			Commander_audio_log = GameObject.Find ("Commander_audio_log").GetComponent<AudioSource> ();

		
		}

	}

    void playSound()
    {
        Commander_audio_log.Play();

    }
    // 
    /*void OnTouch() {
		float dist = Vector3.Distance (player.transform.position, transform.position);
		Debug.Log ("dist : " + dist);

		if(dist <= distX){
			playSound ();

	}
		
	

}*/
    void Update()
    {
        // Look for all fingers
        for (int i = 0; i < Input.touchCount; i++)
        {
            Touch touch = Input.GetTouch(i);

            // -- Tap: quick touch & release
            // ------------------------------------------------
            if (touch.phase == TouchPhase.Ended && touch.tapCount == 1)
            {
                // Touch are screens location. Convert to world
                Vector3 position = Camera.main.ScreenToWorldPoint(touch.position(-5,0.5,0.5));

                playSound();

                // Effect for feedback
                //SpecialEffectsScript.MakeExplosion((position));
            }

        }

        

    }