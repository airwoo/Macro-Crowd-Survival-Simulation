using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScaryNight : MonoBehaviour {

	public GameManager theGameManager;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter(Collider col){
		
			if ((col.gameObject.tag == "Enemy1")) {
			Debug.Log ("hit");
				Destroy (col.gameObject);
				theGameManager.peopleLeft -= 1;
			}
			if ((col.gameObject.tag == "Enemy2")) {
			Debug.Log ("hit");
				Destroy (col.gameObject);
				theGameManager.peopleLeft -= 5;
			}

	}
}
