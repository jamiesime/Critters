using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

	public static Player control;

	public SpriteRenderer playerModel;

	public List<GameObject> equipment;
	public GameObject equipped;

	public int health;
	public bool hasDied;
	public bool invincible;

	// Use this for initialization
	void Start () {
		control = this;
		Equipment.control.populateEquipment(equipment);
	}

	// Update is called once per frame
	void Update () {

	}
	public Vector3 getCurrentPosition(){
		return this.transform.position;
	}

	public Quaternion getCurrentRotation(){
		return this.transform.rotation;
	}

	public string getHealth(){
		return this.health.ToString();
	}

	public string getEquipped(){
		return this.equipped.name;
	}

	public bool checkHealth(){
		if (health < 1){
			return hasDied = true;
		}
		StartCoroutine(recoveryState());
		return hasDied = false;
	}

	public IEnumerator recoveryState(){
		invincible = true;
		playerModel.color = new Color (1f, 1f, 1f, 0.5f);
		yield return new WaitForSeconds(2.0f);
		invincible = false;
		playerModel.color = new Color (1f, 1f, 1f, 1f);
	}



}
