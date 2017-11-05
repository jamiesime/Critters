using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SleepTrap : MonoBehaviour {

	public GameObject sleepParticle;

	public Sprite netSprite;
	public SpriteRenderer sr;

	public bool triggered;

	public void OnTriggerEnter2D(Collider2D other){
		if (other.gameObject.tag == "Critter"){
			print ("Collision detected");
			activate(other.gameObject);
		}
	}

	public void Update(){
		if (triggered){
			SpriteEffects.control.fadeOutSprite(sr);
			Destroy(this.gameObject, 2.0f);
		}
	}

		public void activate(GameObject critter){
				print("Sleep Collision detected");
				GameObject effect = (GameObject)Instantiate(sleepParticle, getPosition(), getRotation());
				triggered = true;
				critter.GetComponent<Critter>().sleep = true;
				Destroy(effect, 3.0f);
		}

		public Vector3 getPosition(){
			return this.transform.position;
		}

		public Quaternion getRotation(){
			return this.transform.rotation;
		}


}
