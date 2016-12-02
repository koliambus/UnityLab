using UnityEngine;
using System.Collections;

public class TriggerDetections : MonoBehaviour {

	void OnTriggerEnter (Collider other) {
		Debug.Log ("OnTriggerEnter");
	}

	void OnTriggerStay (Collider other) {
		Debug.Log ("OnTriggerStay");
	}

	void OnTriggerExit (Collider other) {
		Debug.Log ("OnTriggerExit");
	}
}
