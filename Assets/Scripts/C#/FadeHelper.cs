using System.Collections;
using UnityEngine;

public static class FadeHelper
{
    public static IEnumerator FadeIn(float duration, SpriteRenderer sprite, float from = 0f, float to = 1f)
    {
        return FadeSprite(from, to, duration, sprite);
    }
    
    public static IEnumerator FadeOut(float duration, SpriteRenderer sprite, float from = 1f, float to = 0f)
    {
        return FadeSprite(from, to, duration, sprite);
    }
    
    public static IEnumerator FadeIn(float duration, CanvasGroup canvasGroup, float from = 0f, float to = 1f)
    {
        if (ZeroCheck(1f, duration, canvasGroup) == false)
        {
            return Fade(from, to, duration, canvasGroup);
        }

        return null;
    }
    
    public static IEnumerator FadeOut(float duration, CanvasGroup canvasGroup, float from = 1f, float to = 0f)
    {
        if (ZeroCheck(0f, duration, canvasGroup) == false)
        {
            return Fade(from, to, duration, canvasGroup);
        }
        
        return null;
    }

    private static bool ZeroCheck(float targetAlpha, float duration, CanvasGroup canvasGroup)
    {
        if (duration <= Mathf.Epsilon)
        {
            canvasGroup.alpha = targetAlpha;
            
            return true;
        }

        return false;
    }

    private static IEnumerator Fade(float a, float b, float duration, CanvasGroup canvasGroup)
    {
        var currentTime = 0f;
        while (currentTime < duration)
        {
            var t = currentTime / duration;
            canvasGroup.alpha = Mathf.SmoothStep(a, b, t);

            currentTime += Time.deltaTime;

            yield return new WaitForEndOfFrame();
        }
    }
    
    private static IEnumerator FadeSprite(float from, float to, float duration, SpriteRenderer sprite)
    {
        Color initialColor = sprite.color;
        initialColor.a = from;

        Color targetColor = sprite.color;
        targetColor.a = to;
        
        var currentTime = 0f;
        while (currentTime < duration)
        {
            var t = currentTime / duration;
            sprite.color = Color.Lerp(initialColor, targetColor, t);

            currentTime += Time.deltaTime;

            yield return new WaitForEndOfFrame();
        }
    }
}
