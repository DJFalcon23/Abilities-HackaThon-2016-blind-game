using UnityEngine;
using System.Collections;

public class NewBehaviourScript3 : MonoBehaviour {

	// Update is called once per frame
	void FixedUpdate () {

		transform.Translate ((-Input.acceleration.x * Time.deltaTime)*2, 0, (- Input.acceleration.z * Time.deltaTime)*2);

		Vector3 pos = transform.position;
		if (pos.y != 0.9) {
			pos.y = 0.9f;
			transform.position = pos;
		}
}
}