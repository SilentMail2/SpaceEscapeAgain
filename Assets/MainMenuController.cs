﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenuController : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void StartInfinite()
    {
        Application.LoadLevel("Level 1");
    }
	public void StartStory()
	{
		Application.LoadLevel("Story");
	}
}
