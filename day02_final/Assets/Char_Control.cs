using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Char_Control : MonoBehaviour {

	float movrate, rotrate;
	float xdir, zdir;

	// Use this for initialization
	void Start () {
		movrate = 2;
		rotrate = 100;
	}
	
	// Update is called once per frame
	void Update () {
		this.transform.Translate (Vector3.forward * movrate * Time.deltaTime * zdir);
		this.transform.Rotate (Vector3.up * rotrate * Time.deltaTime * xdir);
	}

	public void c_foward() {
		zdir = 1;
	}

	public void c_back() {
		zdir = -1;
	}

	public void c_left() {
		xdir = -1;
	}

	public void c_right() {
		xdir = 1;
	}

	public void c_zero() {
		zdir = xdir = 0;
	}

	void OnCollisionEnter(Collision other){
		print ("물리적 충돌");
	}

	void OnTriggerEnter(Collider outer){
		print ("개념적 충돌");
	}
}

// Enter stay exit
// OnCollistion
// OnTrigger

// Collider + Collider = OnCollistion
// as = OnTrigger