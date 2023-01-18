using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndGane : MonoBehaviour 
{

	// Use this for initialization
	void Start () 
	{
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		
	}

	void OnCollisionEnter(Collision collision)
	{
		if (collision.gameObject.tag == "Player") 
		{
			Cursor.visible = true;
			UnityEngine.SceneManagement.SceneManager.LoadScene ("Win");
		}
	}
}
