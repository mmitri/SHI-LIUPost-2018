using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillPlayer : MonoBehaviour 
{

	// Use this for initialization
	void Start () 
	{
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		
	}

	private void OnCollisionEnter(Collision collision)
	{
		if (collision.gameObject.tag == "Player") 
		{
			Destroy (collision.gameObject);
			UnityEngine.SceneManagement.SceneManager.LoadScene ("Ded");
		}
			
	}
}
