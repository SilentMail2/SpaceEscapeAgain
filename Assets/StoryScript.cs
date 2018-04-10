using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class StoryScript : MonoBehaviour {
	public GameObject self;
	public GameObject player;
	//public Player_Controller player_values;
	public Texture[] Textures;
	public int i = 0;
	public int health = 4;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		player.SetActive (false);
		Time.timeScale = 0;
		if (Input.GetMouseButtonDown (0)) 
		{
			if (health >= 1) {
				GetComponent<Renderer> ().material.mainTexture = Textures [i++];
				health--;
				Time.timeScale = 0;
			}
			if (health <= 0) 
			{
				Time.timeScale = 1;

				player.SetActive (true);
				self.SetActive (false);
			}
		}

	}

	public void Next()
	{
		
	}
}
