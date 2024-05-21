using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script : MonoBehaviour {
	
	public Rigidbody2D myRigidbody;

	public float jump;

	void Start () 
	{
		
	}

	void Update () 
	{
		if (Input.GetKeyDown(KeyCode.space) == true)
		{
			myRigidbody.velocity = vector2.up * jump;
		}
	}
}