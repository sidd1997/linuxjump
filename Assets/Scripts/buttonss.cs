using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class buttonss : MonoBehaviour {

	public void pause()
    {
        if(Time.timeScale == 1)
        {
            Time.timeScale = 0;
        }
        else if(Time.timeScale == 0)
        {
            Time.timeScale = 1;
        }
    }
    public void restartgame()
    {
        SceneManager.LoadScene("first");
    }
    public void stat()
    {
        if (Time.timeScale == 0)
        {
            Time.timeScale = 1;
        }
    }
    public void exits()
    {
        Application.Quit();
    }
}
