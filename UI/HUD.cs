using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HUD : MonoBehaviour {

	public Text healthDisplay;
	public Text equipDisplay;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		healthDisplay.text = ("HP: " + Player.control.getHealth());
		equipDisplay.text = ("TOOL: " + Player.control.getEquipped());
	}
}
