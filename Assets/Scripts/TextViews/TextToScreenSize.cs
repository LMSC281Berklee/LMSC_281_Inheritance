//LMSC-281 Logic and Programming
//Cartesian Coordinates Exercise
//Spring 2017 Jeanine Cowen

//This Class adjusts the size of a GUIText object based on the screen resolution

using UnityEngine;			//include library
using System.Collections;	//include library

public class TextToScreenSize : MonoBehaviour {		//inherit from the Monobehaviour Class

	public float textPercentageSize = 0.035f;

	// Use this for initialization
	void Start () {
		GetComponent<GUIText>().fontSize = (int)(Mathf.Round (textPercentageSize * Screen.width)); //this allows for different screen resolutions to display correctly
	}
	
	// Update is called once per frame
	void Update () {
	}
}
