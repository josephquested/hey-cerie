using UnityEngine;
using System.Collections;

public class ComputerController : MonoBehaviour {
	[SerializeField] GameObject useText;
	[SerializeField] Collider activeZone;

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

	public void ToggleInteractionTrigger (bool state) {
		inTrigger = state;
	}

	public void ToggleActiveZone (bool state) {
		inZone = state;
	}
}
