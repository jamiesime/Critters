using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

	public static Player control;

	public GameObject PlayerObject;

	public NetType equipped;

	public int health;

	// Use this for initialization
	void Start () {
		equipped = NetType.Normal;
		control = this;
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
		return this.equipped.ToString();
	}




}
