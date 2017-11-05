using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trap : MonoBehaviour {

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
      Destroy(this.gameObject, 1.0f);
    }
  }

  public void activate(GameObject critter){
      print("Collision detected");
      sr.sortingLayerName = "Airborne";
      sr.sprite = netSprite;
      triggered = true;
      critter.GetComponent<Critter>().caught = true;
      Destroy(critter, 1.0f);
  }

}
