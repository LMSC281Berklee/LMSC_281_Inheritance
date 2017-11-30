using UnityEngine;
using System.Collections;

//Vector3.Lerp adapted from https://docs.unity3d.com/ScriptReference/Vector3.Lerp.html

public class Donkey : Animal {

	public float speed = 0.01F;
	private float startTime;
	private float journeyLength;

	void Start() {
		startTime = Time.time;
	}

	public override void Movement() {
		Debug.Log("Donkey Movement is called");

		float ranX = Random.Range(-10.0f, 10.0f);
		float ranZ = Random.Range(-10.0f, 10.0f);

		Vector3 newPos = new Vector3 (ranX, transform.position.y, ranZ);

		journeyLength = Vector3.Distance(transform.position, newPos);

		float distCovered = (Time.time - startTime) * speed;
		float fracJourney = distCovered / journeyLength;

		transform.position = Vector3.Lerp(transform.position, newPos, fracJourney);

		rotX = 10;
		rotY = 10;
		rotZ = 10;
		base.Movement();
	}
};