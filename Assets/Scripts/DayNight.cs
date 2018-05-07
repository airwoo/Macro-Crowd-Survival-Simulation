using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DayNight : MonoBehaviour {

	public GameManager theGameManager;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (theGameManager.isDay == true) {
			transform.RotateAround (Vector3.zero, Vector3.forward, 3f * Time.deltaTime);
			transform.LookAt (Vector3.zero);
		}
		if (theGameManager.isDay == false) {
			transform.RotateAround (Vector3.zero, Vector3.forward, 18f * Time.deltaTime);
			transform.LookAt (Vector3.zero);
		}
	}
}
