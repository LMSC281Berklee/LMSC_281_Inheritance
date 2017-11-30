//LMSC-281 Logic and Programming
//Cartesian Coordinates Exercise
//Spring 2017 Jeanine Cowen

//This Class allows an oblect to be dragged in the game environment with a mouse input

//drag object code from http://answers.unity3d.com/questions/12322/drag-gameobject-with-mouse.html

using UnityEngine;			//include library
using System.Collections;	//include library

public class MoveWithMouse : MonoBehaviour {	//inherit from the Monobehaviour Class

	Vector3 screenPoint;
	Vector3 offset;

	void OnMouseDown()
	{
		screenPoint = Camera.main.WorldToScreenPoint(gameObject.transform.position);

		offset = gameObject.transform.position - Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z));

	}

	void OnMouseDrag()
	{
		Vector3 curScreenPoint = new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z);

		Vector3 curPosition = Camera.main.ScreenToWorldPoint(curScreenPoint)+ offset;
		transform.position = curPosition;

	}
}
