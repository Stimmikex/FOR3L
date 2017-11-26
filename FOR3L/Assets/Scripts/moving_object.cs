using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moving_object : MonoBehaviour {

    public GameObject object_to_move;

    public Transform startpoint;
    public Transform endpoint;

    public float move_speed;

    private Vector3 current_target;
	// Use this for initialization
	void Start () {
        current_target = endpoint.position;
	}
	
	// Update is called once per frame
	void Update () {
        object_to_move.transform.position = Vector3.MoveTowards(object_to_move.transform.position, current_target, move_speed * Time.deltaTime);

        if (object_to_move.transform.position == endpoint.position)
        {
            current_target = startpoint.position;
        }
        if (object_to_move.transform.position == startpoint.position)
        {
            current_target = endpoint.position;
        }
    }
}
