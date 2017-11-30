using UnityEngine;
using System.Collections;

public class Cat : Animal {

	Transform dogPosition;
	float distToDog;

	// Use this for initialization
	void Start () {
//		Debug.Log ("Dog constructor");
//		Greet ();
//		Talk ();
//		Sing ();
		dogPosition = GameObject.Find("Dog").transform;
	}

	public override void Talk() {
		base.Talk ();
		Debug.Log("added Cat talk");
	}

	public override void Sing() {
		Debug.Log("Cat song");
	}

	public override void Movement() {
		
		Debug.Log("Cat Movement is called");
		Debug.Log ("Cats don't listen to anyone else, it's not going to move"); 



	}
};