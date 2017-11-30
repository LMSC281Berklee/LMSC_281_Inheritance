//LMSC-281 Logic and Programming
//Cartesian Coordinates Exercise
//Spring 2017 Jeanine Cowen

//This Class offsets an object (to be used as a label) from any target object

//GUIText worldview code from Kelly Thomas http://gamedev.stackexchange.com/questions/84174/position-gui-text-in-2d-game

using UnityEngine;			//include library
using System.Collections;	//include library

public class Transform_WorldPosition : MonoBehaviour {	//inherit from the Monobehaviour Class


	public Vector3 WorldOffset = Vector3.up + Vector3.right;	//offset from the object in the WorldView
	public Vector3 ScreenOffset = Vector3.zero;					//this confirms the current screensize position
	public Transform target;									//this allows for any target within the inspector

	void Start () {
		target = this.transform;
	}


	//the last update to run
	//this Method creates an offset from the target object in order to display additional information
	//in this project it is applied to a GUIText field to display XY coordinates about the target object
	public void LateUpdate() {
		this.transform.position = Camera.main.WorldToViewportPoint(target.position + WorldOffset) + ScreenOffset;
	}
}
