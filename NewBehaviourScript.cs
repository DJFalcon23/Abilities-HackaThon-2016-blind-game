using UnityEngine;
using System.Collections;

public class NewBehaviourScript : MonoBehaviour {

	// Update is called once per frame
	void FixedUpdate () {

		transform.Translate ((-Input.acceleration.z * Time.deltaTime)*2, 0, (- Input.acceleration.x * Time.deltaTime)*2);

	}
}