using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class LogicManager : MonoBehaviour
{
    public string sceneName;
    public CanvasGroup Fade;

    public void restartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void nextLevel()
    {
      //  StartCoroutine(FadeLevel());
        SceneManager.LoadScene(sceneName);
    }

    public void exitGame()
    {
        Application.Quit();
    }

   // private IEnumerator FadeLevel()
   //{
      //  yield return FadeHelper.FadeIn(1f, Fade);

      //  SceneManager.LoadScene(sceneName);

      //  yield return FadeHelper.FadeOut(3f, Fade);
   // }
}
