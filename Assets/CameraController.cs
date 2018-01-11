using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

	public Transform target;

	public float lerpSpeed = 5;

	public float zOffset = -19;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void LateUpdate () {										//a follow camera should always be implemented in LateUpdate because it tracks objects that might have moved inside Update.
		var currentPosition = transform.position;				// this is not a global variable. 
		var targetPosition = new Vector3(target.position.x, currentPosition.y, target.position.z + zOffset); //follows the target but ignores the z
		transform.position = Vector3.Lerp(currentPosition, targetPosition, Time.deltaTime * lerpSpeed);
	}
}
