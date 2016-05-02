using UnityEngine;
using System.Collections;

public class InteractionTrigger : MonoBehaviour {
	public GameObject target;

	void OnTriggerEnter (Collider collider) {
		if (collider.CompareTag("Computer")) {
			collider.SendMessageUpwards("ActivateUseText", true);
			target = collider.gameObject;
		}
	}

	void OnTriggerExit (Collider collider) {
		if (collider.CompareTag("Computer")) {
			collider.SendMessageUpwards("ActivateUseText", false);
			target = null;
		}
	}

	public GameObject GetTarget () {
		if (target != null) {
			return target;
		} else {
			return null;
		}
	}
}
