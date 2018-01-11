using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	public float speed = 7;													// 5) sets a adjustable speed in unity ui
	private Rigidbody rb;													// 6) allows us to assign a rb in unity ui

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody>();	 									//calls the rigid body on start
	}
	
	// Update is called once per frame
	void FixedUpdate () { 													// 1) fixed because were using physics
		float moveHorizontal = Input.GetAxis("Horizontal"); 				// 2) records input
		float moveVertical = Input.GetAxis("Vertical");

		Vector3 movement = new Vector3(moveHorizontal, 0, moveVertical);	// 3) change to a movement vector
		
		rb.AddForce(movement * speed); 										// 4) apply force

	}
}