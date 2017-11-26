using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Currency : MonoBehaviour {
    /*Connects to the level_manager*/
    private level_manager the_level_manager;
    /*This is where the value of each coin is set.*/
    public int currency_value;

	// Use this for initialization
	void Start () {
        the_level_manager = FindObjectOfType<level_manager>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            the_level_manager.add_currency(currency_value);

            /*This will destroy the coin then the player touches it*/
            Destroy(gameObject);
        }
    }
}
