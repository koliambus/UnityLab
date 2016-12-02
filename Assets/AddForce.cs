using UnityEngine;
using System.Collections;

public class AddForce : MonoBehaviour {
	
	public Rigidbody rigitbody;

	void OnMouseDown (){
		rigitbody.AddForce (-transform.forward * 500, ForceMode.Acceleration);
		rigitbody.AddTorque (transform.up * 500);
		rigitbody.useGravity = true;
	}
}
