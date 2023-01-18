using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Patrol : MonoBehaviour 
{
	public Vector3 moveSpeed;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		transform.position = transform.position + moveSpeed;
	}

	private void OnCollisionEnter(Collision collision)
	{
		moveSpeed = moveSpeed * -1;
	}
}
