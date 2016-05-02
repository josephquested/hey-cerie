using UnityEngine;
using System.Collections;

public class InputController : MonoBehaviour {
	[SerializeField] InteractionTrigger interactionTrigger;
	[SerializeField] InteractionController interactionController;

	void Update () {
		if (Input.GetKeyDown("e")) {
			GameObject target = interactionTrigger.GetTarget();
			if (target.CompareTag("Computer")) {
				interactionController.UseComputer(target);
			}
		}
	}
}
