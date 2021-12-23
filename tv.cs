using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tv : MonoBehaviour
{

    bool trocar;
    [SerializeField]
    GameObject tvLigado, escurecerr;
    [SerializeField]
    AudioClip song;
    AudioSource meuSong;
    int cont;



    // Start is called before the first frame update
    void Start()
    {
        meuSong = GetComponent<AudioSource>();
        meuSong.clip = song;
        escurecerr = GameObject.Find("escurecer");
    }

    // Update is called once per frame
    void Update()
    {
        ligado();
        songTv();
        if (escurecerr.GetComponent<escurecer>().cenaAtual == "semana03" || escurecerr.GetComponent<escurecer>().cenaAtual == "semana05"
            || escurecerr.GetComponent<escurecer>().cenaAtual == "semana04")
        {
            trocar = false;
        }
    }


    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "sensor")
        {
            if(Input.GetKeyDown(KeyCode.E) || Input.GetKeyDown(KeyCode.Return) || Input.GetKeyDown(KeyCode.Mouse0))
            {
                if(trocar == false && escurecerr.GetComponent<escurecer>().cenaAtual != "semana03" ||
                    trocar == false && escurecerr.GetComponent<escurecer>().cenaAtual != "semana04"
                    || trocar == false && escurecerr.GetComponent<escurecer>().cenaAtual != "semana05")
                {
                    trocar = true;
                }
                else if(trocar == true)
                {
                    trocar = false;
                }
            }
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if(other.tag == "sensor")
        {
            if(Input.GetKeyDown(KeyCode.E) || Input.GetKeyDown(KeyCode.Return) || Input.GetKeyDown(KeyCode.Mouse0))
            {
                if(trocar == false && escurecerr.GetComponent<escurecer>().cenaAtual != "semana03" ||
                    trocar == false && escurecerr.GetComponent<escurecer>().cenaAtual != "semana04"
                    || trocar == false && escurecerr.GetComponent<escurecer>().cenaAtual != "semana05")
                {
                    trocar = true;
                }
                else if(trocar == true)
                {
                    trocar = false;
                }
            }
        }
    }


    private void ligado()
    {
        if(trocar == true)
        {
            tvLigado.SetActive(true);
        }
        if(trocar == false)
        {
            tvLigado.SetActive(false);
        }
    }


    private void songTv()
    {
        if(tvLigado.activeSelf == true)
        {
            
            if (cont == 0)
            {
                cont = 1;
                meuSong.Play();
            }
           
        }
        if(tvLigado.activeSelf == false)
        {
            
            if(cont == 1)
            {
                cont = 0;
                meuSong.Stop();
            }
            
        }
    }



}
