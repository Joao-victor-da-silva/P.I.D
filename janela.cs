using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class janela : MonoBehaviour
{
    [SerializeField]
    Transform abrirJanela;
    [SerializeField]
    bool liberar, aberto;
    GameObject misaao022, escurecer;
    int cont, cont02;

    // Start is called before the first frame update
    void Start()
    {
        escurecer = GameObject.Find("escurecer");
        abrirJanela = transform.Find("JanelaBarindoo");
        misaao022 = GameObject.Find("missoes");
    }

    // Update is called once per frame
    void Update()
    {
        if (liberar == true && Input.GetKeyDown(KeyCode.E) && cont02 == 0)
        {
            cont02 = 1;
            liberar = false;
            aberto = true;
           if(escurecer.GetComponent<escurecer>().cenaAtual == "semana02")
            {
                misaao022.GetComponent<missao02>().janelas++;
            }
                    

            
        }

        abrirJanela.GetComponent<Animator>().SetBool("fechar", aberto);


        if(escurecer.GetComponent<escurecer>().cenaAtual == "semana03" || escurecer.GetComponent<escurecer>().cenaAtual == "semana04")
        {
            aberto = true;
        }


        if (aberto == true && cont == 0)
        {
            cont = 1;
            gameObject.tag = "Untagged";
        }

    }

    

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "sensor")
        {
            liberar = true;
        }
    }


    private void OnTriggerExit(Collider other)
    {
        if(other.tag == "sensor")
        {
            liberar = false;
        }
    }

}
