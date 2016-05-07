using UnityEngine;
using System.Collections;

public class InteractionController : MonoBehaviour {
	[SerializeField] StateController stateController;
	[SerializeField] InteractionTrigger interactionTrigger;
	[SerializeField] CameraController cameraController;
	[SerializeField] ComputerController computerController;

	public void Use () {
		// if currently using computer
		if (stateController.activeComputer != null) {
			StopUseComputer(stateController.activeComputer);
			return;
		}

		GameObject target = interactionTrigger.GetTarget();
		if (target != null) {
			if (target.CompareTag("Computer")) {
				UseComputer(target);
			}
		}
	}

	public void Click () {
		// // if currently using computer
		// if (stateController.activeComputer != null) {
		// 	activeComputer.Click();
		// 	return;
		// }
		//
		// GameObject target = interactionTrigger.GetTarget();
		// if (target != null) {
		// 	if (target.CompareTag("Computer")) {
		// 		UseComputer(target);
		// 	}
		// }
		// print("click!");
	}

	public void DoubleClick () {
		print("double click!");
	}

	public void UseComputer (GameObject computer) {
		computerController = computer.GetComponent<ComputerController>();

		if (!computerController.inZone) {
			return;
		}

		stateController.CanMove(false);
		stateController.SetActiveComputer(computer, true);
		cameraController.SetCamera(computerController.computerCamera, true);
		computerController.Use();
	}

	public void StopUseComputer (GameObject computer) {
		stateController.CanMove(true);
		stateController.SetActiveComputer(computer, false);
		cameraController.SetCamera(computerController.computerCamera, false);
		computerController.StopUse();
		computerController = null;
	}
}
