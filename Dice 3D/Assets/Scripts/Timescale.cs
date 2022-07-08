using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Timescale : MonoBehaviour
{
    // Start is called before the first frame update
    public float timespeed = 1.5f;

    public void PlayGame ()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1); //here we are using scene manager to get an active scene here its +1 means it will load the scene enxt to it 
    }

    public void NextGame ()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1); 

    }
	public void Endgame()
	{
		Application.Quit();
        Debug.Log("endgame");
	}

    public void TwoDPlay ()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 3); 

    }

    public void BackToPlay ()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 3); 

    }



    // Update is called once per frame
    void Update()
    {
        Time.timeScale = timespeed;
    }
}
