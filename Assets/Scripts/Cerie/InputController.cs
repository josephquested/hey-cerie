using UnityEngine;
using System.Collections;

public class InputController : MonoBehaviour {
	[SerializeField] InteractionController interactionController;
	[SerializeField] StateController stateController;

	void Update () {
		if (Input.GetAxis("Horizontal") != 0 || Input.GetAxis("Vertical") != 0) {
				stateController.IsMoving(true);
			} else {
				stateController.IsMoving(false);
			}

		if (Input.GetKeyDown("e")) {
			interactionController.Use();
		}
	}
}
