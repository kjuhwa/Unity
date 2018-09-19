using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Box_Control : MonoBehaviour {
	public float movrate = 5;
	float xdir = 0;
	float zdir = 0;

	void Awake() {
		// 객체 생성후
		// 멤버 초기화, 변수 세팅
		print("출력0");
	}
	// Use this for initialization
	void Start () { // 1st calling but instant;	
		// 객체 생성후 랜더링 전
		// 멤버 초기화, 변수 세팅
		print("출력1");
	}
	
	// Update is called once per frame
	void Update () {
		// 일반적인 객체 제어로직이 있는 곳
		print("출력2");
		xdir = Input.GetAxis ("Horizontal");
		zdir = Input.GetAxis ("Vertical");
		//this.transform.Translate (0,0,1);
		//this.transform.Translate (new Vector3 (1, 0, 0));
		// 초당 이동 거리
		// 공식
		// 이동 수치 * 매 프레임당 걸리는 시간 => 매 프레임별로 적용
		//this.transform.Translate (0,0,movrate * Time.deltaTime);
		//this.transform.Translate (new Vector3 (movrate * Time.deltaTime, 0, 0));
		//this.transform.Translate (Vector3.right * movrate * Time.deltaTime * xdir);
		this.transform.Translate (Vector3.forward * movrate * Time.deltaTime * zdir);
		this.transform.Rotate (Vector3.up * 100 * Time.deltaTime * xdir);
		// 키 입력...
		// Input class
		// unity 엔진 키입력 세팅 => Axis 얻어올때, GetAxis
		// 키 입력 x=0 있으면 -1(반대).... 0(키입력없음) ...1(일반)

	}
}
