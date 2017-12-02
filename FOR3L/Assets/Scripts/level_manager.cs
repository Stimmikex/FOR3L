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

    /*The health of the player images*/
    public Image heart_1;
    public Image heart_2;
    public Image heart_3;

    /*This is for the sprites that I'm using for the different heart sprites*/
    public Sprite heart_full;
    public Sprite heart_half;
    public Sprite heart_empt;

    /*This is the max health of the player and the health counter that is if the player gets hit*/
    public int health_max;
    public int health_counter;

    /*Bool for if the player is respawning*/
    private bool respawning;

	// Use this for initialization
	void Start () {
        the_player = FindObjectOfType<player_controller>();

        coin_text.text = "Coins: " + currency_counter;

        health_counter = health_max;
	}
	
	// Update is called once per frame
	void Update () {
        /*Checks if the health is less the 0 and then if the player is not respawing*/
        if (health_counter <= 0 && !respawning)
        {
            /*Calls the respawn function*/
            Respawn();
        }
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

        health_counter = health_max;
        respawning = false;
        update_healthmeter();

        /*This will change the posistion where the player died*/
        the_player.transform.position = the_player.respawn_pos;
        /*This will active the player*/
        the_player.gameObject.SetActive(true);
    }
    /*currency_added is the value of the currency that the player is graping*/
    public void add_currency(int currency_added)
    {
        currency_counter += currency_added;

        coin_text.text = "Coins: " + currency_counter;
    }

    public void hit_player(int damage_taken)
    {
        health_counter -= damage_taken;
        update_healthmeter();
    }

    public void update_healthmeter()
    {
        switch (health_counter)
        {
            case 6:
                heart_1.sprite = heart_full;
                heart_2.sprite = heart_full;
                heart_3.sprite = heart_full;
                break;
            case 5:
                heart_1.sprite = heart_full;
                heart_2.sprite = heart_full;
                heart_3.sprite = heart_half;
                break;
            case 4:
                heart_1.sprite = heart_full;
                heart_2.sprite = heart_full;
                heart_3.sprite = heart_empt;
                break;
            case 3:
                heart_1.sprite = heart_full;
                heart_2.sprite = heart_half;
                heart_3.sprite = heart_empt;
                break;
            case 2:
                heart_1.sprite = heart_full;
                heart_2.sprite = heart_empt;
                heart_3.sprite = heart_empt;
                break;
            case 1:
                heart_1.sprite = heart_half;
                heart_2.sprite = heart_empt;
                heart_3.sprite = heart_empt;
                break;
            case 0:
                heart_1.sprite = heart_empt;
                heart_2.sprite = heart_empt;
                heart_3.sprite = heart_empt;
                break;

            default:
                break;
        }
    }
}
