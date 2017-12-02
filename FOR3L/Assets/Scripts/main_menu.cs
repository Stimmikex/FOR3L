using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class main_menu : MonoBehaviour {

    public string first_level;
    public string level_select;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    /*if the new game button is pressed*/
    public void new_game()
    {
        SceneManager.LoadScene(first_level);
    }
    /*if the contine game button is pressed*/
    public void continue_game()
    {
        SceneManager.LoadScene(level_select);
    }
    /*if the quit game button is pressed*/
    public void quit_game()
    {
        Application.Quit();
    }
}
