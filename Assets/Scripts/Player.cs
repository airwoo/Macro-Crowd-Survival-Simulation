using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour {

	public GameObject player;

	public bool isMale;
	public string job;
	public int backpack;
	public int speed;
	public int strength;
	public int health;


	public Material Character1;

	public Material Character2;

	public Material Character3;

	public Material Character4;

	public Material Character5;

	public Material Character6;

	public Material Helper;

	public Material selectedPlayer;
	public MeshRenderer myRend;
	public bool currentlySelected = false;

	public bool canGather;
	public bool canFight;
	public bool canMate;
	public bool isFull;
	public bool hasCollided;

	public int currentFoodHold;
	public int currentMineralHold;

	public GameObject peopleAliveParentGameObject;
	public GameObject childrenParentGameObject;
	public Click scriptClick;

	public GameObject childPlayerGameObject;

	public GameObject foodResourceGameObject;
	public GameObject mineralResourceGameObject;


	// Use this for initialization
	void Awake ()
	{
		player = GetComponent<GameObject> ();
		myRend = GetComponent<MeshRenderer> ();
		health = 50;
		hasCollided = false;
		//print (this.gameObject.transform.parent);
		if (this.gameObject.transform.parent == peopleAliveParentGameObject.transform) {
			if (this.gameObject.tag == "Character1") {
				isMale = true;
				myRend.material = Character1;
				this.gameObject.tag = "Character1";
				job = "Drone";
				backpack = Random.Range (7, 10);
				speed = Random.Range (1, 4);
				strength = 0;
				canGather = true;
				canFight = false;
				canMate = true;
				isFull = false;
			} 
			if (this.gameObject.tag == "Character2") {
				isMale = true;
				myRend.material = Character2;
				this.gameObject.tag = "Character2";
				job = "Flash";
				backpack = Random.Range (1, 4);
				speed = Random.Range (7, 10);
				strength = 0;
				canGather = true;
				canFight = false;
				canMate = true;
				isFull = false;
			} 
			if (this.gameObject.tag == "Character3") {
				isMale = true;
				myRend.material = Character3;
				this.gameObject.tag = "Character3";
				job = "Warrior";
				backpack = 0;
				speed = Random.Range (1, 4);
				strength = Random.Range (7, 10);
				canGather = false;
				canFight = true;
				canMate = true;
				isFull = false;
			} 
			if (this.gameObject.tag == "Character4") {
				isMale = false;
				myRend.material = Character4;
				this.gameObject.tag = "Character4";
				job = "Drone";
				backpack = Random.Range (7, 10);
				speed = Random.Range (1, 4);
				strength = 0;
				canGather = true;
				canFight = false;
				canMate = true;
				isFull = false;
			} 
			if (this.gameObject.tag == "Character5") {
				isMale = false;
				myRend.material = Character5;
				this.gameObject.tag = "Character5";
				job = "Flash";
				backpack = Random.Range (1, 4);
				speed = Random.Range (7, 10);
				strength = 0;
				canGather = true;
				canFight = false;
				canMate = true;
				isFull = false;
			} 
			if (this.gameObject.tag == "Character6") {
				isMale = false;
				myRend.material = Character6;
				this.gameObject.tag = "Character6";
				job = "Warrior";
				backpack = 0;
				speed = Random.Range (1, 4);
				strength = Random.Range (7, 10);
				canGather = false;
				canFight = true;
				canMate = true;
				isFull = false;
				//	} 
			}
			/*if (this.gameObject.transform.parent == childrenParentGameObject) {
				
				isMale = scriptClick.childPlayer.GetComponent<Player> ().isMale;
				backpack = scriptClick.childPlayer.GetComponent<Player> ().backpack;
				speed = scriptClick.childPlayer.GetComponent<Player> ().speed;
				strength = scriptClick.childPlayer.GetComponent<Player> ().strength;
				health = scriptClick.childPlayer.GetComponent<Player> ().health;
				canFight = scriptClick.childPlayer.GetComponent<Player> ().canFight;
				canGather = scriptClick.childPlayer.GetComponent<Player> ().canGather;
				canMate = scriptClick.childPlayer.GetComponent<Player> ().canMate;
				job = scriptClick.childPlayer.GetComponent<Player> ().job;
				myRend.material = scriptClick.childPlayer.GetComponent<Player> ().myRend.material;
			}*/
			if (this.gameObject.tag == "Helper") {
				isMale = false;
				myRend.material = Helper;
				this.gameObject.tag = "Helper";
				job = "Helper";
				backpack = 9;
				speed = 9;
				strength = 0;
				canGather = true;
				canFight = false;
				canMate = false;
				isFull = false;
				//	} 
			}
		}

	}
	
	// Update is called once per frame
	void Update () {
		if (this.gameObject.GetComponent<Player> ().health <= 0) {
			Destroy (this.gameObject);
		}
	}
	IEnumerator OnTriggerStay(Collider col){
		if (col.gameObject.tag == "Character1" || col.gameObject.tag == "Character2" || col.gameObject.tag == "Character3" || col.gameObject.tag == "Character4" || col.gameObject.tag == "Character5" || col.gameObject.tag == "Character6") {
			if (canGather == true) {
				GameObject[] resource = GameObject.FindGameObjectsWithTag ("Resource");
				if (isFull == true) {
					foreach (GameObject r in resource) {
						Vector3 resourceLoc = r.transform.position;
						Vector3 thisgoLoc = this.gameObject.transform.position;
						float difference = Vector3.Distance (resourceLoc, thisgoLoc);
						//print (Vector3.Distance (resourceLoc, thisgoLoc));
						//print (Vector3.Distance (thisgoLoc,resourceLoc ));
						if (difference <= 10) {
							if (Random.value >= 0.50f){
							col.gameObject.GetComponent<Player> ().canGather = true;
							
							}
						}
					}
				}
			}
		}

		if (col.gameObject.tag == "Enemy1" || col.gameObject.tag == "Enemy2") {
			if (this.gameObject.tag != "Helper") {
				//print ("AHHH");
				if (hasCollided == false) {
					this.gameObject.GetComponent<Player> ().health -= col.gameObject.GetComponent<Enemy> ().strength;
					hasCollided = true;
					yield return new WaitForSeconds (1);
					hasCollided = false;
				}
			}
		}
	}

	void OnMouseEnter(){
		
	}
	void OnMouseExit(){
	}
}
