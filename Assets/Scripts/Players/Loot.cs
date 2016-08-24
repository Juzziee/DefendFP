using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Loot : MonoBehaviour {

	CursorLockMode cursorMode;

	private bool inventoryWindowToggle = false;
	private Rect inventoryWindow = new Rect (300, 100, 400, 400);


	// Dictionary class
	private Dictionary<int,string> lootDictionary = new Dictionary<int, string> () {
		{ 0, string.Empty },
		{ 1, string.Empty },
		{ 2, string.Empty },
		{ 3, string.Empty },
		{ 4, string.Empty },
		{ 5, string.Empty }

	};

	ItemClass itemObject = new ItemClass();

	private Ray mouseRay;
	private RaycastHit rayHit;

	void SetCursorState() {
		Cursor.lockState = cursorMode;
	}

	// Use this for initialization
	void Start () {

	// Display Dictionary
	lootDictionary[0] = itemObject.axeItem.name;
	lootDictionary [1] = itemObject.logItem.name;
	
	}
	
	void OnGUI() {
		if (inventoryWindowToggle) {
			inventoryWindow = GUI.Window (0, inventoryWindow, InventoryWindowMethod, "Corpse - Press 'L' to close");
		}
	}

	void InventoryWindowMethod(int windowID){

		// Create Inv item boxes
		GUILayout.BeginArea(new Rect(0, 50, 400, 400));

		GUILayout.BeginHorizontal ();
		if (GUILayout.Button (lootDictionary [0], GUILayout.Height (50))) {
			if(lootDictionary[0] != string.Empty){
				inventoryGUI.inventoryNameDictionary [0] = lootDictionary [0];
				lootDictionary [0] = string.Empty;
			}
		}

		if (GUILayout.Button (lootDictionary [1], GUILayout.Height (50))) {
			if(lootDictionary[1] != string.Empty){
				inventoryGUI.inventoryNameDictionary [1] = lootDictionary [1];
				lootDictionary [1] = string.Empty;
			}
		}

		if (GUILayout.Button (lootDictionary [2], GUILayout.Height (50))) {
			if(lootDictionary[2] != string.Empty){
				inventoryGUI.inventoryNameDictionary [2] = lootDictionary [2];
				lootDictionary [2] = string.Empty;
			}
		}
		GUILayout.EndHorizontal ();
		GUILayout.BeginHorizontal ();
		if (GUILayout.Button (lootDictionary [3], GUILayout.Height (50))) {
			if(lootDictionary[3] != string.Empty){
				inventoryGUI.inventoryNameDictionary [3] = lootDictionary [3];
				lootDictionary [3] = string.Empty;
			}
		}

		if (GUILayout.Button (lootDictionary [4], GUILayout.Height (50))) {
			if(lootDictionary[4] != string.Empty){
				inventoryGUI.inventoryNameDictionary [4] = lootDictionary [4];
				lootDictionary [4] = string.Empty;
			}
		}

		if (GUILayout.Button (lootDictionary [5], GUILayout.Height (50))) {
			if(lootDictionary[5] != string.Empty){
				inventoryGUI.inventoryNameDictionary [5] = lootDictionary [5];
				lootDictionary [5] = string.Empty;
			}
		}


		GUILayout.EndHorizontal();


		GUILayout.EndArea ();
	}

	void Update(){
		mouseRay = Camera.main.ScreenPointToRay (Input.mousePosition);

		if(Input.GetButtonDown("Fire1")){
			Physics.Raycast(mouseRay, out rayHit);
			if(rayHit.collider.transform.tag == "Lootable"){
				inventoryWindowToggle = true;
				Cursor.visible = true;
				cursorMode = CursorLockMode.None;
				SetCursorState ();
			}
		}

		// Close loot window
		if(Input.GetKeyDown("l")) {
			inventoryWindowToggle = false;
			cursorMode = CursorLockMode.Locked;
			Cursor.visible = false;
			SetCursorState ();
		}
	}
}
