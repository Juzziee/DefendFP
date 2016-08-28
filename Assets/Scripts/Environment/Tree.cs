using UnityEngine;
using System.Collections;

public class Tree : MonoBehaviour {

	public float Health;
	public Rigidbody rb;

	public Looting loot;


	// Use this for initialization
	void Start () {
		Health = 10;
		rb = GetComponent<Rigidbody> ();
		loot = GameObject.Find ("Inventory Controller").GetComponent<Looting> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (Health <= 0) {
			rb.isKinematic = false;
			rb.AddRelativeForce (Vector3.forward * 75f);
			//treeDestory ();
		}
	}

	void treeDestory(){
		Destroy (this.gameObject);
	}

	void hit(){
		if (Health > 1) {
			Damage (2);
		} else {
			Debug.Log ("hes dead jim");
		}
	}

	void Damage(float damage){
		Health -= damage;
		loot.addInv ();

	}
		
}
