using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MenuScript : MonoBehaviour {
	public GameObject Player;
	public GameObject Menu;
	public GameObject Highscore;
	public GameObject Monster;
	public GameObject Add;
	public GameObject[] Enemies;
	private Player_Controller player_Values;
	public float highScore;
	// Use this for initialization
	void Start () {
		player_Values = Player.GetComponent<Player_Controller> ();

	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void Restart()
	{
		Player.SetActive (true);
		player_Values.Score = 0;
		Monster.transform.position = new Vector3 (-184.5f, 0.77f, 0f);
		player_Values.fuel = player_Values.MaxFuel;
		player_Values.health = player_Values.MaxHealth;
		Enemies = GameObject.FindGameObjectsWithTag ("EnemyGroups");	
		foreach (GameObject target in Enemies) {
			GameObject.Destroy (target);
		}
		Highscore.SetActive (false);
		Time.timeScale = 1;

	}
	public void GainMissles()
	{
		player_Values.missleNo++;
		Add.SetActive (true);
	}
}
