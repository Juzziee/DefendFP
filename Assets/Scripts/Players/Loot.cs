using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Loot : MonoBehaviour {

	CursorLockMode cursorMode;

	private bool inventoryWindowToggle = false;
	private Rect inventoryWindow = new Rect (300, 100, 400, 400);
	private int invCount = 0;


	// Dictionary class
	private Dictionary<int,string> lootDictionary = new Dictionary<int, string> () {
		{ 0, string.Empty },
		{ 1, string.Empty },
		{ 2, string.Empty },
		{ 3, string.Empty },
		{ 4, string.Empty },
		{ 5, string.Empty }

	};

	private List<int> lootDictionaryAmounts = new List<int>(){
		0,
		0,
		0,
		0,
		0,
		0,
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
		lootDictionaryAmounts [0] = 10;
	lootDictionary [1] = itemObject.logItem.name;
		lootDictionaryAmounts [1] = 10;
	lootDictionary [2] = itemObject.swordItem.name;
		lootDictionaryAmounts [2] = 2;
	lootDictionary [3] = itemObject.logItem.name;
		lootDictionaryAmounts [3] = 2;
	lootDictionary [4] = itemObject.swordItem.name;
		lootDictionaryAmounts [4] = 3;
	lootDictionary [5] = itemObject.logItem.name;
		lootDictionaryAmounts [5] = 10;
	
	}
	
	void OnGUI() {
		if (inventoryWindowToggle) {
			inventoryWindow = GUI.Window (0, inventoryWindow, InventoryWindowMethod, "Corpse - Press 'esc' to close");
		}
	}

	void InventoryWindowMethod(int windowID){

		// Create Inv item boxes
		GUILayout.BeginArea(new Rect(0, 50, 400, 400));

		// Row 1
		GUILayout.BeginHorizontal ();

		// Item 1
		if (GUILayout.Button (lootDictionary [0], GUILayout.Height (50))) {
			if(lootDictionary[0] != string.Empty && lootDictionaryAmounts[0] != 0){
				while (inventoryGUI.inventoryNameDictionary [invCount] != string.Empty) {
					if(lootDictionary[0] == inventoryGUI.inventoryNameDictionary[invCount]) {
						break;
					}
					invCount++;
				}
				inventoryGUI.inventoryNameDictionary [invCount] = lootDictionary [0];
				lootDictionaryAmounts [0] -= 1;
				inventoryGUI.dictionaryAmounts [invCount] += 1;
				invCount = 0;
			}
			if (lootDictionaryAmounts [0] == 0) {
				lootDictionary [0] = string.Empty;
			}
		}
		GUILayout.Box (lootDictionaryAmounts [0].ToString (), GUILayout.Height (50));

		// Item 2
		if (GUILayout.Button (lootDictionary [1], GUILayout.Height (50))) {
			if(lootDictionary[1] != string.Empty && lootDictionaryAmounts[1] != 0){
				while (inventoryGUI.inventoryNameDictionary [invCount] != string.Empty) {
					if(lootDictionary[1] == inventoryGUI.inventoryNameDictionary[invCount]) {
						break;
					}
					invCount++;
				}
				inventoryGUI.inventoryNameDictionary [invCount] = lootDictionary [1];
				lootDictionaryAmounts [1] -= 1;
				inventoryGUI.dictionaryAmounts [invCount] += 1;
				invCount = 0;
			}
			if (lootDictionaryAmounts [1] == 0) {
				lootDictionary [1] = string.Empty;
			}
		}
		GUILayout.Box (lootDictionaryAmounts [1].ToString (), GUILayout.Height (50));

		GUILayout.EndHorizontal ();

		GUILayout.BeginHorizontal ();
		// Item 3
		if (GUILayout.Button (lootDictionary [2], GUILayout.Height (50))) {
			if(lootDictionary [2] != string.Empty && lootDictionaryAmounts [2] != 0){
				while (inventoryGUI.inventoryNameDictionary [invCount] != string.Empty) {
					if(lootDictionary [2] == inventoryGUI.inventoryNameDictionary[invCount]) {
						break;
					}
					invCount++;
				}
				inventoryGUI.inventoryNameDictionary [invCount] = lootDictionary [2];
				lootDictionaryAmounts [2] -= 1;
				inventoryGUI.dictionaryAmounts [invCount] += 1;
				invCount = 0;
			}
			if (lootDictionaryAmounts [2] == 0) {
				lootDictionary [2] = string.Empty;
			}
		}
		GUILayout.Box (lootDictionaryAmounts [2].ToString (), GUILayout.Height (50));

		// Item 4
		if (GUILayout.Button (lootDictionary [3], GUILayout.Height (50))) {
			if(lootDictionary [3] != string.Empty && lootDictionaryAmounts [3] != 0){
				while (inventoryGUI.inventoryNameDictionary [invCount] != string.Empty) {
					if(lootDictionary [3] == inventoryGUI.inventoryNameDictionary[invCount]) {
						break;
					}
					invCount++;
				}
				inventoryGUI.inventoryNameDictionary [invCount] = lootDictionary [3];
				lootDictionaryAmounts [3] -= 1;
				inventoryGUI.dictionaryAmounts [invCount] += 1;
				invCount = 0;
			}
			if (lootDictionaryAmounts [3] == 0) {
				lootDictionary [3] = string.Empty;
			}
		}
		GUILayout.Box (lootDictionaryAmounts [3].ToString (), GUILayout.Height (50));

		GUILayout.EndHorizontal();
		GUILayout.BeginHorizontal();

		// Item 5
		if (GUILayout.Button (lootDictionary [4], GUILayout.Height (50))) {
			if(lootDictionary [4] != string.Empty && lootDictionaryAmounts [4] != 0){
				while (inventoryGUI.inventoryNameDictionary [invCount] != string.Empty) {
					if(lootDictionary [4] == inventoryGUI.inventoryNameDictionary[invCount]) {
						break;
					}
					invCount++;
				}
				inventoryGUI.inventoryNameDictionary [invCount] = lootDictionary [4];
				lootDictionaryAmounts [4] -= 1;
				inventoryGUI.dictionaryAmounts [invCount] += 1;
				invCount = 0;
			}
			if (lootDictionaryAmounts [4] == 0) {
				lootDictionary [4] = string.Empty;
			}
		}
		GUILayout.Box (lootDictionaryAmounts [4].ToString (), GUILayout.Height (50));

		// Item 6
		if (GUILayout.Button (lootDictionary [5], GUILayout.Height (50))) {
			if(lootDictionary [5] != string.Empty && lootDictionaryAmounts [5] != 0){
				while (inventoryGUI.inventoryNameDictionary [invCount] != string.Empty) {
					if(lootDictionary [5] == inventoryGUI.inventoryNameDictionary[invCount]) {
						break;
					}
					invCount++;
				}
				inventoryGUI.inventoryNameDictionary [invCount] = lootDictionary [5];
				lootDictionaryAmounts [5] -= 1;
				inventoryGUI.dictionaryAmounts [invCount] += 1;
				invCount = 0;
			}
			if (lootDictionaryAmounts [5] == 0) {
				lootDictionary [5] = string.Empty;
			}
		}
		GUILayout.Box (lootDictionaryAmounts [5].ToString (), GUILayout.Height (50));

		GUILayout.EndHorizontal();


		GUILayout.EndArea ();
	}

	void Update(){
		mouseRay = Camera.main.ScreenPointToRay (Input.mousePosition);

		if(Input.GetButtonDown("Interact")){
			Physics.Raycast(mouseRay, out rayHit);
			if(rayHit.collider.transform.tag == "Lootable"){
				inventoryWindowToggle = true;
				Cursor.visible = true;
				cursorMode = CursorLockMode.None;
				SetCursorState ();
			}
		}

		// Close loot window
		if(Input.GetButtonDown("Cancel")) {
			inventoryWindowToggle = false;
			cursorMode = CursorLockMode.Locked;
			Cursor.visible = false;
			SetCursorState ();
		}
	}
}
