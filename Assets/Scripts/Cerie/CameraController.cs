using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour {
	[SerializeField] Camera mainCamera;

	public void SetCamera (Camera newCamera, bool active) {
		if (active) {
			newCamera.enabled = true;
			mainCamera.enabled = false;
		} else {
			newCamera.enabled = false;
			mainCamera.enabled = true;
		}
	}
}
