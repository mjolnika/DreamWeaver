using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StartScreen : MonoBehaviour

{ // array ->
    
    public string sceneName;
    public int waitFor;

    // Start is called before the first frame update
    public void Start()
    {
        StartCoroutine(Delay());
    }

    // Update is called once per frame
    public IEnumerator Delay()
    {
        yield return new WaitForSeconds(waitFor);
        SceneManager.LoadScene(sceneName);
    }
}
