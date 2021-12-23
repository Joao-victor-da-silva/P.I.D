using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class missao03 : MonoBehaviour
{

    [SerializeField]
    GameObject visualizar, objestivos, velas01, velas02, velaOriginal;
    int cont, cont2, cont03, cont07, cont08;

    [SerializeField]
    AudioSource choco;



    [SerializeField]
    GameObject sensortial, booleano, sensorrrr, velinha;



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        obsetivo01();
        missao04();
        misssao05();
        if (cont08 == 0)
        {
            missaoVelas(cont08);
        }
        
    }


    public void obsetivo01()
    {
        if (visualizar.GetComponent<visualizar>().tomou04 == true && cont == 0)
        {
            cont = 1;
            objestivos.GetComponent<objetivos>().cont1 = 1;
        }
    }


    public void missao()
    {
        if(cont2 == 0)
        {
            cont2 = 1;
            objestivos.GetComponent<objetivos>().cont2 = 1;
        }
        
    }


    public void missao04()
    {
        if (visualizar.GetComponent<visualizar>().tomou07 == true && cont03 == 0)
        {
            cont03 = 1;
            objestivos.GetComponent<objetivos>().cont4 = 1;
        }
    }


    public void misssao05()
    {
        if(objestivos.GetComponent<objetivos>().cont3 != 0 && cont07 == 0)
        {
            cont07 = 1;
            choco.Play();
        }
    }


    public void missaoVelas(int contvelas)
    {
        if(objestivos.GetComponent<objetivos>().cont3 != 0 && contvelas == 0)
        {
            contvelas = 1;
            cont08 = 1;
            Instantiate(velas02,velas01.transform.position, velas01.transform.rotation);
            Destroy(velas01);
            velaOriginal = GameObject.Find("velas(Clone)");
            velinha = GameObject.Find("velas");
            velinha.GetComponent<objeto>().sensortial =  sensortial;
            velinha.GetComponent<objeto>().booleano = booleano;
            velinha.GetComponent<objeto>().sensorrrr = sensorrrr;
            velaOriginal.name = "velas";
        }
    } 

}
