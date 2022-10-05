using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BlackOverlayFade : MonoBehaviour
{
    public GameObject BlackOverlay;
    // Update is called once per frame
    void Update()
    {

    }

    public IEnumerator FadeBlackOverlaySquare(bool fadeToBlack = true, int fadeSpeed = 5)
    {
        Color overlayColour = BlackOverlay.GetComponent<Image>().color;
        float fadeAmount;

        if (fadeToBlack)
        {
            while (BlackOverlay.GetComponent<Image>().color.a < 1)
            {
                fadeAmount = overlayColour.a + (fadeSpeed * Time.deltaTime);

                overlayColour = new Color(overlayColour.r, overlayColour.g, overlayColour.b, fadeAmount);
                BlackOverlay.GetComponent<Image>().color = overlayColour;
                yield return null;
            }
        }
        else
        {
            while (BlackOverlay.GetComponent<Image>().color.a > 0)
            {
                fadeAmount = overlayColour.a - (fadeSpeed * Time.deltaTime);

                overlayColour = new Color(overlayColour.r, overlayColour.g, overlayColour.b, fadeAmount);
                BlackOverlay.GetComponent<Image>().color = overlayColour;
                yield return null;
            }
        }
    }
}