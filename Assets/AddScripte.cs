using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddScripte : MonoBehaviour {
	public GameObject self;
	public GameObject player;
	public Player_Controller player_values;
	// Use this for initialization
	void Start () {
		player_values = player.GetComponent<Player_Controller> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown (0)) 
		{
			self.SetActive (false);
			if (player_values.health <=0) {
				Time.timeScale = 0;
			}
			if (player_values.health > 0) {
				Time.timeScale = 1;
			}
		}
	}
}
