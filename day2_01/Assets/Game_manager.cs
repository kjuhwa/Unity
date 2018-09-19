using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;

public class Game_manager : MonoBehaviour {

	// 전체적인 씬 관리 => 객체의 
	public Text moneytxt;
	int money;

	// Use this for initialization
	void Start () {
		money = 0;
		moneytxt.text = "0";
	}
	
	// Update is called once per frame
	void Update () {
		moneytxt.text = money.ToString ();
	}

	public void Money_Click() {
		money = money + 1;
		moneytxt.text = money.ToString ();
	}

	public void QuitProgram() {
		Application.Quit ();
	}
}
