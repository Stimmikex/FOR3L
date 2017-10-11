using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class level_manager : MonoBehaviour {

    public float respawn_timer;

    public player_controller the_player;

	// Use this for initialization
	void Start () {
        the_player = FindObjectOfType<player_controller>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void Respawn()
    {
        /*This will deactivate the player*/
        the_player.gameObject.SetActive(false);
        /*This will change the posistion where the player died*/
        the_player.transform.position = the_player.respawn_pos;
        /*This will active the player*/
        the_player.gameObject.SetActive(true);
    }
}
