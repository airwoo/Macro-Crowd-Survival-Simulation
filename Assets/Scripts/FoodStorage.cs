using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodStorage : MonoBehaviour {


	public GameManager theGameManager;

	//public Vector3 locationSR;
	//public Vector3 locationP;

	public Rigidbody playerRB;

	public GameObject peopleAliveParentGameObject;



	// Use this for initialization
	void Awake () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter(Collider col){
		if (col.gameObject.tag == "Character1" || col.gameObject.tag == "Character2" || col.gameObject.tag == "Character3" || col.gameObject.tag == "Character4" || col.gameObject.tag == "Character5" || col.gameObject.tag == "Character6" || col.gameObject.tag == "Helper") {
			playerRB = col.gameObject.GetComponent<Rigidbody> ();
			playerRB.constraints = RigidbodyConstraints.FreezeAll;
			Player scriptPlayer = col.gameObject.GetComponent<Player> ();
			if (col.gameObject.tag == "Character1" || col.gameObject.tag == "Character2" || col.gameObject.tag == "Character3" || col.gameObject.tag == "Character4" || col.gameObject.tag == "Character5" || col.gameObject.tag == "Character6") {
				theGameManager.foodPlus += col.gameObject.GetComponent<Player> ().currentFoodHold;
			}
			theGameManager.foodStorage += scriptPlayer.currentFoodHold;
			scriptPlayer.currentFoodHold = 0;
			if (scriptPlayer.isFull == true) {
				scriptPlayer.isFull = false;
			}

			if (col.gameObject.tag == "Helper") {
				col.gameObject.GetComponent<Helper> ().currentlyInAct = false;
			}
		}

	}

	void OnCollisionExit(){

	}


}
