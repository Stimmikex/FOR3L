using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_controller : MonoBehaviour {
	/*Movement speed*/
	public float player_speed; 
	/*body for the player*/
	private Rigidbody2D player_rigidbody;
	/*jump speed*/
	public float player_jumpspeed;
	/*Ground checker = checks if there's ground*/
	public Transform ground_checker;
	public float ground_check_rad;
	public LayerMask what_is_ground;
	public bool is_grounded;

	private Animator player_anim;

    public Vector3 respawn_pos;

	// Use this for initialization
	void Start ()
    {
		player_rigidbody = GetComponent<Rigidbody2D>();
		player_anim = GetComponent<Animator>();

        respawn_pos = transform.position;
	}
	
	// Update is called once per frame
	void Update ()
    {
		/*check if the player is one hte ground*/
		is_grounded = Physics2D.OverlapCircle (ground_checker.position, ground_check_rad, what_is_ground);
		/*movement*/
		/*move forward*/
		if (Input.GetAxisRaw ("Horizontal") > 0f) {
			player_rigidbody.velocity = new Vector3 (player_speed, player_rigidbody.velocity.y, 0f);
			transform.localScale = new Vector3 (1f, 1f, 1f);
		}
		/*move back*/
		else if (Input.GetAxisRaw ("Horizontal") < 0f) {
			player_rigidbody.velocity = new Vector3 (-player_speed, player_rigidbody.velocity.y, 0f);
			transform.localScale = new Vector3 (-1f, 1f, 1f);
		}
		/*stay still*/
		else {
			player_rigidbody.velocity = new Vector3 (0f, player_rigidbody.velocity.y, 0f);
		}

		/*jumping movement*/
		if (Input.GetButtonDown ("Jump") && is_grounded) {
			player_rigidbody.velocity = new Vector3 (player_rigidbody.velocity.x, player_jumpspeed, 0f);
		}

		player_anim.SetFloat("Speed", Mathf.Abs(player_rigidbody.velocity.x));
		player_anim.SetBool("Ground_check", is_grounded);

	}

    void OnTriggerEnter2D (Collider2D other)
    {
        if (other.tag == "Kill_plane")
        {
            transform.position = respawn_pos;
        }
        if (other.tag == "Checkpoint")
        {
            respawn_pos = other.transform.position;
        }
    }
}
