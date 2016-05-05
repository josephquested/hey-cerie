using UnityEngine;
using System.Collections;

public class CursorController : MonoBehaviour {
	[SerializeField] ComputerController computerController;
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

	void OnTriggerStay (Collider collider) {
		if (collider.CompareTag("Folder")) {
			print(collider.gameObject);
		}
	}
}
