using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioControl : MonoBehaviour {
	// 내 객체 안에 audiosource가 포함
	// 내 객체 안의 클래스(컴포넌트) Load => GetComponent<>()

	AudioSource my_music;

	// Use this for initialization
	void Start () {
		my_music = this.GetComponent<AudioSource> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (!my_music.isPlaying) {
			my_music.Play ();
		}
	}
}
