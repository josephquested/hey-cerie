using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour {

	public void SetPosition (Transform cameraTransform) {
		transform.position = cameraTransform.position;
	}
}
