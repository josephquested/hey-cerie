using UnityEngine;
using System.Collections;

public class InputController : MonoBehaviour {
	[SerializeField] InteractionController interactionController;
	[SerializeField] StateController stateController;

	float lastClickTime;
	float catchTime = 0.25f;

	void Update () {
		ControlClicks();

		if (Input.GetAxis("Horizontal") != 0 || Input.GetAxis("Vertical") != 0) {
				stateController.IsMoving(true);
			} else {
				stateController.IsMoving(false);
			}

		if (Input.GetKeyDown("e")) {
			interactionController.Use();
		}
	}

	void ControlClicks () {
	  if (Input.GetButtonDown("Fire1")) {
      if (Time.time - lastClickTime < catchTime) {
				interactionController.DoubleClick();
      } else {
				interactionController.Click();
      }
    lastClickTime = Time.time;
	  }
	}
}
