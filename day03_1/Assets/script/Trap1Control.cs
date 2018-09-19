using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trap1Control : MonoBehaviour {

	public GameObject obj_stone;
	Rigidbody rig;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter(Collider outer){ // 나랑 충돌한 상대방 정보
		if (outer.gameObject.name == "player") {
			// 1. obj_stone.GetComponent<Rigidbody> ().useGravity = true;
			rig = obj_stone.GetComponent<Rigidbody> ();
			rig.useGravity = true;
		}
	}
}
