using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class level_manager : MonoBehaviour {

    public float respawn_timer;

    public player_controller the_player;

    public GameObject death_blood;

	// Use this for initialization
	void Start () {
        the_player = FindObjectOfType<player_controller>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void Respawn()
    {
        StartCoroutine("RespawnCo");
    }

    public IEnumerator RespawnCo()
    {
        /*This will deactivate the player*/
        the_player.gameObject.SetActive(false);

        /*This will create a object. it will crate the blood animation for the death of the player*/
        Instantiate(death_blood, the_player.transform.position, the_player.transform.rotation);

        yield return new WaitForSeconds(respawn_timer);

        /*This will change the posistion where the player died*/
        the_player.transform.position = the_player.respawn_pos;
        /*This will active the player*/
        the_player.gameObject.SetActive(true);
    }
}
