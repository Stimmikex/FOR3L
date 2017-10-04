using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class checkpoint_controller : MonoBehaviour {
    public Sprite flag_closed;
    public Sprite flag_open;

    private SpriteRenderer sprite_renderer;

    public bool check_point_checker;
    // Use this for initialization
    void Start () {
        sprite_renderer = GetComponent<SpriteRenderer>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            sprite_renderer.sprite = flag_open;
            check_point_checker = true;
        }
    }
}
