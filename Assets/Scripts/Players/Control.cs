using UnityEngine;
using System.Collections;

public class Control : MonoBehaviour {

	CursorLockMode cursorMode;

	bool isSwing;
	bool canSwing; 


	void SetCursorState() {
		Cursor.lockState = cursorMode;
	}


	// Use this for initialization
	void Start () {
		cursorMode = CursorLockMode.Locked;
		Cursor.visible = false;
		isSwing = false;
		canSwing = true;
	}

	// Update is called once per frame
	void FixedUpdate () {

		if (Input.GetMouseButton (0)) {
			if (canSwing) {
				canSwing = false;
				isSwing = true;

				RaycastHit hit;
				if (Physics.Raycast (transform.position, transform.forward, out hit, 1.5f, -1)) {
					hit.collider.gameObject.SendMessage ("Damage", 2.0);
				}

				StartCoroutine (Swing ());


			}
		}
			

		// Inventory toggle.
		if (Input.GetButtonDown ("Inventory")) {
			// Hide inventory
			if (inventoryGUI.inventoryWindowToggle == true) {
				Debug.Log ("Window is true, disabling inv");
				inventoryGUI.inventoryWindowToggle = false;
				cursorMode = CursorLockMode.Locked;
				Cursor.visible = false;
				SetCursorState ();

			} else {
				// Show Inventory
				Debug.Log ("Window is false, toggling inv");
				inventoryGUI.inventoryWindowToggle = true;
				Cursor.visible = true;
				cursorMode = CursorLockMode.None;
				SetCursorState ();
				//Cursor.visible = false
			}
		}
	}

	IEnumerator Swing(){
		yield return new WaitForSeconds (1);
		isSwing = false;
		canSwing = true;
	}

}
