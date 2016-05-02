using UnityEngine;
using System.Collections;

public class ComputerController : MonoBehaviour {
	[SerializeField] GameObject useText;
	[SerializeField] Collider activeZone;

	public void ActivateUseText (bool state) {
		useText.SetActive(state);
	}
}
