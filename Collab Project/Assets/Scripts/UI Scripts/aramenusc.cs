using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class aramenusc : MonoBehaviour
{

    public void resume()
    {
        SceneManager.LoadScene(1);
    }

    public void backloby()
    {
        SceneManager.LoadScene(0);

    }
}
