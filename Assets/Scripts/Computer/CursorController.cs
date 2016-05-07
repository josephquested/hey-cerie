using UnityEngine;
using System.Collections;

public class CursorController : MonoBehaviour {
	[SerializeField] ComputerController computerController;
	[SerializeField] GameObject activeFolder;
	[SerializeField] float speed = 1.0f;
	[SerializeField] bool canMove;

  void Update () {
		ControlMouseMovement();
  }

	void ControlMouseMovement () {
		if (computerController.inUse && canMove) {
			transform.Translate(new Vector3(Input.GetAxis("Mouse X"), Input.GetAxis("Mouse Y"), 0) * Time.deltaTime * speed);
		}
	}

	void OnTriggerEnter (Collider collider) {
		if (collider.CompareTag("Folder")) {
			activeFolder = collider.gameObject;
		}
	}

	void OnTriggerExit (Collider collider) {
		if (collider.CompareTag("Folder")) {
			activeFolder = null;
		}
	}
}
