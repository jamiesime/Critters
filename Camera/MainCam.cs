using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainCam : MonoBehaviour {

	public GameObject target;

	public Vector3 offset;

	// Use this for initialization
	void Start () {
		offset = transform.position - target.transform.position;
	}
	
	// Update is called once per frame
	void LateUpdate () {
		updatePosition();
	}

	public void updatePosition(){
		this.transform.position = target.transform.position + offset;
	}
}
