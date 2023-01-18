using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootJon : MonoBehaviour 
{

	public GameObject prefab;

	public float shotTime;
	private float timer;

	// Use this for initialization
	void Start () 
	{
		timer = 0;
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (Input.GetMouseButtonDown (0) == true && timer < 0) 
		{
			Instantiate(prefab, transform.position + new Vector3(0,0.6f,0) , Quaternion.identity);
			timer = shotTime;
		}

		timer = timer - Time.deltaTime;
	}
}
