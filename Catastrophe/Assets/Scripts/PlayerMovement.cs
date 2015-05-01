using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {

	public float playerSpeed = 1;
	public Transform player;
	public Transform camera;
	// Use this for initialization
	void Start () {
		//player = GameObject.FindGameObjectWithTag ("Player").transform;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.W)) {
			player.position += new Vector3 (0, playerSpeed, 0);
			//camera.position += new Vector3 (0, playerSpeed, 0);

		} else if (Input.GetKey (KeyCode.S)) {
			player.position += new Vector3 (0, -playerSpeed, 0);	
			//camera.position += new Vector3 (0, -playerSpeed, 0);			

		}else if (Input.GetKey (KeyCode.A)) {
			player.position += new Vector3(-playerSpeed, 0, 0);
			//camera.position += new Vector3(-playerSpeed, 0, 0);

		}else if (Input.GetKey (KeyCode.D)) {
			player.position += new Vector3(playerSpeed, 0, 0);
			//camera.position += new Vector3(playerSpeed, 0, 0);

		} else {
			player.position += new Vector3(0, 0, 0);		
		}
	}
}
