using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour {

	public GameManager theGameManager;
	public float spawnTime = 3f;

	public int populationBergling = 2;
	public int populationBerg = 1;

	public GameObject enemy1;
	public GameObject enemy2;

	public Transform spawn;

	public bool nightDone = false;
	public bool dayDone = false;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		StartCoroutine (Spawn ());

	}

	IEnumerator Spawn(){
		if (theGameManager.peopleLeft <= 0) {
			yield return null;
		}
		if (theGameManager.isDay == true) { 
			if (dayDone == false) {
				for (int i = 0; i < populationBergling; i++) {

					Invoke ("OneAtATime1", spawnTime + 2f*i);

				}
				populationBergling += 2;
				dayDone = true;
				nightDone = false;
			}
		}
		//Debug.Log (theGameManager.isDay);
			if (theGameManager.isDay == false) {
			//Debug.Log (nightCount);
			if (nightDone == false) {
				//Debug.Log (nightCount);
				Invoke ("OneAtATime2", 0);
				nightDone = true;
				dayDone = false;
				}
			}

	}
	void OneAtATime1(){
		Instantiate (enemy1, spawn.position, enemy1.transform.rotation);
	}
	void OneAtATime2(){
		Instantiate (enemy2, spawn.position, enemy2.transform.rotation);
	}
}
