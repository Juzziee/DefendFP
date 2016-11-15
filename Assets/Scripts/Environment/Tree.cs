using UnityEngine;
using System.Collections;

public class Tree : MonoBehaviour {

	public float Health;
	public Rigidbody rb;
	public Vector3 playerPOS;
	public int despawnTime = 5;


	public Looting loot;
	ItemClass itemObject = new ItemClass ();

	// Use this for initialization
	void Start () {
		Health = 10;
		rb = GetComponent<Rigidbody> ();
		loot = GameObject.FindObjectOfType(typeof(Looting)) as Looting;

	}
	
	// Update is called once per frame
	void FixedUpdate () {
		if (Health <= 0) {
			playerPOS = GameObject.Find ("Player").transform.position;
			rb.isKinematic = false;
			rb.AddRelativeForce ((playerPOS - this.gameObject.transform.position) * 50f);
			StartCoroutine(Example());

		}

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
		loot.addInv(itemObject.logItem.name, Random.Range(1, 3));

	}

	IEnumerator Example() {
		yield return new WaitForSeconds(9);
		Destroy (this.gameObject);
	}
		
}
