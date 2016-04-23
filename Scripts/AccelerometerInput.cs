using UnityEngine;
using System.Collections;

public class AccelerometerInput : MonoBehaviour {



	void Update () 
	{
		transform.Translate ((Input.acceleration.x)/2, 0, (-Input.acceleration.z)/2);
	}
}
