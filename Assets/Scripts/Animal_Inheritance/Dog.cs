using UnityEngine;
using System.Collections;

public class Dog : Animal {

	Transform targetCat;

	// Use this for initialization
	void Start () {
//		Debug.Log ("Dog constructor");
//		Greet ();
//		Talk ();
//		Sing ();

		targetCat = GameObject.Find("Cat").transform;
	}

	public override void Talk() {
		base.Talk ();
		Debug.Log("added Dog talk");
	}

	public override void Sing() {
		Debug.Log("Dog song");
	}

	public override void Movement() {
		Debug.Log("Dog Movement is called... it moves toward the cat!");
		transform.position = Vector3.Lerp(transform.position, targetCat.position, Time.deltaTime);
	}
};