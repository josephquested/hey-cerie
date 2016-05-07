using UnityEngine;
using System.Collections;

public class FolderController : MonoBehaviour {
	[SerializeField] SpriteRenderer selectorSprite;
	[SerializeField] GameObject desktop;
	[SerializeField] GameObject window;
	[SerializeField] bool selected;

	public void Click () {
		ToggleSelected();
	}

	public void DoubleClick () {
		OpenWindow();
	}

	void OpenWindow () {
		GameObject windowObject = Instantiate(window) as GameObject;
	  windowObject.transform.parent = desktop.transform;
		windowObject.transform.localPosition = Vector3.zero;
		windowObject.transform.localScale = new Vector3(1, 1, 1);
		windowObject.transform.localRotation = Quaternion.Euler(0, 180, 0);
 	}

	void ToggleSelected () {
		if (selected) {
			selectorSprite.enabled = false;
			selected = false;
		} else {
			selectorSprite.enabled = true;
			selected = true;
		}
	}
}
