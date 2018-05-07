using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class ClickOn : MonoBehaviour {

	Player scriptPlayer;
	Child scriptChild;


	[SerializeField]
	private Material selectedPlayer;
	private MeshRenderer myRend;
	public bool currentlySelected = false;


	private NavMeshAgent nmAgent;
	public LayerMask ground;
	private GameObject human;
	public Vector3 theDestination;
	private Rigidbody playerRB;


	public GameObject peopleAliveParentGameObject;


	void Awake(){
		nmAgent = GetComponent<NavMeshAgent> ();
		human = GetComponent<GameObject> ();
		playerRB = GetComponent<Rigidbody> ();

		scriptPlayer = this.gameObject.GetComponent<Player> ();
		scriptChild = this.gameObject.GetComponent<Child> ();
	}
	// Use this for initialization
	void Start () {
		myRend = GetComponent<MeshRenderer> ();
		Camera.main.gameObject.GetComponent<Click>().selectableObjects.Add (this.gameObject);
		//ClickMe ();
	}

	void Update(){
		StartCoroutine ("ClickMove");
		if (currentlySelected == false && nmAgent.remainingDistance < 1) {
			nmAgent.speed = 0;
			playerRB.constraints = RigidbodyConstraints.FreezeAll;
		}
	}

	public void ClickMe(){
		if (currentlySelected == false) {
			if (this.gameObject.GetComponent ("Player") != null) {
				if (this.scriptPlayer.job == "Drone" || this.gameObject.tag == "Character1" || this.gameObject.tag == "Character4") {
					if (this.scriptPlayer.isMale == true) {
						myRend.material = this.scriptPlayer.Character1;
						this.gameObject.tag = "Character1";
						this.scriptPlayer.job = "Drone";
					} else {
						myRend.material = this.scriptPlayer.Character4;
						this.gameObject.tag = "Character4";
						this.scriptPlayer.job = "Drone";
					}
				} else if (this.scriptPlayer.job == "Flash" || this.gameObject.tag == "Character2" || this.gameObject.tag == "Character5") {
					if (this.scriptPlayer.isMale == true) {
						myRend.material = this.scriptPlayer.Character2;
						this.gameObject.tag = "Character2";
						this.scriptPlayer.job = "Flash";
					} else {
						myRend.material = this.scriptPlayer.Character5;
						this.gameObject.tag = "Character5";
						this.scriptPlayer.job = "Flash";
					}
				} else if (this.scriptPlayer.job == "Warrior" || this.gameObject.tag == "Character3" || this.gameObject.tag == "Character6") {
					if (this.scriptPlayer.isMale == true) {
						myRend.material = this.scriptPlayer.Character3;
						this.gameObject.tag = "Character3";
						this.scriptPlayer.job = "Warrior";
					} else {
						myRend.material = this.scriptPlayer.Character6;
						this.gameObject.tag = "Character6";
						this.scriptPlayer.job = "Warrior";
					}
				}
			} else {
				if (this.scriptChild.job == "Drone" || this.gameObject.tag == "Character1" || this.gameObject.tag == "Character4") {
					if (this.scriptChild.isMale == true) {
						myRend.material = this.scriptChild.Character1;
						this.gameObject.tag = "Character1";
						this.scriptChild.job = "Drone";
					} else {
						myRend.material = this.scriptChild.Character4;
						this.gameObject.tag = "Character4";
						this.scriptChild.job = "Drone";
					}
				} else if (this.scriptChild.job == "Flash" || this.gameObject.tag == "Character2" || this.gameObject.tag == "Character5") {
					if (this.scriptChild.isMale == true) {
						myRend.material = this.scriptChild.Character2;
						this.gameObject.tag = "Character2";
						this.scriptChild.job = "Flash";
					} else {
						myRend.material = this.scriptChild.Character5;
						this.gameObject.tag = "Character5";
						this.scriptChild.job = "Flash";
					}
				} else if (this.scriptChild.job == "Warrior" || this.gameObject.tag == "Character3" || this.gameObject.tag == "Character6") {
					if (this.scriptChild.isMale == true) {
						myRend.material = this.scriptChild.Character3;
						this.gameObject.tag = "Character3";
						this.scriptChild.job = "Warrior";
					} else {
						myRend.material = this.scriptChild.Character6;
						this.gameObject.tag = "Character6";
						this.scriptChild.job = "Warrior";
					}
				}
			}
		}
		else {
			myRend.material = selectedPlayer;
		}
	}
	void OnCollisionStay(Collision col){
		if ((col.gameObject.tag == "Character1" || col.gameObject.tag == "Character2" || col.gameObject.tag == "Character3" || col.gameObject.tag == "Character4" || col.gameObject.tag == "Character5" || col.gameObject.tag == "Character6") && (Vector3.Distance(nmAgent.transform.position,theDestination) < 5)) {
			if (nmAgent.gameObject.activeInHierarchy) {
				//nmAgent.destination = nmAgent.transform.position;
				nmAgent.speed = 0;
				playerRB.constraints = RigidbodyConstraints.FreezeAll;
				//Debug.Log (nmAgent.remainingDistance);
				//Debug.Log (gameObject.name + "has collided with" + col.gameObject.name);
			}
		}
	}

	IEnumerator ClickMove(){
		if (currentlySelected == true) {
			if (this.gameObject.GetComponent ("Player") != null) {
				nmAgent.speed = scriptPlayer.speed;
			} else {
				nmAgent.speed = scriptChild.speed;
			}
			Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);

			RaycastHit hit;

			if (Input.GetMouseButtonDown (1)) {
				if (Physics.Raycast (ray, out hit, Mathf.Infinity, ground)) {
					theDestination = hit.point;
					nmAgent.SetDestination (theDestination);
					//Debug.Log (nmAgent.remainingDistance);
				}
			}
		}
		yield return null;
	}
}
