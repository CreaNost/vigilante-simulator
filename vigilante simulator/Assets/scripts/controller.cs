using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class controller : MonoBehaviour {

	public float moveSpeed = 6;
	public float smoothInputMagnitude;
	public float smoothMoveTime = .1f;
	float smoothMoveVelocity;
	public float turnSpeed = 8;
	float angle;
	public Rigidbody rb;
	Vector3 velocity;
	float x = 0;
	bool powerActive;

	public void Start() {
		rb = GetComponent<Rigidbody>();
	}


	void Update() {
		//walking with wasd keys
		Vector3 inputDirection = new Vector3(Input.GetAxisRaw("Horizontal"), 0, Input.GetAxisRaw("Vertical")).normalized;
		float inputMagnitude = inputDirection.magnitude;
		smoothInputMagnitude = Mathf.SmoothDamp(smoothInputMagnitude, inputMagnitude, ref smoothMoveVelocity, smoothMoveTime);
		float targetAngle = Mathf.Atan2(inputDirection.x, inputDirection.z) * Mathf.Rad2Deg;
		angle = Mathf.LerpAngle(angle, targetAngle, Time.deltaTime * turnSpeed * inputMagnitude);
		velocity = transform.forward * moveSpeed * smoothInputMagnitude;
		if (Input.anyKeyDown) {
			x = 1;
		}
	}

	void FixedUpdate() {
		if (x == 1) {
			rb.MoveRotation(Quaternion.Euler(Vector3.up * angle));
			rb.MovePosition(rb.position + velocity * Time.deltaTime);
		}
	}
}
