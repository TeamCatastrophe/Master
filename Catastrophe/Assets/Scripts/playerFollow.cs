using UnityEngine;
using System.Collections;

public class playerFollow : MonoBehaviour {

	public Transform target;
	public float smoothTime = 0.3f;
	
	private Vector3 velocity = Vector3.zero;
	
	void Update () {
		Vector3 goalPos = target.position;
		transform.position = Vector3.SmoothDamp (new Vector3(transform.position.x, transform.position.y, -10), goalPos, ref velocity, smoothTime);
	}
}
