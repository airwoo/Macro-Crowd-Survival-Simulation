using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Child : MonoBehaviour {

	public GameObject player;

	public bool isMale;
	public string job;
	public int backpack;
	public int speed;
	public int strength;
	public int health = 50;


	public Material Character1;

	public Material Character2;

	public Material Character3;

	public Material Character4;

	public Material Character5;

	public Material Character6;

	public Material selectedPlayer;
	public MeshRenderer myRend;
	public bool currentlySelected = false;

	public bool canGather;
	public bool canFight;
	public bool canMate;

	public int currentFoodHold;
	public int currentMineralHold;



	// Use this for initialization


	// Update is called once per frame
	void Update () {
	}


}
