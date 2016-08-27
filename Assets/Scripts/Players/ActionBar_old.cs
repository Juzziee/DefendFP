using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ActionBar_old : MonoBehaviour {

	private Rect actionBar = new Rect (Screen.width / 100 * 25, Screen.height / 100 * 95, Screen.width / 100 * 30, 100);

	// Dictionary class
	static public Dictionary<int,string> ActionBarDictionary = new Dictionary<int, string> () {
		{ 0, string.Empty },
		{ 1, string.Empty },
		{ 2, string.Empty },
		{ 3, string.Empty },
		{ 4, string.Empty },
		{ 5, string.Empty }

	};


	// Use this for initialization
	void OnGUI () {
		actionBar = GUI.Window (0, actionBar, ActionBarMethod, "Action Bar");
	}

	void ActionBarMethod(int windowID){

		// Create Inv item boxes
		GUILayout.BeginArea(new Rect(0, 50, 400, 400));

		// Row 1
		GUILayout.BeginHorizontal ();

		GUILayout.Button (ActionBarDictionary[0], GUILayout.Height (50));


		GUILayout.Button (ActionBarDictionary[1], GUILayout.Height (50));


		GUILayout.Button (ActionBarDictionary[2], GUILayout.Height (50));


		GUILayout.Button (ActionBarDictionary[3], GUILayout.Height (50));


		GUILayout.Button (ActionBarDictionary[4], GUILayout.Height (50));


		GUILayout.Button (ActionBarDictionary[5], GUILayout.Height (50));

		GUILayout.EndHorizontal();

		GUILayout.EndArea ();
	}
}
