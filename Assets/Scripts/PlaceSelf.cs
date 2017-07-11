using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaceSelf : MonoBehaviour {

	void Start () {
		RaycastHit hit;
		Vector3 down = new Vector3(0, -1, 0);
		if (Physics.Raycast(this.transform.position, down, out hit)) {
			float distanceToGround = hit.distance;
			this.transform.position = new Vector3(transform.position.x, transform.position.y - distanceToGround, transform.position.z);

			Debug.Log(this.transform.position);
		}
	}
}
