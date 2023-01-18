using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeScript : MonoBehaviour 
{
	public Renderer myRenderer;
	public Material altColor;
	public Material altAfterColor;

	// Use this for initialization
	void Start () 
	{
		Debug.Log ("Hello World");
	}
	
	// Update is called once per frame
	void Update () 
	{
		
	}

	// Update when collided
	private void OnCollisionEnter(Collision collision)
	{
		myRenderer.material = altColor;
	}

	private void OnCollisionExit(Collision collision)
	{
		myRenderer.material = altAfterColor;
	}


}
