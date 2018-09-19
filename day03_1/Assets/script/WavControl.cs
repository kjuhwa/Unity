using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WavControl : MonoBehaviour {

	AudioSource my_wav;

	// Use this for initialization
	void Start () {
		my_wav = this.GetComponent<AudioSource> ();
	}

	// Update is called once per frame
	void Update () {
		//if (Input.GetKeyDown (KeyCode.Space)) {
		if (Input.GetMouseButtonDown(0)) {
			my_wav.Play ();
		}
	}
}
