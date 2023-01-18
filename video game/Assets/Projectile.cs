using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour {

	public float speed;

	// Use this for initialization
	void Start () 
	{
		transform.LookAt (GameObject.Find ("aim").transform);
	}
	
	// Update is called once per frame
	void Update () 
	{
		transform.position = transform.position + transform.forward * speed;
	}

	void OnCollisionEnter (Collision collision)
	{
		if (collision.gameObject.tag == "Enemy") 
		{
			collision.gameObject.SendMessage("GetHit");
		}


		Destroy (gameObject);
	}
		
}
