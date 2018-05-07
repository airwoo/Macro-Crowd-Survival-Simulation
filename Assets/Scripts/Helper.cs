using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Helper : MonoBehaviour {

	private NavMeshAgent nmAgent;
	public GameObject foodDestination;
	public GameObject returnFoodDestination;
	public GameObject mineralDestination;
	public GameObject returnMineralDestination;
	private Rigidbody playerRB;

	public GameManager theGameManager;
	public FoodStorage FS;
	public SteelStorage MS;

	public bool currentlyInAct = false;

	public 
	// Use this for initialization
	void Awake () {
		nmAgent = GetComponent<NavMeshAgent> ();

	}
	
	// Update is called once per frame
	void Update () {
		nmAgent.speed = GetComponent<Player> ().speed;
		if (theGameManager.foodStorage <= 10 && currentlyInAct == false) {
			//Debug.Log ("getting food");
			currentlyInAct = true;
			nmAgent.destination = foodDestination.transform.position;
		
		}
		if (this.gameObject.GetComponent<Player>().currentFoodHold > 0) {
			//Debug.Log ("returning food");
			nmAgent.destination = returnFoodDestination.transform.position;
		}
		if (theGameManager.mineralStorage <= 10 && currentlyInAct == false) {
			//Debug.Log ("getting mineral");
			currentlyInAct = true;
			nmAgent.destination = mineralDestination.transform.position;

		}
		if (this.gameObject.GetComponent<Player>().currentMineralHold > 0) {
			//Debug.Log ("returning mineral");
			nmAgent.destination = returnMineralDestination.transform.position;
		}
		if (theGameManager.foodPlus <= theGameManager.mineralPlus && currentlyInAct == false) {
			//Debug.Log ("getting food");
			currentlyInAct = true;
			nmAgent.destination = foodDestination.transform.position;
		}
		if (theGameManager.mineralPlus <= theGameManager.foodPlus && currentlyInAct == false) {
			//Debug.Log ("getting mineral");
			currentlyInAct = true;
			nmAgent.destination = mineralDestination.transform.position;
		}
	}
}
