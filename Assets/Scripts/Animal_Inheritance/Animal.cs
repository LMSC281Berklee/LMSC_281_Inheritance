using UnityEngine;
using System.Collections;

public class Animal : MonoBehaviour {

	public int rotX = 15;
	public int rotY = 15;
	public int rotZ = 15;

	public bool mvt = false;

	// Use this for initialization
	void Start () {
//		Debug.Log ("Animal base class");
//		Greet();
//		Talk ();
//		Sing ();
	}

	void OnMouseDown () {
		Greet();
		mvt = !mvt;
		Sing();
		Talk();
	}

	void Update () {
		if (mvt) {
			Movement();
		}
	}

	public void Greet() {
			Debug.Log("Animal greets! Hello!");
	}
		
	public virtual void Talk() {
			Debug.Log("Animal talk");
	}
		
	public virtual void Sing() {
			Debug.Log("Animal song");
	}

	public virtual void Movement() {
		Debug.Log("Animal Movement is called");
		transform.Rotate(new Vector3(rotX,rotY,rotZ));
	}
}
