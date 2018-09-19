using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Title_manage : MonoBehaviour {

	public void NextScene() {
		SceneManager.LoadScene ("GameScene");
	}
}
