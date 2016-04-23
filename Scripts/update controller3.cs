using UnityEngine;
using System.Collections;

public class ExampleClass : MonoBehaviour {
	public float speed = 10.0F;
	void Update() {
		Vector3 dir = Vector3.zero;
		dir.x = -Input.acceleration.y;
		dir.z = Input.acceleration.x;
		if (dir.sqrMagnitude > 1)
			dir.Normalize();

		dir *= Time.deltaTime;
		transform.Translate(dir * speed);
	}
}