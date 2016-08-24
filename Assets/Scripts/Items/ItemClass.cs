using UnityEngine;
using System.Collections;

public class ItemClass : MonoBehaviour {

	// Icons
	static public Texture2D swordIcon;
	static public Texture2D axeIcon;
	static public Texture2D logIcon;

	// Items
	public ItemCreatorClass swordItem = new ItemCreatorClass (0, "Sword", swordIcon, "This is a sword");
	public ItemCreatorClass axeItem = new ItemCreatorClass (1, "Simple Axe", axeIcon, "A simple axe for cutting trees");
	public ItemCreatorClass logItem = new ItemCreatorClass (2, "Wooden Log", logIcon, "The remains of a slain tree");



	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public class ItemCreatorClass {
		public int id;
		public string name;
		public Texture2D icon;
		public string description;

		public ItemCreatorClass(int ide, string nam, Texture2D ico, string desc){
			id = ide;
			name = nam;
			icon = ico;
			description = desc;
		}

	}
}
