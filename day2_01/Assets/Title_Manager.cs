using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// 클래스나 라이브러리, 자료형 들이 선언되고 세팅 쇤 작업 역영을 추가함
using UnityEngine.SceneManagement;

public class Title_Manager : MonoBehaviour {

	public void NextScene() {
		// scene 을 관리하는 클래스를 이용 해서 씬이동을 함
		//SceneManager.LoadScene();
		SceneManager.LoadScene("Clicker2");
	}

	public void QuitProgram() {
		Application.Quit ();
	}
}
