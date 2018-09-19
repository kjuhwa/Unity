using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball_Control : MonoBehaviour {

	Rigidbody rig;

	public void preeBtn (){
	}

	public void upBtn (){
		rig.AddForce (Vector3.up * 2000f);
		rig.AddForce (Vector3.forward * 2000f);
	}

	// Use this for initialization
	void Start () {
		rig = this.GetComponent<Rigidbody> ();
	}
	
	// Update is called once per frame
	void Update () {
	}

	void OnCollisionEnter(Collision other){
		if (other.gameObject.name == "deathzone") {
			rig.velocity = Vector3.zero;
			rig.angularVelocity = Vector3.zero;
			this.transform.localPosition = new Vector3(0, 1.5f, -5f);
		}
	}
}
