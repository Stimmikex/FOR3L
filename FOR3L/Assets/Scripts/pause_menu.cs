using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class pause_menu : MonoBehaviour {
    /*string for the main menu in unity*/
    public string main_menu;

    /*GameObject for the pause menu*/
    public GameObject the_pause_screen;

    private player_controller the_player;

	// Use this for initialization
	void Start () {
        the_player = FindObjectOfType<player_controller>();
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Time.timeScale = 0;

            /*This is to activate the pause menu*/
            the_pause_screen.SetActive(true);

            //the_player.gameObject.SetActive(false);
        }
	}

    public void resume_game()
    {
        /*This is to deactivate the pause menu*/
        the_pause_screen.SetActive(false);

        Time.timeScale = 1f;

        //the_player.gameObject.SetActive(true);
    }

    public void quit_game()
    {
        /*This will direct the player to the main menu*/
        SceneManager.LoadScene(main_menu);
    }
}
