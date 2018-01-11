using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorOpener : MonoBehaviour {

	public Transform door;												// allows us to assign an object in Unity UI to transform

	private Vector3 closedPosition = new Vector3(0f, 0.84f, 5f);		// assigns var for closed position. this is the current position of the door... 
																		// ... this makes it possible to close door afer the ball moves through. 
	private Vector3 openedPosition = new Vector3(0f, 1.5f, 5f); 			// assigns var for open position	

	public float openSpeed = 5;											// assigns var for open speed
	
	private bool open = false;											// assign logic for bool. It stats as closed. 


	// Update is called once per frame
	void Update () {
		if (open) {														// a lerp moves the door between two vector.s 
			door.position = Vector3.Lerp(door.position, 				// vector a = doors current position vector b, open positio, TIME
				openedPosition, Time.deltaTime * openSpeed);
		} else {
			door.position = Vector3.Lerp(door.position, 
				closedPosition, Time.deltaTime * openSpeed);
		}	
	}

	private void OnTriggerEnter(Collider other)	{						// if the "Player" enters the radius of the circle then openDoor()
		if (other.tag == "Player") {
			OpenDoor();
		}
	}		

	private void OnTriggerExit(Collider other) {						// when Player exits, closeDoor()
		if (other.tag == "Player") {
			CloseDoor();
		}
	}

	public void CloseDoor() {											
		open = false;
	}

	public void OpenDoor() {
		open = true;
	}
}
