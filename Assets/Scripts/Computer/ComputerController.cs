using UnityEngine;
using System.Collections;

public class ComputerController : MonoBehaviour {
	[SerializeField] Collider activeZone;
	[SerializeField] GameObject useText;

	public Camera camera;
	public bool inZone;
	[SerializeField] bool inTrigger;
	[SerializeField] bool inUse;

	void Update () {
		ControlUseText();
	}

	public void Use () {
		inUse = true;
	}

	public void StopUse () {
		inUse = false;
	}

	void ControlUseText () {
		if (inTrigger && inZone && !inUse) {
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
