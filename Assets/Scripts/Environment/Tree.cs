using UnityEngine;
using System.Collections;

public class Tree : MonoBehaviour {

	public float Health;
	public Rigidbody rb;

	// Use this for initialization
	void Start () {
		Health = 10;
		rb = GetComponent<Rigidbody> ();
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

	void Damage(float damage){
		Health -= damage;
	}
		
}
