using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flashlight: MonoBehaviour 
{
	public GameObject flashlight;
	public GameObject flashlight_out;
	void Start () 
	{
		
	}

	void Update()
	{
		

	}
	private void OnCollisionEnter(Collision collision)
	{
		Debug.Log("Enter " + collision.gameObject.name);
		if (collision.gameObject.name == "Root")
		{
			flashlight.SetActive(true);
			flashlight_out.SetActive(false);

		}

	}

	
}
