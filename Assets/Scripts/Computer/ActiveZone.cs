using UnityEngine;
using System.Collections;

public class ActiveZone : MonoBehaviour {
	public bool active;

	void OnTriggerEnter (Collider collider) {
		if (collider.CompareTag("Sharon")) {
			active = true;
		}
	}

	void OnTriggerExit (Collider collider) {
		if (collider.CompareTag("Sharon")) {
			active = false;
		}
	}
}
