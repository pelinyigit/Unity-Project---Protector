﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {

	public void PlayGame()
	{
		//SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);
		SceneManager.LoadScene("Main Scene");
	}

	public void Quit()
	{
		Application.Quit();
		Debug.Log("QUIT!");
	}
}
