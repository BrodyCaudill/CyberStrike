using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class HoverFade : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    void Awake()
    {
        GetComponent<CanvasGroup>().alpha = 0;
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        StartCoroutine(FadeIn());
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        StartCoroutine(FadeOut());
    }

    private IEnumerator FadeOut()
    {
        for (float i = 1f; i >= 0; i -= 0.05f)
        {
            GetComponent<CanvasGroup>().alpha = i;
            yield return new WaitForSeconds(0.01f);
        }
        GetComponent<CanvasGroup>().alpha = 0;
    }

    private IEnumerator FadeIn()
    {
        for (float i = 0; i < 1; i += 0.05f)
        {
            GetComponent<CanvasGroup>().alpha = i;
            yield return new WaitForSeconds(0.01f);
        }
        GetComponent<CanvasGroup>().alpha = 1;
    }
}
