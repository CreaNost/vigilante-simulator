using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pupil : MonoBehaviour {

	public Transform target;

	void Update () {
		/*Vector3 currentPosition = transform.position;
		currentPosition.x = Mathf.Clamp(currentPosition.x, -.4f, .4f);
		currentPosition.y = Mathf.Clamp(currentPosition.y, -.4f, .4f);
		currentPosition.z = Mathf.Clamp(currentPosition.x, currentPosition.y, currentPosition.z);
		transform.position = currentPosition;
		transform.position = Input.mousePosition;
		float distance = Camera.main.ScreenToWorldPoint(gameObject.transform.position).z;
		transform.position = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, distance));*/
	}
}
