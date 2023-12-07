using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FadeInAndOut : MonoBehaviour
{
    public GameObject gameObject1;
    public GameObject gameObject2;
    public float fadeDuration = 1.0f;

    private CanvasGroup canvasGroup1;
    private CanvasGroup canvasGroup2;

    private void Start()
    {
        // Ensure GameObjects are not null and have a CanvasGroup component
        canvasGroup1 = gameObject1.GetComponent<CanvasGroup>();
        canvasGroup2 = gameObject2.GetComponent<CanvasGroup>();

        if (canvasGroup1 == null || canvasGroup2 == null)
        {
            Debug.LogError("Both GameObjects must have a CanvasGroup component.");
        }
    }

    public void FadeOutGameObject1AndFadeInGameObject2()
    {
        StartCoroutine(FadeCoroutine(canvasGroup1, 1.0f, 0.0f));
        StartCoroutine(FadeCoroutine(canvasGroup2, 0.0f, 1.0f));
    }

    public void FadeOutGameObject2AndFadeInGameObject1()
    {
        StartCoroutine(FadeCoroutine(canvasGroup2, 1.0f, 0.0f));
        StartCoroutine(FadeCoroutine(canvasGroup1, 0.0f, 1.0f));
    }

    private IEnumerator FadeCoroutine(CanvasGroup canvasGroup, float startAlpha, float targetAlpha)
    {
        float elapsedTime = 0f;
        float currentAlpha = startAlpha;

        while (elapsedTime < fadeDuration)
        {
            currentAlpha = Mathf.Lerp(startAlpha, targetAlpha, elapsedTime / fadeDuration);
            canvasGroup.alpha = currentAlpha;

            elapsedTime += Time.deltaTime;
            yield return null;
        }

        // Ensure the alpha is set to the exact target value
        canvasGroup.alpha = targetAlpha;
    }
}
