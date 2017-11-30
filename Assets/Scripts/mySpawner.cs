/*
Berklee College of Music - LMSC-281 Logic and Programming
Jeanine Cowen - Fall 2017
Example from class lecture - GameObjects
*/

using UnityEngine;
using System.Collections;

public class mySpawner : MonoBehaviour {

	//declare a new GameObject, note, this is not initialized yet, just declared as a variable with type GameObject
	public GameObject preFabInstance;

	//declare a Vector3 to hold the transform.position of the new object being instantiated
	Vector3 positionForInstantiate;

	// Use this for initialization
	public void SpawnObject () {
		//setup to create a new GameObject, using this method, we can drag the prefab to associate within the Unity inspector

			//We also include tha ability to randomly place the instantiated items in the game
			Vector3 positionForInstantiate = GetNewVector();
			//This is the more in depth Instantiate that also takes in a position and a rotation for the item
			Instantiate (preFabInstance, positionForInstantiate, Quaternion.identity);
	}

	//This function provides a randomized Vector3 to use as a position
	Vector3 GetNewVector ( ) {
		float xPos = Random.Range (-10.0f, 10.0f);
		float yPos = Random.Range (0.0f, 20.0f);
		float zPos = Random.Range (-10.0f, 10.0f);

		return new Vector3 (xPos, yPos, zPos);

	}
}
