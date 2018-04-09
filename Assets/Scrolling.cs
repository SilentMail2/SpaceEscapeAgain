using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Scrolling : MonoBehaviour {
	public float scrollspeed = 0.5f;
	public GameObject Player;
	public Player_Controller player_values;
	Vector2 offset;
	// Use this for initialization
	void Start () {
		player_values = Player.GetComponent<Player_Controller> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (player_values.boostMode == false) {
			offset = new Vector2 (Time.time * scrollspeed, 0);
			GetComponent<Renderer> ().material.mainTextureOffset = offset;
		}
		if (player_values.boostMode == true) {
				offset = new Vector2 (Time.time * scrollspeed*2, 0);
				GetComponent<Renderer> ().material.mainTextureOffset = offset;
		}
	}
}