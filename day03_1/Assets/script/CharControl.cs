using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharControl : MonoBehaviour {

	float movrate, rotrate;
	float xdir, zdir;

	// Use this for initialization
	void Start () {
		movrate = 1;
		rotrate = 90;	
	}
	
	// Update is called once per frame
	void Update () {
		xdir = Input.GetAxis("Horizontal");
		zdir = Input.GetAxis("Vertical");
		this.transform.Translate (Vector3.forward * movrate * Time.deltaTime * zdir);
		this.transform.Rotate (Vector3.up * rotrate * Time.deltaTime * xdir);
	}
}
