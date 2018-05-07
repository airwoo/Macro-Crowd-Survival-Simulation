using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Click : MonoBehaviour {

	[SerializeField]
	private LayerMask clickablesLayer;
	[SerializeField]
	private LayerMask ground;


	public List<GameObject> selectedObjects;

	[HideInInspector]
	public List<GameObject> selectableObjects;

	private Vector3 mousePos1;
	private Vector3 mousePos2;

	public GameObject childPlayer;

	public GameObject peopleAliveParentGameObject;
	public GameObject childrenParentGameObject;

	public GameObject matingArea;

	public Text matingText;
	public float matingCountDown = 0;

	public GameManager scriptGameManager;

	public GameObject[] Population;
	public int maxPopulation;
	public int populationCount;
	public List<GameObject> matingPool;

	public GameObject[] Drones1;
	public GameObject[] Drones2;
	public GameObject[] Drones;

	public Image character1;
	public Image character2;
	public Image character3;
	public Image character4;
	public Image character5;
	public Image character6;

	public Text Job;
	public Text Gender;
	public Text Backpack;
	public Text Speed;
	public Text Strength;
	public Text HP;
	public Text Gather;
	public Text Fight;
	public Text Mate;
	public Text BackpackFull;
	public Text Food;
	public Text Minerals;


	void Awake(){
		selectedObjects = new List<GameObject> ();
		selectableObjects = new List<GameObject> ();
	}
	void Start(){
		
	}
	// Update is called once per frame
	void Update () {

		if (Input.GetMouseButtonDown (0)){
			RaycastHit rayHit;
			if(Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition),out rayHit, Mathf.Infinity,ground)){
					character1.enabled = false;
					character2.enabled = false;
					character3.enabled = false;
					character4.enabled = false;
					character5.enabled = false;
					character6.enabled = false;
				Job.enabled = false;

				Gender.enabled = false;

				Backpack.enabled = false;

				Speed.enabled = false;
			
				Strength.enabled = false;

				HP.enabled = false;

				Gather.enabled = false;

				Fight.enabled = false;

				Mate.enabled = false;
			
				BackpackFull.enabled = false;

				Food.enabled = false;

				Minerals.enabled = false;

			}
		}

		if (Input.GetMouseButtonDown (0)) {
			mousePos1 = Camera.main.ScreenToViewportPoint (Input.mousePosition);

			RaycastHit rayHit;

			if (Physics.Raycast (Camera.main.ScreenPointToRay (Input.mousePosition), out rayHit, Mathf.Infinity, clickablesLayer)) {
				ClickOn clickOnScript = rayHit.collider.GetComponent<ClickOn> ();
			
				if (Input.GetKey ("left ctrl")) {
					if (clickOnScript.currentlySelected == false) {
						selectedObjects.Add (rayHit.collider.gameObject);
						clickOnScript.currentlySelected = true;
						clickOnScript.ClickMe ();
					}
					else{
						selectedObjects.Remove (rayHit.collider.gameObject);
						clickOnScript.currentlySelected = false;
						clickOnScript.ClickMe ();
					}
				}
				else {
					ClearSelection ();

					selectedObjects.Add (rayHit.collider.gameObject);
					clickOnScript.currentlySelected = true;
					if (selectedObjects.Count == 1) {
						if (selectedObjects[0].tag == "Character1") {
							character1.enabled = true;
							Job.enabled = true;
							Job.text = "Job: " + selectedObjects [0].GetComponent<Player> ().job;
							Gender.enabled = true;
							Gender.text = "Gender: Male";
							Backpack.enabled = true;
							Backpack.text = "Backpack: " + selectedObjects [0].GetComponent<Player> ().backpack;
							Speed.enabled = true;
							Speed.text = "Speed: " + selectedObjects [0].GetComponent<Player> ().speed;
							Strength.enabled = true;
							Strength.text = "Strength: " + selectedObjects [0].GetComponent<Player> ().strength;
							HP.enabled = true;
							HP.text = "Health: " + selectedObjects [0].GetComponent<Player> ().health;
							Gather.enabled = true;
							Gather.text = "Can Gather: " + selectedObjects [0].GetComponent<Player> ().canGather;
							Fight.enabled = true;
							Fight.text = "Can Fight: " + selectedObjects [0].GetComponent<Player> ().canFight;
							Mate.enabled = true;
							Mate.text = "Can Mate: " + selectedObjects [0].GetComponent<Player> ().canMate;
							BackpackFull.enabled = true;
							BackpackFull.text = "BackpackFull: " + selectedObjects [0].GetComponent<Player> ().isFull;
							Food.enabled = true;
							Food.text = "Food: " + selectedObjects [0].GetComponent<Player> ().currentFoodHold;
							Minerals.enabled = true;
							Minerals.text = "Minerals: " + selectedObjects [0].GetComponent<Player> ().currentMineralHold;
						}
						if (selectedObjects[0].tag == "Character2") {
							character2.enabled = true;
							Job.enabled = true;
							Job.text = "Job: " + selectedObjects [0].GetComponent<Player> ().job;
							Gender.enabled = true;
							Gender.text = "Gender: Male";
							Backpack.enabled = true;
							Backpack.text = "Backpack: " + selectedObjects [0].GetComponent<Player> ().backpack;
							Speed.enabled = true;
							Speed.text = "Speed: " + selectedObjects [0].GetComponent<Player> ().speed;
							Strength.enabled = true;
							Strength.text = "Strength: " + selectedObjects [0].GetComponent<Player> ().strength;
							HP.enabled = true;
							HP.text = "Health: " + selectedObjects [0].GetComponent<Player> ().health;
							Gather.enabled = true;
							Gather.text = "Can Gather: " + selectedObjects [0].GetComponent<Player> ().canGather;
							Fight.enabled = true;
							Fight.text = "Can Fight: " + selectedObjects [0].GetComponent<Player> ().canFight;
							Mate.enabled = true;
							Mate.text = "Can Mate: " + selectedObjects [0].GetComponent<Player> ().canMate;
							BackpackFull.enabled = true;
							BackpackFull.text = "BackpackFull: " + selectedObjects [0].GetComponent<Player> ().isFull;
							Food.enabled = true;
							Food.text = "Food: " + selectedObjects [0].GetComponent<Player> ().currentFoodHold;
							Minerals.enabled = true;
							Minerals.text = "Minerals: " + selectedObjects [0].GetComponent<Player> ().currentMineralHold;
						}
						if (selectedObjects[0].tag == "Character3") {
							character3.enabled = true;
							Job.enabled = true;
							Job.text = "Job: " + selectedObjects [0].GetComponent<Player> ().job;
							Gender.enabled = true;
							Gender.text = "Gender: Male";
							Backpack.enabled = true;
							Backpack.text = "Backpack: " + selectedObjects [0].GetComponent<Player> ().backpack;
							Speed.enabled = true;
							Speed.text = "Speed: " + selectedObjects [0].GetComponent<Player> ().speed;
							Strength.enabled = true;
							Strength.text = "Strength: " + selectedObjects [0].GetComponent<Player> ().strength;
							HP.enabled = true;
							HP.text = "Health: " + selectedObjects [0].GetComponent<Player> ().health;
							Gather.enabled = true;
							Gather.text = "Can Gather: " + selectedObjects [0].GetComponent<Player> ().canGather;
							Fight.enabled = true;
							Fight.text = "Can Fight: " + selectedObjects [0].GetComponent<Player> ().canFight;
							Mate.enabled = true;
							Mate.text = "Can Mate: " + selectedObjects [0].GetComponent<Player> ().canMate;
							BackpackFull.enabled = true;
							BackpackFull.text = "BackpackFull: " + selectedObjects [0].GetComponent<Player> ().isFull;
							Food.enabled = true;
							Food.text = "Food: " + selectedObjects [0].GetComponent<Player> ().currentFoodHold;
							Minerals.enabled = true;
							Minerals.text = "Minerals: " + selectedObjects [0].GetComponent<Player> ().currentMineralHold;
						}
						if (selectedObjects[0].tag == "Character4") {
							character4.enabled = true;
							Job.enabled = true;
							Job.text = "Job: " + selectedObjects [0].GetComponent<Player> ().job;
							Gender.enabled = true;
							Gender.text = "Gender: Female";
							Backpack.enabled = true;
							Backpack.text = "Backpack: " + selectedObjects [0].GetComponent<Player> ().backpack;
							Speed.enabled = true;
							Speed.text = "Speed: " + selectedObjects [0].GetComponent<Player> ().speed;
							Strength.enabled = true;
							Strength.text = "Strength: " + selectedObjects [0].GetComponent<Player> ().strength;
							HP.enabled = true;
							HP.text = "Health: " + selectedObjects [0].GetComponent<Player> ().health;
							Gather.enabled = true;
							Gather.text = "Can Gather: " + selectedObjects [0].GetComponent<Player> ().canGather;
							Fight.enabled = true;
							Fight.text = "Can Fight: " + selectedObjects [0].GetComponent<Player> ().canFight;
							Mate.enabled = true;
							Mate.text = "Can Mate: " + selectedObjects [0].GetComponent<Player> ().canMate;
							BackpackFull.enabled = true;
							BackpackFull.text = "BackpackFull: " + selectedObjects [0].GetComponent<Player> ().isFull;
							Food.enabled = true;
							Food.text = "Food: " + selectedObjects [0].GetComponent<Player> ().currentFoodHold;
							Minerals.enabled = true;
							Minerals.text = "Minerals: " + selectedObjects [0].GetComponent<Player> ().currentMineralHold;
						}
						if (selectedObjects[0].tag == "Character5") {
							character5.enabled = true;
							Job.enabled = true;
							Job.text = "Job: " + selectedObjects [0].GetComponent<Player> ().job;
							Gender.enabled = true;
							Gender.text = "Gender: Female";
							Backpack.enabled = true;
							Backpack.text = "Backpack: " + selectedObjects [0].GetComponent<Player> ().backpack;
							Speed.enabled = true;
							Speed.text = "Speed: " + selectedObjects [0].GetComponent<Player> ().speed;
							Strength.enabled = true;
							Strength.text = "Strength: " + selectedObjects [0].GetComponent<Player> ().strength;
							HP.enabled = true;
							HP.text = "Health: " + selectedObjects [0].GetComponent<Player> ().health;
							Gather.enabled = true;
							Gather.text = "Can Gather: " + selectedObjects [0].GetComponent<Player> ().canGather;
							Fight.enabled = true;
							Fight.text = "Can Fight: " + selectedObjects [0].GetComponent<Player> ().canFight;
							Mate.enabled = true;
							Mate.text = "Can Mate: " + selectedObjects [0].GetComponent<Player> ().canMate;
							BackpackFull.enabled = true;
							BackpackFull.text = "BackpackFull: " + selectedObjects [0].GetComponent<Player> ().isFull;
							Food.enabled = true;
							Food.text = "Food: " + selectedObjects [0].GetComponent<Player> ().currentFoodHold;
							Minerals.enabled = true;
							Minerals.text = "Minerals: " + selectedObjects [0].GetComponent<Player> ().currentMineralHold;
						}
						if (selectedObjects[0].tag == "Character6") {
							character6.enabled = true;
							Job.enabled = true;
							Job.text = "Job: " + selectedObjects [0].GetComponent<Player> ().job;
							Gender.enabled = true;
							Gender.text = "Gender: Female";
							Backpack.enabled = true;
							Backpack.text = "Backpack: " + selectedObjects [0].GetComponent<Player> ().backpack;
							Speed.enabled = true;
							Speed.text = "Speed: " + selectedObjects [0].GetComponent<Player> ().speed;
							Strength.enabled = true;
							Strength.text = "Strength: " + selectedObjects [0].GetComponent<Player> ().strength;
							HP.enabled = true;
							HP.text = "Health: " + selectedObjects [0].GetComponent<Player> ().health;
							Gather.enabled = true;
							Gather.text = "Can Gather: " + selectedObjects [0].GetComponent<Player> ().canGather;
							Fight.enabled = true;
							Fight.text = "Can Fight: " + selectedObjects [0].GetComponent<Player> ().canFight;
							Mate.enabled = true;
							Mate.text = "Can Mate: " + selectedObjects [0].GetComponent<Player> ().canMate;
							BackpackFull.enabled = true;
							BackpackFull.text = "BackpackFull: " + selectedObjects [0].GetComponent<Player> ().isFull;
							Food.enabled = true;
							Food.text = "Food: " + selectedObjects [0].GetComponent<Player> ().currentFoodHold;
							Minerals.enabled = true;
							Minerals.text = "Minerals: " + selectedObjects [0].GetComponent<Player> ().currentMineralHold;
						}
					}
					clickOnScript.ClickMe ();
				}
			}
		}

		if (Input.GetMouseButtonUp (0)) {
			mousePos2 = Camera.main.ScreenToViewportPoint (Input.mousePosition);
			if(mousePos1 != mousePos2){
				SelectObjects();
			}
		}

		if (matingCountDown == 0) {
			matingText.text = ("Mating: Available");
			if (Input.GetKeyDown (KeyCode.M)) {
				if (selectedObjects.Count == 2) {
					GameObject one = selectedObjects [0];
					Player scriptPlayerOne = one.GetComponent<Player> ();
					GameObject two = selectedObjects [1];
					Player scriptPlayerTwo = two.GetComponent<Player> ();

					if ((scriptPlayerOne.isMale == true && scriptPlayerTwo.isMale == false) || (scriptPlayerOne.isMale == false && scriptPlayerTwo.isMale == true)) {
						if(scriptPlayerOne.job == "Warrior" || scriptPlayerTwo.job == "Warrior"){
							if (scriptGameManager.mineralStorage >= 10) {
								if (scriptGameManager.foodStorage >= 10) {
									scriptGameManager.foodStorage -= 10;
									scriptGameManager.mineralStorage -= 10;
									GeneticAlgorithmMating ();
									matingCountDown = 5;
								}
							}
						}
						if(scriptPlayerOne.job != "Warrior" && scriptPlayerTwo.job != "Warrior"){
							if (scriptGameManager.foodStorage >= 10) {
								scriptGameManager.foodStorage -= 10;
								GeneticAlgorithmMating ();
								matingCountDown = 5;
							}
						}
					}
				}

			}
		}
		if (matingCountDown == 0) {
			matingText.text = ("Mating: Available");
			if (Input.GetKeyDown (KeyCode.Alpha1)) {
				//Debug.Log ("Button 1 is working");
				GeneticAlgorithmDrone ();						
			}
		}
		if (matingCountDown == 0) {
			matingText.text = ("Mating: Available");
			if (Input.GetKeyDown (KeyCode.Alpha2)) {
				//Debug.Log ("Button 1 is working");
				GeneticAlgorithmFlash ();						
			}
		}
		if (matingCountDown == 0) {
			matingText.text = ("Mating: Available");
			if (scriptGameManager.mineralStorage >= 10) {
				if (Input.GetKeyDown (KeyCode.Alpha3)) {
					//Debug.Log ("Button 1 is working");

					GeneticAlgorithmWarrior ();						
				}
			}
		}
			


		if(matingCountDown <= 5 && matingCountDown != 0){
			matingText.text = "Next Mating in:" + matingCountDown.ToString ("f0");
			matingCountDown -= Time.deltaTime;
		if (matingCountDown <= 0) {
			matingCountDown = 0;
			}
		}

	
	}

	void SelectObjects()
	{
		List<GameObject> remObjects = new List<GameObject> ();

		if (Input.GetKey ("left ctrl") == false) {
			ClearSelection ();
		}
		Rect selectRect = new Rect (mousePos1.x, mousePos1.y, mousePos2.x - mousePos1.x, mousePos2.y - mousePos1.y);

		foreach (GameObject selectObject in selectableObjects) {
			if (selectObject != null) {
				if (selectRect.Contains (Camera.main.WorldToViewportPoint (selectObject.transform.position), true)) {
					selectedObjects.Add (selectObject);
					selectObject.GetComponent<ClickOn>().currentlySelected = true;
					selectObject.GetComponent<ClickOn>().ClickMe ();
				}
			}
			else {
				remObjects.Add (selectObject);
			}
		}
		if (remObjects.Count > 0) {
			foreach (GameObject rem in remObjects) {
				selectableObjects.Remove (rem);
			}
			remObjects.Clear ();
		}
	}

	void ClearSelection(){
		if (selectedObjects.Count > 0) {
			foreach (GameObject obj in selectedObjects) {
				if (obj != null) {
					obj.GetComponent<ClickOn> ().currentlySelected = false;
					obj.GetComponent<ClickOn> ().ClickMe ();
				}
			}

			selectedObjects.Clear ();
		}
	}

	void GeneticAlgorithmMating(){
		
			if (selectedObjects.Count == 2) {

				GameObject one = selectedObjects [0];
				Player scriptPlayerOne = one.GetComponent<Player> ();
				GameObject two = selectedObjects [1];
				Player scriptPlayerTwo = two.GetComponent<Player> ();
				//Debug.Log(scriptPlayerOne.isMale);
				//Debug.Log(scriptPlayerTwo.isMale);
				//---------------------------------Male Dominant-------------------------------------
				if ((scriptPlayerOne.isMale == true && scriptPlayerTwo.isMale == false) || (scriptPlayerOne.isMale == false && scriptPlayerTwo.isMale == true)){
					Debug.Log("Mating");
					Player scriptChild = childPlayer.GetComponent<Player> ();
					scriptChild.myRend = childPlayer.GetComponent<MeshRenderer> ();
					//-----------------------------------------------50% chance of male------------------------------------------------------------
					if (Random.value < 0.5f) {
						//--------------------------------------------Crossover-------------------------------------------------------------------------
						scriptChild.isMale = true;
					} else {
						scriptChild.isMale = false;
					}
						scriptChild.backpack = scriptPlayerOne.backpack;
						scriptChild.speed = scriptPlayerOne.speed;
						scriptChild.strength = scriptPlayerTwo.strength;
						scriptChild.health = 50;
						scriptChild.canFight = false;
						scriptChild.canGather = false;
						scriptChild.canMate = true;
						scriptChild.isFull = false;

					//Debug.Log (scriptChild.backpack);

						//-----------------------------------------------Assigning Material and Job---------------------------------------------------------
					if (scriptChild.isMale == true) {
						if (scriptChild.backpack > scriptChild.speed && scriptChild.backpack > scriptChild.strength) {
							scriptChild.job = "Drone";
							scriptChild.myRend.material = scriptChild.Character1;
							scriptChild.tag = "Character1";
						}

						if (scriptChild.speed > scriptChild.backpack && scriptChild.speed > scriptChild.strength) {
							scriptChild.job = "Flash";
							scriptChild.myRend.material = scriptChild.Character2;
							scriptChild.tag = "Character2";
						}
						if (scriptChild.strength >= scriptChild.backpack && scriptChild.strength >= scriptChild.speed) {
							scriptChild.job = "Warrior";
							scriptChild.myRend.material = scriptChild.Character3;
							scriptChild.tag = "Character3";
						}
					} if(scriptChild.isMale == false) {
						if (scriptChild.backpack > scriptChild.speed && scriptChild.backpack > scriptChild.strength) {
							scriptChild.job = "Drone";
							scriptChild.myRend.material = scriptChild.Character4;
							scriptChild.tag = "Character4";
						}

						if (scriptChild.speed > scriptChild.backpack && scriptChild.speed > scriptChild.strength) {
							scriptChild.job = "Flash";
							scriptChild.myRend.material = scriptChild.Character5;
							scriptChild.tag = "Character5";
						}
						if (scriptChild.strength >= scriptChild.backpack && scriptChild.strength >= scriptChild.speed) {
							scriptChild.job = "Warrior";
							scriptChild.myRend.material = scriptChild.Character6;
							scriptChild.tag = "Character6";
						}
					}

						//-----------------------------------------------Mutation--------------------------------------------------

						if (Random.value < 0.10f) {
							if (scriptChild.job == "Drone") {
								scriptChild.backpack = Random.Range (7, 10);
								scriptChild.speed = Random.Range (1, 4);
								scriptChild.strength = 0;
							}
							if (scriptChild.job == "Flash") {
								scriptChild.backpack = Random.Range (1, 4);
								scriptChild.speed = Random.Range (7, 10);
								scriptChild.strength = 0;
							}
							if (scriptChild.job == "Warrior") {
								scriptChild.backpack = 0;
								scriptChild.speed = Random.Range (1, 4);
								scriptChild.strength = Random.Range (7, 10);
							}
						} else if (Random.value >= 0.10f && Random.value <= 0.70f) {
							int dice = Random.Range (1, 3);
							int dice2 = Random.Range (1, 2);
							if (dice == 1) {
								if (dice2 == 1) {
									scriptChild.backpack += 1;
								}
								if (dice2 == 2) {
									scriptChild.backpack -= 1;
									if (scriptChild.backpack == 0) {
										scriptChild.backpack = 1;
									}
								}
							}
							if (dice == 2) {
								if (dice2 == 1) {
									scriptChild.speed += 1;
								}
								if (dice2 == 2) {
									scriptChild.speed -= 1;
									if (scriptChild.speed == 0) {
										scriptChild.speed = 1;
									}
								}
							}
							if (dice == 3) {
								if (dice2 == 1) {
									scriptChild.strength += 1;
								}
								if (dice2 == 2) {
									scriptChild.strength -= 1;
									if (scriptChild.strength == 0) {
										scriptChild.strength = 1;
									}
								}
							}
						} else {
							//no mutation occurs
						}
				//Debug.Log (scriptChild.backpack);
						//next depending on greatest stat assign material and job
						//add mutation where random stat goes up or down 1
						//percent of nothing happenening
						//small percent of entirely random stats and different child
				childPlayer.GetComponent<Player>().isMale = scriptChild.isMale;
				childPlayer.GetComponent<Player>().backpack = scriptChild.backpack;
				childPlayer.GetComponent<Player>().speed = scriptChild.speed;
				childPlayer.GetComponent<Player>().strength = scriptChild.strength;
				childPlayer.GetComponent<Player>().health = scriptChild.health ;
				childPlayer.GetComponent<Player>().canFight = scriptChild.canFight;
				childPlayer.GetComponent<Player>().canGather = scriptChild.canGather;
				childPlayer.GetComponent<Player>().canMate = scriptChild.canMate;
				childPlayer.GetComponent<Player>().isFull = scriptChild.isFull;
				childPlayer.GetComponent<Player>().job = scriptChild.job;
				childPlayer.GetComponent<Player>().myRend.material = scriptChild.myRend.sharedMaterial;
			
					GameObject matePlayer = Instantiate (childPlayer, matingArea.transform.position, matingArea.transform.rotation) as GameObject;
					matePlayer.transform.parent = childrenParentGameObject.transform;
					//Debug.Log (scriptChild.backpack);
					} 

				}


		}

	void GeneticAlgorithmDrone(){
		
			matingPool = new List<GameObject> ();
			int matingPoolCounter = 0;

			Population = new GameObject[maxPopulation];
			populationCount = 0;

			Drones1 = GameObject.FindGameObjectsWithTag ("Character1");
			Drones2 = GameObject.FindGameObjectsWithTag ("Character4");
			int count = Drones1.Length + Drones2.Length;
			Drones = new GameObject[count];
			Drones1.CopyTo (Drones, 0);
			Drones2.CopyTo (Drones, Drones1.Length);
			populationCount = Drones.Length;
			if(Drones1.Length >= 1 && Drones2.Length >=1){
			float fitness;
			float timesInMatingPool;
			for (int i = 0; i < populationCount; i++) {
				fitness = Drones [i].GetComponent<Player> ().backpack;
				if (fitness < 0) {
					fitness = 0;
				}
				timesInMatingPool = fitness;
				for (int t = 0; t < timesInMatingPool; t++) {
					matingPool.Add (Drones [i]);
					matingPoolCounter++;
				}

			}

			int randomPick1 = Random.Range (0, matingPoolCounter);
			int randomPick2 = Random.Range (0, matingPoolCounter);
		//Debug.Log (randomPick1);
		//Debug.Log (randomPick2);
			
				while (matingPool [randomPick1].GetComponent<Player> ().isMale == matingPool [randomPick2].GetComponent<Player> ().isMale) {
					randomPick1 = Random.Range (0, matingPoolCounter);
					randomPick2 = Random.Range (0, matingPoolCounter);
	
				}
			
		GameObject one = matingPool [randomPick1];
		Player scriptPlayerOne = one.GetComponent<Player> ();
		GameObject two = matingPool [randomPick2];
		Player scriptPlayerTwo = two.GetComponent<Player> ();
		//Debug.Log (one.GetComponent<Player> ().isMale);
		//Debug.Log (two.GetComponent<Player> ().isMale);
		if ((scriptPlayerOne.isMale == true && scriptPlayerTwo.isMale == false) || (scriptPlayerOne.isMale == false && scriptPlayerTwo.isMale == true)){

			Debug.Log("Mating");
			if (scriptGameManager.foodStorage >= 10) {
				scriptGameManager.foodStorage -= 10;

				matingCountDown = 5;
			}
			Player scriptChild = childPlayer.GetComponent<Player> ();
			scriptChild.myRend = childPlayer.GetComponent<MeshRenderer> ();
			//-----------------------------------------------50% chance of male------------------------------------------------------------
			if (Random.value < 0.5f) {
				//--------------------------------------------Crossover-------------------------------------------------------------------------
				scriptChild.isMale = true;
			} else {
				scriptChild.isMale = false;
			}
			scriptChild.backpack = scriptPlayerOne.backpack;
			scriptChild.speed = scriptPlayerOne.speed;
			scriptChild.strength = scriptPlayerTwo.strength;
			scriptChild.health = 50;
			scriptChild.canFight = false;
			scriptChild.canGather = false;
			scriptChild.canMate = true;
			scriptChild.isFull = false;

			//Debug.Log (scriptChild.backpack);

			//-----------------------------------------------Assigning Material and Job---------------------------------------------------------
			if (scriptChild.isMale == true) {
				if (scriptChild.backpack > scriptChild.speed && scriptChild.backpack > scriptChild.strength) {
					scriptChild.job = "Drone";
					scriptChild.myRend.material = scriptChild.Character1;
					scriptChild.tag = "Character1";
				}

				if (scriptChild.speed > scriptChild.backpack && scriptChild.speed > scriptChild.strength) {
					scriptChild.job = "Flash";
					scriptChild.myRend.material = scriptChild.Character2;
					scriptChild.tag = "Character2";
				}
				if (scriptChild.strength >= scriptChild.backpack && scriptChild.strength >= scriptChild.speed) {
					scriptChild.job = "Warrior";
					scriptChild.myRend.material = scriptChild.Character3;
					scriptChild.tag = "Character3";
				}
			} if(scriptChild.isMale == false) {
				if (scriptChild.backpack > scriptChild.speed && scriptChild.backpack > scriptChild.strength) {
					scriptChild.job = "Drone";
					scriptChild.myRend.material = scriptChild.Character4;
					scriptChild.tag = "Character4";
				}

				if (scriptChild.speed > scriptChild.backpack && scriptChild.speed > scriptChild.strength) {
					scriptChild.job = "Flash";
					scriptChild.myRend.material = scriptChild.Character5;
					scriptChild.tag = "Character5";
				}
				if (scriptChild.strength >= scriptChild.backpack && scriptChild.strength >= scriptChild.speed) {
					scriptChild.job = "Warrior";
					scriptChild.myRend.material = scriptChild.Character6;
					scriptChild.tag = "Character6";
				}
			}

			//-----------------------------------------------Mutation--------------------------------------------------

			if (Random.value < 0.10f) {
				if (scriptChild.job == "Drone") {
					scriptChild.backpack = Random.Range (7, 10);
					scriptChild.speed = Random.Range (1, 4);
					scriptChild.strength = 0;
				}
				if (scriptChild.job == "Flash") {
					scriptChild.backpack = Random.Range (1, 4);
					scriptChild.speed = Random.Range (7, 10);
					scriptChild.strength = 0;
				}
				if (scriptChild.job == "Warrior") {
					scriptChild.backpack = 0;
					scriptChild.speed = Random.Range (1, 4);
					scriptChild.strength = Random.Range (7, 10);
				}
			} else if (Random.value >= 0.10f && Random.value <= 0.70f) {
				int dice = Random.Range (1, 3);
				int dice2 = Random.Range (1, 2);
				if (dice == 1) {
					if (dice2 == 1) {
						scriptChild.backpack += 1;
					}
					if (dice2 == 2) {
						scriptChild.backpack -= 1;
						if (scriptChild.backpack == 0) {
							scriptChild.backpack = 1;
						}
					}
				}
				if (dice == 2) {
					if (dice2 == 1) {
						scriptChild.speed += 1;
					}
					if (dice2 == 2) {
						scriptChild.speed -= 1;
						if (scriptChild.speed == 0) {
							scriptChild.speed = 1;
						}
					}
				}
				if (dice == 3) {
					if (dice2 == 1) {
						scriptChild.strength += 1;
					}
					if (dice2 == 2) {
						scriptChild.strength -= 1;
						if (scriptChild.strength == 0) {
							scriptChild.strength = 1;
						}
					}
				}
			} else {
				//no mutation occurs
			}
			//Debug.Log (scriptChild.backpack);
			//next depending on greatest stat assign material and job
			//add mutation where random stat goes up or down 1
			//percent of nothing happenening
			//small percent of entirely random stats and different child
			childPlayer.GetComponent<Player>().isMale = scriptChild.isMale;
			childPlayer.GetComponent<Player>().backpack = scriptChild.backpack;
			childPlayer.GetComponent<Player>().speed = scriptChild.speed;
			childPlayer.GetComponent<Player>().strength = scriptChild.strength;
			childPlayer.GetComponent<Player>().health = scriptChild.health ;
			childPlayer.GetComponent<Player>().canFight = scriptChild.canFight;
			childPlayer.GetComponent<Player>().canGather = scriptChild.canGather;
			childPlayer.GetComponent<Player>().canMate = scriptChild.canMate;
			childPlayer.GetComponent<Player>().isFull = scriptChild.isFull;
			childPlayer.GetComponent<Player>().job = scriptChild.job;
			childPlayer.GetComponent<Player>().myRend.material = scriptChild.myRend.sharedMaterial;

			GameObject matePlayer = Instantiate (childPlayer, matingArea.transform.position, matingArea.transform.rotation) as GameObject;
			matePlayer.transform.parent = childrenParentGameObject.transform;
			//Debug.Log (scriptChild.backpack);
			}
		} 
	}

	void GeneticAlgorithmFlash(){
		
		matingPool = new List<GameObject> ();
		int matingPoolCounter = 0;

		Population = new GameObject[maxPopulation];
		populationCount = 0;

		Drones1 = GameObject.FindGameObjectsWithTag ("Character2");
		Drones2 = GameObject.FindGameObjectsWithTag ("Character5");
		int count = Drones1.Length + Drones2.Length;
		Drones = new GameObject[count];
		Drones1.CopyTo (Drones, 0);
		Drones2.CopyTo (Drones, Drones1.Length);
		populationCount = Drones.Length;
		if(Drones1.Length >= 1 && Drones2.Length >=1){

		float fitness;
		float timesInMatingPool;
		for (int i = 0; i < populationCount; i++) {
			fitness = Drones [i].GetComponent<Player> ().speed;
			if (fitness < 0) {
				fitness = 0;
			}
			timesInMatingPool = fitness;
			for (int t = 0; t < timesInMatingPool; t++) {
				matingPool.Add (Drones [i]);
				matingPoolCounter++;
			}

		}

		int randomPick1 = Random.Range (0, matingPoolCounter);
		int randomPick2 = Random.Range (0, matingPoolCounter);
		//Debug.Log (randomPick1);
		//Debug.Log (randomPick2);

		while (matingPool [randomPick1].GetComponent<Player> ().isMale == matingPool [randomPick2].GetComponent<Player> ().isMale) {
			randomPick1 = Random.Range (0, matingPoolCounter);
			randomPick2 = Random.Range (0, matingPoolCounter);

		}

		GameObject one = matingPool [randomPick1];
		Player scriptPlayerOne = one.GetComponent<Player> ();
		GameObject two = matingPool [randomPick2];
		Player scriptPlayerTwo = two.GetComponent<Player> ();
		//Debug.Log (one.GetComponent<Player> ().isMale);
		//Debug.Log (two.GetComponent<Player> ().isMale);
		if ((scriptPlayerOne.isMale == true && scriptPlayerTwo.isMale == false) || (scriptPlayerOne.isMale == false && scriptPlayerTwo.isMale == true)){

			Debug.Log("Mating");
			if (scriptGameManager.foodStorage >= 10) {
				scriptGameManager.foodStorage -= 10;

				matingCountDown = 5;
			}
			Player scriptChild = childPlayer.GetComponent<Player> ();
			scriptChild.myRend = childPlayer.GetComponent<MeshRenderer> ();
			//-----------------------------------------------50% chance of male------------------------------------------------------------
			if (Random.value < 0.5f) {
				//--------------------------------------------Crossover-------------------------------------------------------------------------
				scriptChild.isMale = true;
			} else {
				scriptChild.isMale = false;
			}
			scriptChild.backpack = scriptPlayerOne.backpack;
			scriptChild.speed = scriptPlayerOne.speed;
			scriptChild.strength = scriptPlayerTwo.strength;
			scriptChild.health = 50;
			scriptChild.canFight = false;
			scriptChild.canGather = false;
			scriptChild.canMate = true;
			scriptChild.isFull = false;

			//Debug.Log (scriptChild.backpack);

			//-----------------------------------------------Assigning Material and Job---------------------------------------------------------
			if (scriptChild.isMale == true) {
				if (scriptChild.backpack > scriptChild.speed && scriptChild.backpack > scriptChild.strength) {
					scriptChild.job = "Drone";
					scriptChild.myRend.material = scriptChild.Character1;
					scriptChild.tag = "Character1";
				}

				if (scriptChild.speed > scriptChild.backpack && scriptChild.speed > scriptChild.strength) {
					scriptChild.job = "Flash";
					scriptChild.myRend.material = scriptChild.Character2;
					scriptChild.tag = "Character2";
				}
				if (scriptChild.strength >= scriptChild.backpack && scriptChild.strength >= scriptChild.speed) {
					scriptChild.job = "Warrior";
					scriptChild.myRend.material = scriptChild.Character3;
					scriptChild.tag = "Character3";
				}
			} if(scriptChild.isMale == false) {
				if (scriptChild.backpack > scriptChild.speed && scriptChild.backpack > scriptChild.strength) {
					scriptChild.job = "Drone";
					scriptChild.myRend.material = scriptChild.Character4;
					scriptChild.tag = "Character4";
				}

				if (scriptChild.speed > scriptChild.backpack && scriptChild.speed > scriptChild.strength) {
					scriptChild.job = "Flash";
					scriptChild.myRend.material = scriptChild.Character5;
					scriptChild.tag = "Character5";
				}
				if (scriptChild.strength >= scriptChild.backpack && scriptChild.strength >= scriptChild.speed) {
					scriptChild.job = "Warrior";
					scriptChild.myRend.material = scriptChild.Character6;
					scriptChild.tag = "Character6";
				}
			}

			//-----------------------------------------------Mutation--------------------------------------------------

			if (Random.value < 0.10f) {
				if (scriptChild.job == "Drone") {
					scriptChild.backpack = Random.Range (7, 10);
					scriptChild.speed = Random.Range (1, 4);
					scriptChild.strength = 0;
				}
				if (scriptChild.job == "Flash") {
					scriptChild.backpack = Random.Range (1, 4);
					scriptChild.speed = Random.Range (7, 10);
					scriptChild.strength = 0;
				}
				if (scriptChild.job == "Warrior") {
					scriptChild.backpack = 0;
					scriptChild.speed = Random.Range (1, 4);
					scriptChild.strength = Random.Range (7, 10);
				}
			} else if (Random.value >= 0.10f && Random.value <= 0.70f) {
				int dice = Random.Range (1, 3);
				int dice2 = Random.Range (1, 2);
				if (dice == 1) {
					if (dice2 == 1) {
						scriptChild.backpack += 1;
					}
					if (dice2 == 2) {
						scriptChild.backpack -= 1;
						if (scriptChild.backpack == 0) {
							scriptChild.backpack = 1;
						}
					}
				}
				if (dice == 2) {
					if (dice2 == 1) {
						scriptChild.speed += 1;
					}
					if (dice2 == 2) {
						scriptChild.speed -= 1;
						if (scriptChild.speed == 0) {
							scriptChild.speed = 1;
						}
					}
				}
				if (dice == 3) {
					if (dice2 == 1) {
						scriptChild.strength += 1;
					}
					if (dice2 == 2) {
						scriptChild.strength -= 1;
						if (scriptChild.strength == 0) {
							scriptChild.strength = 1;
						}
					}
				}
			} else {
				//no mutation occurs
			}
			//Debug.Log (scriptChild.backpack);
			//next depending on greatest stat assign material and job
			//add mutation where random stat goes up or down 1
			//percent of nothing happenening
			//small percent of entirely random stats and different child
			childPlayer.GetComponent<Player>().isMale = scriptChild.isMale;
			childPlayer.GetComponent<Player>().backpack = scriptChild.backpack;
			childPlayer.GetComponent<Player>().speed = scriptChild.speed;
			childPlayer.GetComponent<Player>().strength = scriptChild.strength;
			childPlayer.GetComponent<Player>().health = scriptChild.health ;
			childPlayer.GetComponent<Player>().canFight = scriptChild.canFight;
			childPlayer.GetComponent<Player>().canGather = scriptChild.canGather;
			childPlayer.GetComponent<Player>().canMate = scriptChild.canMate;
			childPlayer.GetComponent<Player>().isFull = scriptChild.isFull;
			childPlayer.GetComponent<Player>().job = scriptChild.job;
			childPlayer.GetComponent<Player>().myRend.material = scriptChild.myRend.sharedMaterial;

			GameObject matePlayer = Instantiate (childPlayer, matingArea.transform.position, matingArea.transform.rotation) as GameObject;
			matePlayer.transform.parent = childrenParentGameObject.transform;
			//Debug.Log (scriptChild.backpack);
			}
		} 
	}


	void GeneticAlgorithmWarrior(){
		matingPool = new List<GameObject> ();
		int matingPoolCounter = 0;

		Population = new GameObject[maxPopulation];
		populationCount = 0;

		Drones1 = GameObject.FindGameObjectsWithTag ("Character3");
		Drones2 = GameObject.FindGameObjectsWithTag ("Character6");
		int count = Drones1.Length + Drones2.Length;
		Drones = new GameObject[count];
		Drones1.CopyTo (Drones, 0);
		Drones2.CopyTo (Drones, Drones1.Length);
		populationCount = Drones.Length;
		if (Drones1.Length >= 1 && Drones2.Length >= 1) {
			scriptGameManager.mineralStorage -= 10;
			float fitness;
			float timesInMatingPool;
			for (int i = 0; i < populationCount; i++) {
				fitness = Drones [i].GetComponent<Player> ().strength;
				if (fitness < 0) {
					fitness = 0;
				}
				timesInMatingPool = fitness;
				for (int t = 0; t < timesInMatingPool; t++) {
					matingPool.Add (Drones [i]);
					matingPoolCounter++;
				}

			}

			int randomPick1 = Random.Range (0, matingPoolCounter);
			int randomPick2 = Random.Range (0, matingPoolCounter);
			//Debug.Log (randomPick1);
			//Debug.Log (randomPick2);

			while (matingPool [randomPick1].GetComponent<Player> ().isMale == matingPool [randomPick2].GetComponent<Player> ().isMale) {
				randomPick1 = Random.Range (0, matingPoolCounter);
				randomPick2 = Random.Range (0, matingPoolCounter);

			}

			GameObject one = matingPool [randomPick1];
			Player scriptPlayerOne = one.GetComponent<Player> ();
			GameObject two = matingPool [randomPick2];
			Player scriptPlayerTwo = two.GetComponent<Player> ();
			//Debug.Log (one.GetComponent<Player> ().isMale);
			//Debug.Log (two.GetComponent<Player> ().isMale);
			if ((scriptPlayerOne.isMale == true && scriptPlayerTwo.isMale == false) || (scriptPlayerOne.isMale == false && scriptPlayerTwo.isMale == true)) {

				Debug.Log ("Mating");
				if (scriptGameManager.foodStorage >= 10) {
					scriptGameManager.foodStorage -= 10;

					matingCountDown = 5;
				}
				Player scriptChild = childPlayer.GetComponent<Player> ();
				scriptChild.myRend = childPlayer.GetComponent<MeshRenderer> ();
				//-----------------------------------------------50% chance of male------------------------------------------------------------
				if (Random.value < 0.5f) {
					//--------------------------------------------Crossover-------------------------------------------------------------------------
					scriptChild.isMale = true;
				} else {
					scriptChild.isMale = false;
				}
				scriptChild.backpack = scriptPlayerOne.backpack;
				scriptChild.speed = scriptPlayerOne.speed;
				scriptChild.strength = scriptPlayerTwo.strength;
				scriptChild.health = 50;
				scriptChild.canFight = false;
				scriptChild.canGather = false;
				scriptChild.canMate = true;
				scriptChild.isFull = false;

				//Debug.Log (scriptChild.backpack);

				//-----------------------------------------------Assigning Material and Job---------------------------------------------------------
				if (scriptChild.isMale == true) {
					if (scriptChild.backpack > scriptChild.speed && scriptChild.backpack > scriptChild.strength) {
						scriptChild.job = "Drone";
						scriptChild.myRend.material = scriptChild.Character1;
						scriptChild.tag = "Character1";
					}

					if (scriptChild.speed > scriptChild.backpack && scriptChild.speed > scriptChild.strength) {
						scriptChild.job = "Flash";
						scriptChild.myRend.material = scriptChild.Character2;
						scriptChild.tag = "Character2";
					}
					if (scriptChild.strength >= scriptChild.backpack && scriptChild.strength >= scriptChild.speed) {
						scriptChild.job = "Warrior";
						scriptChild.myRend.material = scriptChild.Character3;
						scriptChild.tag = "Character3";
					}
				}
				if (scriptChild.isMale == false) {
					if (scriptChild.backpack > scriptChild.speed && scriptChild.backpack > scriptChild.strength) {
						scriptChild.job = "Drone";
						scriptChild.myRend.material = scriptChild.Character4;
						scriptChild.tag = "Character4";
					}

					if (scriptChild.speed > scriptChild.backpack && scriptChild.speed > scriptChild.strength) {
						scriptChild.job = "Flash";
						scriptChild.myRend.material = scriptChild.Character5;
						scriptChild.tag = "Character5";
					}
					if (scriptChild.strength >= scriptChild.backpack && scriptChild.strength >= scriptChild.speed) {
						scriptChild.job = "Warrior";
						scriptChild.myRend.material = scriptChild.Character6;
						scriptChild.tag = "Character6";
					}
				}

				//-----------------------------------------------Mutation--------------------------------------------------

				if (Random.value < 0.10f) {
					if (scriptChild.job == "Drone") {
						scriptChild.backpack = Random.Range (7, 10);
						scriptChild.speed = Random.Range (1, 4);
						scriptChild.strength = 0;
					}
					if (scriptChild.job == "Flash") {
						scriptChild.backpack = Random.Range (1, 4);
						scriptChild.speed = Random.Range (7, 10);
						scriptChild.strength = 0;
					}
					if (scriptChild.job == "Warrior") {
						scriptChild.backpack = 0;
						scriptChild.speed = Random.Range (1, 4);
						scriptChild.strength = Random.Range (7, 10);
					}
				} else if (Random.value >= 0.10f && Random.value <= 0.70f) {
					int dice = Random.Range (1, 3);
					int dice2 = Random.Range (1, 2);
					if (dice == 1) {
						if (dice2 == 1) {
							scriptChild.backpack += 1;
						}
						if (dice2 == 2) {
							scriptChild.backpack -= 1;
							if (scriptChild.backpack == 0) {
								scriptChild.backpack = 1;
							}
						}
					}
					if (dice == 2) {
						if (dice2 == 1) {
							scriptChild.speed += 1;
						}
						if (dice2 == 2) {
							scriptChild.speed -= 1;
							if (scriptChild.speed == 0) {
								scriptChild.speed = 1;
							}
						}
					}
					if (dice == 3) {
						if (dice2 == 1) {
							scriptChild.strength += 1;
						}
						if (dice2 == 2) {
							scriptChild.strength -= 1;
							if (scriptChild.strength == 0) {
								scriptChild.strength = 1;
							}
						}
					}
				} else {
					//no mutation occurs
				}
				//Debug.Log (scriptChild.backpack);
				//next depending on greatest stat assign material and job
				//add mutation where random stat goes up or down 1
				//percent of nothing happenening
				//small percent of entirely random stats and different child
				childPlayer.GetComponent<Player> ().isMale = scriptChild.isMale;
				childPlayer.GetComponent<Player> ().backpack = scriptChild.backpack;
				childPlayer.GetComponent<Player> ().speed = scriptChild.speed;
				childPlayer.GetComponent<Player> ().strength = scriptChild.strength;
				childPlayer.GetComponent<Player> ().health = scriptChild.health;
				childPlayer.GetComponent<Player> ().canFight = scriptChild.canFight;
				childPlayer.GetComponent<Player> ().canGather = scriptChild.canGather;
				childPlayer.GetComponent<Player> ().canMate = scriptChild.canMate;
				childPlayer.GetComponent<Player> ().isFull = scriptChild.isFull;
				childPlayer.GetComponent<Player> ().job = scriptChild.job;
				childPlayer.GetComponent<Player> ().myRend.material = scriptChild.myRend.sharedMaterial;

				GameObject matePlayer = Instantiate (childPlayer, matingArea.transform.position, matingArea.transform.rotation) as GameObject;
				matePlayer.transform.parent = childrenParentGameObject.transform;
				//Debug.Log (scriptChild.backpack);
			} 
	
		}
	}


}
