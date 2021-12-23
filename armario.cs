using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class armario : MonoBehaviour
{

    Animator anim;
    public bool trocar, pronto;
    public GameObject sensorial;
    [SerializeField]
    AudioClip song;
    AudioSource audios;
    int cont;

    // Start is called before the first frame update
    void Start()
    {
        sensorial = GameObject.Find("sensor");
        trocar = false;
        anim = GetComponent<Animator>();
        audios = sensorial.GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {

        if(gameObject.tag == "interagir")
        {
            anim.SetBool("troca", trocar);
        }

            if(anim.GetAnimatorTransitionInfo(0).nameHash != 0 && cont == 0)
            {
            cont = 1;
            audios.clip = song;
            StartCoroutine(recomeco());
                
                
            }
            
        
       

    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "sensor" && sensorial.GetComponent<sensor>().testo.gameObject == gameObject)
        {
            if (Input.GetKeyDown(KeyCode.E) && trocar == false )
            {
                trocar = true;
            }

            if (Input.GetKeyDown(KeyCode.E) && trocar == true )
            {
                trocar = false;
            }


        }
    }

    private void OnTriggerStay(Collider other)
    {

        if (other.tag == "sensor" && sensorial.GetComponent<sensor>().testo.gameObject == gameObject)
        {
            if (Input.GetKeyDown(KeyCode.E) && trocar == false && pronto == false )
            {
                trocar = true;
            }

            if(Input.GetKeyDown(KeyCode.E) && trocar == true && pronto == true)
            {
                trocar = false;
            }


        }



    }


     IEnumerator recomeco()
    {
        audios.Play();
        yield return new WaitForSeconds(1);
        cont = 0;
    }

}
