using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class menuscc : MonoBehaviour
{
    public GameObject cv;
    
  
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Z))
        {
            Cursor.lockState = CursorLockMode.Confined;
            cv.SetActive(true);
           
        }
    }
    public void resume()
    {
        
        Cursor.lockState = CursorLockMode.Locked;
        cv.SetActive(false);
        
    }

    public void backloby()
    {
        SceneManager.LoadScene(0);
    }
}
