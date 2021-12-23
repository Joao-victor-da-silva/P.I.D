using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class sustos : MonoBehaviour
{

    [SerializeField]
    PlayableDirector susto;

    [SerializeField]
    GameObject missoes, samanta, lampada, descolidindo;

    [SerializeField]
    Color red, branco;

    bool assustar;

    int cont, cont02, cont03, cont04;

    BoxCollider minhaCaixa;

    GameObject canvinho;

    
    void Start()
    {
        gameObject.layer = 11;
        canvinho = GameObject.Find("Canvas");
        descolidindo = GameObject.Find("sensor");
        minhaCaixa = GetComponent<BoxCollider>();
        if(lampada != null)
        {
            lampada.GetComponent<Light>().color = branco;
        }
        if (gameObject.name == "sustoSamanta" || gameObject.name == "sustoWalter" || gameObject.name == "ultimoSusto")
        {
            minhaCaixa.enabled = false;
        }

       
        assustar = false;
        if(lampada != null)
        {
            branco = lampada.GetComponent<Light>().color;
        }
    }

    
    void Update()
    {

        if (assustar == true && cont04 == 0)
        {
            cont04 = 1;
            canvinho.GetComponent<objetivos>().tocarMusica = false;
        }

        zomie();
        maisumsutos();
        ultimoSusto();

        if (assustar == true && cont == 0)
        {
            cont = 1;
            if(gameObject.name == "sustoSamanta")
            {
                StartCoroutine(sumiu());
            }
            
            susto.Play();
            minhaCaixa.enabled = false;
            StartCoroutine(concertar());
        }
    }


    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            assustar = true;
        }
    }


    private void zomie()
    {
        if (gameObject.name == "sustoSamanta")
        {


            if(missoes.GetComponent<objetivos>().cont4 != 0 && cont02 == 0)
            {
                minhaCaixa.enabled = true;
                cont02 = 1;
                samanta.SetActive(true);
                lampada.GetComponent<Light>().color = red;
                if(assustar == true)
                {
                   // lampada.GetComponent<Light>().color = branco;
                }
            }
        }
    }


    private void maisumsutos()
    {
        if(gameObject.name == "sustoWalter")
        {
            if(missoes.GetComponent<objetivos>().cont3 != 0 && missoes.GetComponent<objetivos>().cont4 != 0 && cont03 == 0)
            {
                cont03 = 1;
                minhaCaixa.enabled = true;
            }
        }
    }

    private void ultimoSusto()
    {
        if (gameObject.name == "ultimoSusto")
        {
            if (missoes.GetComponent<objetivos>().cont3 != 0 && missoes.GetComponent<objetivos>().cont4 != 0 && cont03 == 0)
            {
                cont03 = 1;
                minhaCaixa.enabled = true;
            }
        }
    }



    IEnumerator sumiu()
    {
        yield return new WaitForSeconds(2.1f);
        //samanta.SetActive(false);
        lampada.GetComponent<Light>().color = branco;
    }


    IEnumerator concertar()
    {
        yield return new WaitForSeconds(1f);
        descolidindo.GetComponent<sensor>().colidiu = false;
    }


}
