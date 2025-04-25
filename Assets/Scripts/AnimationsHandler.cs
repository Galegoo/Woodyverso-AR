using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AnimationsHandler : MonoBehaviour
{
    [SerializeField]
    float tempoProWpAparecer;
    float tempoStorage;
    [SerializeField] float count = 3; //tempo pro woody spawnar

    [SerializeField] Button wPButton;
    bool active; //target detectado ou n

    [SerializeField] Animator anim_nave;
    [SerializeField] Animator anim_woody;


    [SerializeField] GameObject woodyCharacter;
    [SerializeField] GameObject light_;
    [SerializeField] GameObject UFO;

    [SerializeField] AudioSource audioWoody;


    public bool canDetect;

    // Start is called before the first frame update

    private void Start()
    {
        tempoStorage = tempoProWpAparecer;
    }
    public void Enabled()
    {
        if(canDetect)
        {
            active = true;
            UFO.SetActive(true);
            anim_nave.Play("Nave", -1, 0f);
        }

    }
    public void Disabled()
    {
        active = false;
        woodyCharacter.SetActive(false);
        UFO.SetActive(false);
        audioWoody.Stop();
        count = 1.8f;
    }
    // Update is called once per frame
    void Update()
    {
        if (tempoProWpAparecer <= 0) //woody falou sobre o wp
        {
            wPButton.gameObject.SetActive(true);
        }

        if (active) //target detectado
        {
            tempoProWpAparecer -= Time.deltaTime;
            count -= Time.deltaTime;
        }
        else // resetar o tempo pro wp aparecer dps q animação começa 
        {
            tempoProWpAparecer = tempoStorage;
            wPButton.gameObject.SetActive(false);
        }
        if (count <= 1 && count > 0)
        {
            light_.SetActive(true);

        }

        if (count <= 0) // spawnar o woody quando a nave passar
        {
            WoodySpawner();
            light_.SetActive(false);
        }

        if (count <= -5)
            UFO.SetActive(false);
    }

    public void OpenWpLink()
    {
        Application.OpenURL("https://contate.me/woodyverso");
    }
    void WoodySpawner()
    {
        woodyCharacter.SetActive(true);
        //audioWoody.Play();
        anim_woody.SetTrigger("Start");
        //anim_woody.Rebind();
        //anim_woody.Play("Waving", -1, 0f);
    }
}
