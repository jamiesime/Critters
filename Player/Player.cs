using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

	public static Player control;

	public GameObject PlayerObject;

	public enum Direction {North, South, East, West};

	public Direction dir;

	public NetType equipped;

	// Use this for initialization
	void Start () {
		equipped = NetType.Normal;
		control = this;
	}
	
	// Update is called once per frame
	void Update () {

	}


	//ALL PLAYER ACTIONS BELOW, CALLED IN SUBCLASSES

	public Vector3 getCurrentPosition(){
		return this.transform.position;
	}

	public Quaternion getCurrentRotation(){
		return this.transform.rotation;
	}



}
