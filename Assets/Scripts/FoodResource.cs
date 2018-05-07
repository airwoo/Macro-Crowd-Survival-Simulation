using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodResource : MonoBehaviour {

	[SerializeField]
	private int foodResource = 100;


	//public Vector3 locationSR;
	//public Vector3 locationP;

	public Rigidbody playerRB;

	public GameObject peopleAliveParentGameObject;

	public GameObject matingPool;
	public Vector3 middleLoc;
	public Vector3 thisgoLoc;
	public float difference;


	// Use this for initialization
	void Start () {
		middleLoc = matingPool.transform.position;
		thisgoLoc = this.gameObject.transform.position;
		difference = Vector3.Distance (middleLoc, thisgoLoc);
		//print (difference);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerExit(Collider col){
		if (col.gameObject.tag == "Character1" || col.gameObject.tag == "Character2" || col.gameObject.tag == "Character3" || col.gameObject.tag == "Character4" || col.gameObject.tag == "Character5" || col.gameObject.tag == "Character6" || col.gameObject.tag == "Helper") {
			//Debug.Log ("food");
			playerRB = col.gameObject.GetComponent<Rigidbody> ();
			playerRB.constraints = RigidbodyConstraints.FreezeAll;
			Player scriptPlayer = col.gameObject.GetComponent<Player> ();
			if(scriptPlayer.canGather == true){
				if (scriptPlayer.isFull == false) {
					if (difference < 50) {
						scriptPlayer.currentFoodHold = (Random.Range (1, scriptPlayer.backpack)) * 2;
					}
					if (difference >= 50) {
						scriptPlayer.currentFoodHold = scriptPlayer.backpack * 2;
					}
					scriptPlayer.isFull = true;
				}
			}
		}
	}

	void OnTriggerEnter(Collider col){
		if (col.gameObject.tag == "Helper") {
			playerRB = col.gameObject.GetComponent<Rigidbody> ();
			playerRB.constraints = RigidbodyConstraints.FreezeAll;
			Player scriptPlayer = col.gameObject.GetComponent<Player> ();
			if(scriptPlayer.canGather == true){
				if (scriptPlayer.isFull == false) {
					if (difference < 50) {
						scriptPlayer.currentFoodHold = (Random.Range (1, scriptPlayer.backpack)) * 2;
					}
					if (difference >= 50) {
						scriptPlayer.currentFoodHold = scriptPlayer.backpack * 2;
					}
					scriptPlayer.isFull = true;
				}
			}
		}
	}


}
