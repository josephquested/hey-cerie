using UnityEngine;
using System.Collections;

public class ActiveZone : MonoBehaviour {
	[SerializeField] ComputerController computerController;

	void OnTriggerEnter (Collider collider) {
		if (collider.CompareTag("Cerie")) {
			computerController.ToggleActiveZone(true);
		}
	}

	void OnTriggerExit (Collider collider) {
		if (collider.CompareTag("Cerie")) {
			computerController.ToggleActiveZone(false);
		}
	}
}
