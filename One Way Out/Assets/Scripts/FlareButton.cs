using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlareButton : MonoBehaviour
{
    private BlackOverlayFade blackOverlayFade;
    public GameObject flare1;
    public GameObject flare2;
    public GameObject flare3;

    private GameObject[] flares;

    private int remainingFlares = 3;
    private float timer;

    private void Start()
    {
        blackOverlayFade = GameObject.FindGameObjectWithTag("BlackOverlay").GetComponent<BlackOverlayFade>();
        timer = 3f;
        flares = new GameObject[]{ flare1, flare2, flare3 };

    }

    private bool isScreenLit = false;


    public void OnButtonPress()
    {


        if (remainingFlares > 0)
        {
            StartCoroutine(blackOverlayFade.FadeBlackOverlaySquare(false));
            isScreenLit = true;

            HideFlare(flares[remainingFlares - 1]);
        }

    }
    private void Update()
    {
        if (isScreenLit)
        {
            timer -= Time.deltaTime;
        }

        if (timer < 0)
        {
            StartCoroutine(blackOverlayFade.FadeBlackOverlaySquare());
            isScreenLit = false;
            timer = 3f;
        }
    }

    public void HideFlare(GameObject flare)
    {
        Color flareColor = flare.GetComponent<SpriteRenderer>().color;

        flareColor = new Color(flareColor.r, flareColor.g, flareColor.b, 0);
        flare.GetComponent<SpriteRenderer>().color = flareColor;

        remainingFlares--;
    }
}