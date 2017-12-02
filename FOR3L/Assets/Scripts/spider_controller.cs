using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spider_controller : MonoBehaviour {

    public float move_speed;
    private bool mobility;

    private Rigidbody2D spider_rigidbody;

    // Use this for initialization
    void Start () {
        spider_rigidbody = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
        if (mobility)
        {
            spider_rigidbody.velocity = new Vector3(-move_speed, spider_rigidbody.velocity.y, 0f);
        }
	}

    void OnBecameVisible()
    {
        mobility = true;
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Kill_plane")
        {
            Destroy(gameObject);
        }
    }
}
