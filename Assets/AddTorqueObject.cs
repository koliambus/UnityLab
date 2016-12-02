using UnityEngine;
using System.Collections;

public class AddTorqueObject : MonoBehaviour {

	private Rigidbody rigitbody;
	float amount = 50f;

	void Start (){
		rigitbody = GetComponent<Rigidbody> ();
	}

	void FixedUpdate () {
		float h = Input.GetAxis ("Horizontal") * amount * Time.deltaTime;
		float v = Input.GetAxis ("Vertical") * amount * Time.deltaTime;

		rigitbody.AddTorque (transform.up * h);
		rigitbody.AddTorque (transform.right * v);
	}
}
