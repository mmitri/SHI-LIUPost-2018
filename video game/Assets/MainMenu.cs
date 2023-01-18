using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenu : MonoBehaviour 
{

	void Start()
	{
		Cursor.lockState = CursorLockMode.None;
			Cursor.visible = true;	
	}
	public void startjon ()
	{
		UnityEngine.SceneManagement.SceneManager.LoadScene ("My Scene");
	}

	public void backToMenu ()
	{
		UnityEngine.SceneManagement.SceneManager.LoadScene ("Menu");
	}

}
