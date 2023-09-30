using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuScript : MonoBehaviour
{
    public AudioSource src;
    public AudioClip sounds1;

    // Update is called once per frame
    

    public void play()
    {
        src.clip = sounds1;
        src.Play();
        SceneManager.LoadScene(1);
      
    }

    public void quit()
    {
        src.clip = sounds1;
        src.Play();
        Application.Quit();
        
    }
}
