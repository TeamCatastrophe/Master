using UnityEngine;
using System.Collections;

public class kickScript : MonoBehaviour {

	public Transform leg;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
	if (Input.GetKeyDown (KeyCode.Mouse1)) {
			StartCoroutine(Kick ());
			leg.GetComponent<SpriteRenderer>().enabled = true;
			leg.GetComponent<BoxCollider2D>().enabled = true;
		}
	}

	IEnumerator Kick(){
		yield return new WaitForSeconds (0.1f);
		leg.GetComponent<SpriteRenderer>().enabled = false;
		leg.GetComponent<BoxCollider2D>().enabled = false;
	}
}
