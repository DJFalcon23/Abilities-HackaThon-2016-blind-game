using UnityEngine;
using System.Collections;

public class openDoor2 : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update() {
        if (Input.touchCount > 1) {
            //deletes door
            Destroy (gameObject);
        }
    }
}
