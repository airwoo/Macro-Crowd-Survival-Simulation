using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {
	
	public int mineralStorage = 0;
	public int peopleLeft = 0;
	public int foodStorage = 100;
	public float timeLeftDay = 60;
	public float timeLeftNight = 10;

	public Text steelText;
	public Text peopleText;
	public Text foodText;
	public Text dayNightText;
	public Text dayNightCounterText;

	public int dayCount = 1;
	public int nightCount = 1;


	public bool isDay = true;

	public GameObject peopleAliveParentGameObject;
	public GameObject childrenAliveParentGameObject;


	public EnemyManager emScript;
	public GameObject[] enemies1;
	public GameObject[] enemies2;

	public Text GameOver;

	public int foodPlus = 0;
	public int mineralPlus = 0;
	// Use this for initialization
	void Awake () {
		peopleLeft = 20;
	}

	// Update is called once per frame
	void Update () {
		

		steelText.text = "Minerals: " + mineralStorage.ToString();
		peopleText.text = "Lives Left: " + peopleLeft.ToString();
		foodText.text = "Food: " + foodStorage.ToString();

		if (peopleLeft > 0) {

			if (isDay == true) {
			
				dayNightCounterText.text = "Day: " + dayCount.ToString ();
				timeLeftDay -= Time.deltaTime;
				dayNightText.text = "Day Time Left: " + timeLeftDay.ToString ("f0");
				if (timeLeftDay <= 0) {
					isDay = false;
					dayCount += 1;
					timeLeftDay = 60;

				}
			}
			if (isDay == false) {
			
				dayNightCounterText.text = "Night: " + nightCount.ToString ();
				timeLeftNight -= Time.deltaTime;
				dayNightText.text = "Night Time Left: " + timeLeftNight.ToString ("f0");
				if (timeLeftNight <= 0) {
					isDay = true;
					nightCount += 1;
					timeLeftNight = 10;

				}
			}
		}
		if (peopleLeft <= 0) {
			emScript = GetComponent<EnemyManager> ();
			emScript.enabled = false;

			enemies1 = GameObject.FindGameObjectsWithTag ("Enemy1");
			enemies2 = GameObject.FindGameObjectsWithTag ("Enemy2");
			for (int i = 0; i < enemies1.Length; i++) {
				Destroy (enemies1 [i]);
			}
			for (int j = 0; j < enemies2.Length; j++) {
				Destroy (enemies2 [j]);
			}

			peopleLeft = 0;
			GameOver.enabled = true;
		}

	}

}
