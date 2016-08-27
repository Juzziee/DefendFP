using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ActionBar : MonoBehaviour {

	public Texture2D actionBar;
	public Rect barPosition;

	// Dictionary class
	private Dictionary<int,string> barDictionary = new Dictionary<int, string> () {
		{ 0, string.Empty },
		{ 1, string.Empty },
		{ 2, string.Empty },
		{ 3, string.Empty },
		{ 4, string.Empty },
		{ 5, string.Empty },
		{ 6, string.Empty },
		{ 7, string.Empty },
		{ 8, string.Empty },
		{ 9, string.Empty }
	};



	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnGUI(){
		drawActionBar ();
	}

	void drawActionBar(){
		GUI.DrawTexture (new Rect(Screen.width * barPosition.x, Screen.height * barPosition.y, Screen.width * barPosition.width, Screen.height * barPosition.height), actionBar);
	}
}
