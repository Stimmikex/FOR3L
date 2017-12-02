using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class end_menu : MonoBehaviour {

    public string main_menu;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void quit_game()
    {
        SceneManager.LoadScene(main_menu);
        //Application.Quit();
    }
}
