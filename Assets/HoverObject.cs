using UnityEngine;
using System.Collections;

public class HoverObject : MonoBehaviour {
	float hoverPower = 20f;

	void OnTriggerStay (Collider other) {
		other.attachedRigidbody.AddForce (transform.up * hoverPower, ForceMode.Force);
	}
}
