using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddScripte : MonoBehaviour {
	public GameObject self;
	public GameObject player;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown (0)) 
		{
			self.SetActive (false);
		}
	}
}
