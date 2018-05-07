using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;


public class Enemy : MonoBehaviour {

	private NavMeshAgent nmAgent;
	public GameObject matingArea;

	public float health;
	public float hp;
	public int speed;
	public int strength;

	public bool hasCollided;

	public Image healthBar;
	// Use this for initialization
	void Start () {
		
	
		if (this.gameObject.name == "Berg") {
			health = 10;
			speed = 3;
			strength = 30;
		}
		if (this.gameObject.name == "Bergling") {
			health = 5;
			speed = 5;
			strength = 10;
		}
		hasCollided = false;
		hp = health;
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate (Vector2.left * speed * Time.deltaTime);
		if (health <= 0) {
			Destroy (this.gameObject);
		}
		healthBar.fillAmount = health / hp;
	}

	IEnumerator OnTriggerStay(Collider col){
		if (col.gameObject.tag == "Character1" || col.gameObject.tag == "Character2" || col.gameObject.tag == "Character3" || col.gameObject.tag == "Character4" || col.gameObject.tag == "Character5" || col.gameObject.tag == "Character6") {
			if (hasCollided == false) {
			health -= col.gameObject.GetComponent<Player> ().strength;
				hasCollided = true;
				yield return new WaitForSeconds (1);
				hasCollided = false;
			//Debug.Log (health);
			//Debug.Log (hp);
			//Debug.Log (health/ hp);
			}

			//Debug.Log (healthBar.fillAmount);

		}
		if (col.gameObject.tag == "MatingArea") {
			Destroy (this.gameObject);
		}
	}


}