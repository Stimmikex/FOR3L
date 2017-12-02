using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour {

    private level_manager the_level_manager;

    public int damage_given;

	// Use this for initialization
	void Start () {
        the_level_manager = FindObjectOfType<level_manager>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    
    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Player")
        {
            //the_level_manager.Respawn();
            /*This will take hte hit_player function from the level_manager*/
            the_level_manager.hit_player(damage_given);
        }
    }
}
