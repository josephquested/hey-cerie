using UnityEngine;
using System.Collections;

public class ComputerController : MonoBehaviour {
	public Transform cameraTransform;
	[SerializeField] Collider activeZone;
	[SerializeField] GameObject useText;
	[SerializeField] bool inTrigger;
	[SerializeField] bool inZone;

	void Update () {
		ControlUseText();
	}

	void ControlUseText () {
		if (inTrigger && inZone) {
			useText.SetActive(true);
		} else {
			useText.SetActive(false);
		}
	}

	public void Use () {
		print("use!");
	}

	public void ToggleInteractionTrigger (bool state) {
		inTrigger = state;
	}

	public void ToggleActiveZone (bool state) {
		inZone = state;
	}
}
