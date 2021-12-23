using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class notificacaoMestre : MonoBehaviour
{

    public bool trocar, notificar;
    Animator anim;
    [SerializeField]
    AudioClip song;
    int cont, cont02;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        trocar = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(gameObject.activeSelf == true && cont == 0)
        {
            cont = 1;
            gameObject.GetComponent<AudioSource>().clip = song;
            gameObject.GetComponent<AudioSource>().Play();
        }

        anim.SetBool("troca", trocar);
        if(trocar == true)
        {
            gameObject.GetComponent<AudioSource>().clip = song;
            gameObject.GetComponent<AudioSource>().Play();
        }

        anim.SetBool("notificar", notificar);

        if(notificar == true && cont02 == 0)
        {
            cont02 = 1;
            StartCoroutine(mudar());
        }

    }



    IEnumerator mudar()
    {
        yield return new WaitForSeconds(0f);
        notificar = false;
        cont02 = 0;
    }
}
