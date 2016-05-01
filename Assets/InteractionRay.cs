using UnityEngine;
using System.Collections;

public class InteractionRay : MonoBehaviour {
[SerializeField] private int rayDistance;

void Update () {
	Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
	RaycastHit hit;
		if (Physics.Raycast(ray, out hit, rayDistance)) {
			if(hit.collider.gameObject && hit.collider != null) {
			print(hit.collider.gameObject);
			}
		}
	}
}
