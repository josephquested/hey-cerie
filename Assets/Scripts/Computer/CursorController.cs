using UnityEngine;
using System.Collections;

public class CursorController : MonoBehaviour {
	[SerializeField] ComputerController computerController;
	[SerializeField] float speed = 1.0f;
	[SerializeField] Vector3 lastPosition;

  void Update () {
		RememberLastPosition();
		ControlMouseMovement();
  }

	void ControlMouseMovement () {
		if (computerController.inUse) {
			transform.Translate(new Vector3(Input.GetAxis("Mouse X"), Input.GetAxis("Mouse Y"), 0) * Time.deltaTime * speed);
		}
	}

	void RememberLastPosition () {
		lastPosition = transform.localPosition;
	}

	void OnTriggerExit (Collider collider) {
		print(collider);
		if (collider.CompareTag("Desktop")) {
			transform.localPosition = lastPosition;
			print("edge!");
		}
	}
}
