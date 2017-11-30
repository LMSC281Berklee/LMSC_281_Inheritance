//LMSC-281 Logic and Programming
//Adapted from Cartesian Coordinates Exercise
//Spring 2017 Jeanine Cowen

//This Class displays the name of the target, only when the mouse is hovered over the target

//GUIText worldview code from Kelly Thomas http://gamedev.stackexchange.com/questions/84174/position-gui-text-in-2d-game
//DisplayUI code from http://xenosmashgames.com/displaying-ui-onmouseover/

using UnityEngine;			//include library
using UnityEngine.UI;		//include library
using System.Collections;	//include library

public class GUIText_Worldview : MonoBehaviour {	//inherit from the Monobehaviour Class


	string myString;				//used to hold the combined text factors
	GUIText myText;					//the display GUIText item
	public float fadeTime;			//the amount of time for the coordinate to fade out
	bool displayInfo;				//used to control the color of the GUIText field
//	public GameObject myObject;		//This allows flexibility to determine the object whose XY coordinates are displayed
	float xPos;						//The X position of the myObject 
	float yPos;						//The Y position of the myObject
	public Color myColor = Color.red;//Sets the color of the text in the inspector

	//Start is called when the instance of this script is made active
	void Start () {
		myText = gameObject.GetComponentInChildren<GUIText>();

//		myText.color = myColor;
		myText.color = Color.clear;
		UpdateText();
		myString = this.name;
		myText.text = myString;
	}

	// Update is called once per frame
	void Update () {
		FadeText ();
	}

	//Used to fade the text color back to be visibile
	void OnMouseOver() {
		displayInfo = true;
//		UpdateText();
//		Debug.Log ("OnMouseOver method was activated");
	}

	//used to set the GUIText color back to clear via the Boolean in the FadeText method
	void OnMouseExit() {
		displayInfo = false;
//		Debug.Log ("OnMouseExit method was activated");
	}

	//Method that controls the text color and fade out
	void FadeText () {
		if(displayInfo) {
			myText.color = Color.Lerp (myText.color, myColor, fadeTime * Time.deltaTime);
		}
		else {
			myText.color = Color.Lerp (myText.color, Color.clear, fadeTime * Time.deltaTime);
		}
//		Debug.Log ("FadeText method was activated");
	}

	//This method places the X and Y position into the GUIText variable
	void UpdateText() {
		myString = this.name;
//		myString = "(" + xPos.ToString("f1") + ", " + yPos.ToString("f1") + ")"; //this limits the XY position to display only one decimal
//		Debug.Log ("UpdateText method was activated");
	}

}
