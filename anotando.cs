using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class anotando : MonoBehaviour
{
    public GameObject cameraaa;
    Animator anim;
    public bool pegar, audioo;
    public AudioClip escrevendo;
    int cont;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if(audioo == true)
        {
            if(cont == 0)
            {
                cameraaa.GetComponent<AudioSource>().clip = escrevendo;
                cameraaa.GetComponent<AudioSource>().Play();
                cont = 1;
            }
           
        }

        else if (audioo == false)
        {
            if (cameraaa.GetComponent<AudioSource>().clip == escrevendo)
             {
                 cameraaa.GetComponent<AudioSource>().clip = null;
                
             }
            cont = 0;
        }

        anim.SetBool("ativo", pegar);


    }
}
