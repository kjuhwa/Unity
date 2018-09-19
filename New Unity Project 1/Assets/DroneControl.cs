using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DroneControl : MonoBehaviour {

	/*
	// Use this for initialization
	void Start () {
		Debug.Log ("Show me the money");
		print ("power is money");
		print (111 + "222" + 333 + "444");
		Vector2 aa = new Vector2(); // 좌표
		Vector3 bb = new Vector3();
		Vector4 cc = new Vector4 ();

		print (aa.x);
		print (bb);
		print (cc);
		// unity 3# 에서 값을 개별로 얻는 건 가능
		aa.x = 33.0f;
		aa.y = 33.0f;
		print (aa);

		print (this.transform.position);
		this.transform.position = new Vector3 (-7.7f, 1, 1);
	}
	*/
	
	// Update is called once per frame
	void Update () {
		float keydir_x, keydir_z;
		keydir_x = Input.GetAxis("Horizontal");
		keydir_z = Input.GetAxis("Vertical");

		this.transform.Translate (new Vector3(keydir_x,0,keydir_z)*10f*Time.deltaTime); 	// move
		//this.transform.Rotate()  ;  	// rotate
		//this.transform.localScale();	// scale
	}
}
