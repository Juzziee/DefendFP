using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class inventoryGUI : MonoBehaviour {

	public static bool inventoryWindowToggle = false;
	private Rect inventoryWindow = new Rect (Screen.width / 100 * 80, 100, 400, 400);

	private Texture2D invButton;

	// Dictionary class
	static public Dictionary<int,string> inventoryNameDictionary = new Dictionary<int, string> () {
		{ 0, string.Empty },
		{ 1, string.Empty },
		{ 2, string.Empty },
		{ 3, string.Empty },
		{ 4, string.Empty },
		{ 5, string.Empty }

	};

	static public List<int> dictionaryAmounts = new List<int>() {
		0,
		0,
		0,
		0,
		0,
		0,
	};

	ItemClass itemObject = new ItemClass();


	void OnGUI() {

		inventoryWindowToggle = GUI.Toggle (new Rect (80, 50, 100, 50), inventoryWindowToggle, "Inventory");


		if (inventoryWindowToggle) {
			inventoryWindow = GUI.Window (0, inventoryWindow, InventoryWindowMethod, "Inventory");
		}

	}

	void InventoryWindowMethod(int windowID){

		// Create Inv item boxes
		GUILayout.BeginArea(new Rect(0, 50, 400, 400));

		// Row 1
		GUILayout.BeginHorizontal ();
		GUILayout.Button (inventoryNameDictionary[0], GUILayout.Height (50));
		GUILayout.Box (dictionaryAmounts [0].ToString (), GUILayout.Height (50));

		GUILayout.Button (inventoryNameDictionary[1], GUILayout.Height (50));
		GUILayout.Box (dictionaryAmounts [1].ToString (), GUILayout.Height (50));
		GUILayout.EndHorizontal();

		// Row 2
		GUILayout.BeginHorizontal ();
		GUILayout.Button (inventoryNameDictionary[2], GUILayout.Height (50));
		GUILayout.Box (dictionaryAmounts [2].ToString (), GUILayout.Height (50));


		GUILayout.Button (inventoryNameDictionary[3], GUILayout.Height (50));
		GUILayout.Box (dictionaryAmounts [3].ToString (), GUILayout.Height (50));
		GUILayout.EndHorizontal ();

		// Row 3
		GUILayout.BeginHorizontal ();
		GUILayout.Button (inventoryNameDictionary[4], GUILayout.Height (50));
		GUILayout.Box (dictionaryAmounts [4].ToString (), GUILayout.Height (50));

		GUILayout.Button (inventoryNameDictionary[5], GUILayout.Height (50));
		GUILayout.Box (dictionaryAmounts [5].ToString (), GUILayout.Height (50));
		GUILayout.EndHorizontal();

		GUILayout.EndArea ();
	}

}
