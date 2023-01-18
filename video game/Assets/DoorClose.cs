using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorClose : MonoBehaviour 
{

	public Animator doorAnimator;

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
		doorAnimator.SetBool ("character_nearby", false);
	}
}
