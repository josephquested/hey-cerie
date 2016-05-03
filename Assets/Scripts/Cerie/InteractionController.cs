using UnityEngine;
using System.Collections;

public class InteractionController : MonoBehaviour {
	[SerializeField] StateController stateController;
	[SerializeField] InteractionTrigger interactionTrigger;
	[SerializeField] CameraController cameraController;

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

	public void UseComputer (GameObject computer) {
		ComputerController computerController = computer.GetComponent<ComputerController>();

		if (!computerController.inZone) {
			return;
		}

		stateController.CanMove(false);
		stateController.SetActiveComputer(computer, true);
		cameraController.SetCamera(computerController.camera, true);
		computerController.Use();
	}

	public void StopUseComputer (GameObject computer) {
		ComputerController computerController = computer.GetComponent<ComputerController>();

		stateController.CanMove(true);
		stateController.SetActiveComputer(computer, false);
		cameraController.SetCamera(computerController.camera, false);
		computerController.StopUse();
	}
}
