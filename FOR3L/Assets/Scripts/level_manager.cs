using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class level_manager : MonoBehaviour {
    /*The respawn timer for the player then the player dyes*/
    public float respawn_timer;

    /*Connects the player controller to the level controller*/
    public player_controller the_player;

    /*This is the effect that id displayed then the player is killed*/
    public GameObject death_blood;

    /*This is where the currency is counted and kept*/
    public int currency_counter;

    /*Text for the amount of currency*/
    public Text coin_text;

	// Use this for initialization
	void Start () {
        the_player = FindObjectOfType<player_controller>();

        coin_text.text = "Coins:" + currency_counter;
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
    /*currency_added is the value of the currency that the player is graping*/
    public void add_currency(int currency_added)
    {
        currency_counter += currency_added;

        coin_text.text = "Coins:" + currency_counter;
    }
}
