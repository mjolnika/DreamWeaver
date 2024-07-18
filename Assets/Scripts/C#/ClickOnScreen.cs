using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ClickOnScreen : MonoBehaviour
{
    public string sceneName;
    public string toMenu;

    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            Debug.Log("Space");
            SceneManager.LoadScene(sceneName);
        }
        else if (Input.GetKey("escape"))
        {
            SceneManager.LoadScene(toMenu);
        }
    }
}
