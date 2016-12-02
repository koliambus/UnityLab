using UnityEngine;
using System.Collections;

public class CollisionsDetecting : MonoBehaviour {

	void OnCollisionEnter (Collision other) {
		Debug.Log ("OnCollisionEnter");
	}

	void OnCollisionStay (Collision other) {
		Debug.Log ("OnCollisionStay");
	}

	void OnCollisionExit (Collision other) {
		Debug.Log ("OnCollisioneExit");
	}
}
