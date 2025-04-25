using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class MenuPrincipal : MonoBehaviour
{
    [SerializeField] private RectTransform firstScreen;

    Vector2 cacheFirstScreenPos;

    private void Awake()
    {
        cacheFirstScreenPos = firstScreen.anchoredPosition;
        
    }

    public void EscanearImagem()
    {
        //Application.LoadLevel("Woodyverso Ar");
        FindObjectOfType<AnimationsHandler>().canDetect = true;
        firstScreen.DOAnchorPos(new Vector2(-1106f, 0), 0.2f);
    }

    public void OpenHome()
    {
        FindObjectOfType<AnimationsHandler>().canDetect = false;
        firstScreen.DOAnchorPos(cacheFirstScreenPos, 0.2f);
    }
}
