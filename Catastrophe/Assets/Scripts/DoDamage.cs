using UnityEngine;
using System.Collections;

public class DoDamage : MonoBehaviour {

	void OnCollisionEnter2D(Collision2D other){
		if (other.collider.tag == "cat") {
			other.transform.SendMessage ("ApplyDamage", 5, SendMessageOptions.DontRequireReceiver);
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}