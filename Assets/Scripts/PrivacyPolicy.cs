using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrivacyPolicy : MonoBehaviour
{
    int aceitou = 0;
    [SerializeField] GameObject privacyPolicy;
    // Start is called before the first frame update
    void Start()
    {

        aceitou = PlayerPrefs.GetInt("aceitou");

        if (aceitou == 0)
        {
            privacyPolicy.SetActive(true);
        }
        else
        {
            privacyPolicy.SetActive(false);
        }

    }

    public void PrivacyPolicyLink()
    {
        Application.OpenURL("https://woodyverso.com.br/politica-de-privacidade/");
    }

    public void Aceitar()
    {
        aceitou = 1;
        PlayerPrefs.SetInt("aceitou", aceitou);
        privacyPolicy.SetActive(false);
    }
}

