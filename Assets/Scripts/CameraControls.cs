using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControls : MonoBehaviour {

	public float scrollVelocity = 4f;

	void Update() {
		float scrollDirection = Input.GetAxis("Mouse ScrollWheel");
		if (scrollDirection != 0f) {
			Camera.main.orthographicSize -= scrollDirection * scrollVelocity;
		}
	}
}
