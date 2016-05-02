using UnityEngine;
using System.Collections;

public class InputController : MonoBehaviour {
	[SerializeField] InteractionTrigger interactionTrigger;

	void Update () {
		if (Input.GetKeyDown("e")) {
			GameObject target = interactionTrigger.GetTarget();
			if (target != null) {
				print(target);
				// target.Use();
			}
		}
	}
}
