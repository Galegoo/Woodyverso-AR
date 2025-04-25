using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartAnimation : MonoBehaviour
{
    [SerializeField] private Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        
    }


    public void TargetEnable()
    {
        anim.SetTrigger("Start");
    }

    public void OpenWhatsapp()
    {
        Application.OpenURL("WHATS");
    }
}
