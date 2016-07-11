using UnityEngine;
using System.Collections;

public class openDoor : MonoBehaviour {

	public AudioClip doorInstructions;
	//bool isOpened = false;

	void OnTriggerEnter(Collider other) {

//		Vector3 pos = other.gameObject.transform.position;
//		pos.x = (pos.x - 0.5f);
//		other.gameObject.transform.position = pos;		

		AudioSource audio = GetComponent<AudioSource> ();
		audio.PlayOneShot(doorInstructions);
        
     
    
    }   
    
    
        
}	


    


