using UnityEngine;
using System.Collections;

public class Looting : MonoBehaviour {

	private int invCount = 0;

	ItemClass itemObject = new ItemClass ();


	public void addInv(string nam, int amount){
		//Debug.Log(itemName);
		Debug.Log ("item: " + nam + " | amount: " + amount);
		inventoryGUI.inventoryNameDictionary [0] = nam;
		inventoryGUI.dictionaryAmounts [0] += amount;

			
	}
		
}
