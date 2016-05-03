using UnityEngine;
using System.Collections;

public class StateController : MonoBehaviour {
	[SerializeField] Rigidbody rb;
	public GameObject activeComputer;
	public bool canMove;
	public bool isMoving;

	public void SetActiveComputer (GameObject computer, bool active) {
		if (active) {
			activeComputer = computer;
		} else {
			activeComputer = null;
		}
	}

	public void IsMoving (bool state) {
		isMoving = state;
	}

	public void CanMove (bool state) {
 		canMove = state;
	}
}
