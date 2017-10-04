using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera_controller : MonoBehaviour {
    /*this targets the player*/
    public GameObject target;
    /*this will move the camera a bit forward*/
    public float follow_cam;
    /*this is the position of the target*/
    private Vector3 target_position;
    /**/
    public float smoothing_cam;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        target_position = new Vector3(target.transform.position.x, transform.position.y, transform.position.z);
        /*this is to know where the player is faceing.*/
        if (target.transform.localScale.x > 0f)
        {
            target_position = new Vector3(target_position.x + follow_cam, target_position.y, target_position.z);
        }
        else
        {
            target_position = new Vector3(target_position.x - follow_cam, target_position.y, target_position.z);
        }
        //transform.position = target_position;
        transform.position = Vector3.Lerp(transform.position, target_position, smoothing_cam * Time.deltaTime);
	}
}
