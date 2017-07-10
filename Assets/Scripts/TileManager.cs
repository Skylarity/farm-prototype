using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileManager : MonoBehaviour {

	public Transform cube;
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown(0)) {
			RaycastHit hit;
			Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

			if (Physics.Raycast(ray, out hit)) {
				if (hit.collider.tag == "Ground") {
					float offset = 1000f;
					Vector3 position = new Vector3(Mathf.Floor(hit.point.x + 0.5f), offset, Mathf.Floor(hit.point.z + 0.5f));
					Instantiate(cube, position, Quaternion.identity);
				} else {
					Destroy(hit.transform.gameObject);
				}
			}
		}
	}
}
