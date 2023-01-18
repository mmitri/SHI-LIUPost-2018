using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour 
{
	public int HP;

	// Use this for initialization
	void Start () 
	{
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		
	}

	public void GetHit()
	{
		HP = HP - 1;

		if (HP <= 0) 
		{
			Destroy (gameObject);
		}
	}

}
