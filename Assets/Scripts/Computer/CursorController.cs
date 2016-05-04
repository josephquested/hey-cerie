using UnityEngine;
using System.Collections;

public class CursorController : MonoBehaviour {
	[SerializeField] ComputerController computerController;
	[SerializeField] float speed = 1.0f;
	[SerializeField] Vector3 lastPosition;
	[SerializeField] bool canMove;

  void Update () {
		RememberLastPosition();
		ControlMouseMovement();
  }

	void ControlMouseMovement () {
		if (computerController.inUse && canMove) {
			transform.Translate(new Vector3(Input.GetAxis("Mouse X"), Input.GetAxis("Mouse Y"), 0) * Time.deltaTime * speed);
		}
	}

	void RememberLastPosition () {
		lastPosition = transform.localPosition;
	}

	void OnTriggerStay (Collider collider) {
		if (collider.CompareTag("Edge")) {
			print("enter edge!");
			canMove = false;
			transform.localPosition = lastPosition;
		}
	}

	void OnTriggerExit (Collider collider) {
		if (collider.CompareTag("Edge")) {
			print("edge exit!");
			canMove = true;
		}
	}
}
