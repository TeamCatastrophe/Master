using UnityEngine;
using System.Collections;

public class HealthCat : MonoBehaviour {

	private int health = 10;
	public GameObject player;

	void Start(){
		player = GameObject.FindGameObjectWithTag ("Player");
	}

	void ApplyDamage(int damage){
		health -= damage;
	}
	
	// Update is called once per frame
	void Update () {
	if (health <= 0) {
			Die ();
		}
	}

	void Die(){
		Destroy (this.gameObject);
		XP.realXP += 100;
		player.GetComponent<XP> ().CurrentXP -= 100;

	}
}
