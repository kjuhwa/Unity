using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trap2Control : MonoBehaviour {

	public GameObject obj_break;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter(Collider outer){
		if (outer.gameObject.name == "player") {
			obj_break.SetActive (false);
		}
	}
}
