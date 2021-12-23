using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class anotacoes : MonoBehaviour
{
    visualizar visualizar;
    public GameObject sensor, escrevendo;
    int note01;

    Animator anim;
    anotando anotar;

    int[] numeros;


    //textos

    public GameObject text01, text02, text03;

    Text texto;
    public Text[] textos, textos02, textos03, textos04, textos05;

    [SerializeField]
    GameObject escurecer;

    data datas;
    // Start is called before the first frame update
    void Start()
    {
        escurecer = GameObject.Find("escurecer");
        datas = GameObject.Find("DATA").GetComponent<data>();
        anotar = escrevendo.GetComponent<anotando>();
        anim = escrevendo.GetComponent<Animator>();
        escrevendo.SetActive(true);
        note01 = 1;
        visualizar = sensor.GetComponent<visualizar>();
        texto = escrevendo.GetComponent<Text>();
        if (escurecer.GetComponent<escurecer>().cenaAtual == "semana01")
        {
            salvar();
        }
        if (escurecer.GetComponent<escurecer>().cenaAtual == "semana02")
        {
            salvar02();
            salvarsegundoCapitulo();
        }
        if (escurecer.GetComponent<escurecer>().cenaAtual == "semana03")
        {
            salvar03();
            salvar02();
            salvarterceiroCapitulo();
        }
        if (escurecer.GetComponent<escurecer>().cenaAtual == "semana04")
        {
            salvar02();
            salvar04();
            salvar04p2();
            salvarquartoCapitulo();

        }
        if (escurecer.GetComponent<escurecer>().cenaAtual == "semana05")
        {
            salvar02();
            salvar04();
            salvar04p2();
            salvar05();
            

        }
    }

    // Update is called once per frame
    void Update()
    {
        /*if (visualizar.nanotacoes == 1)
        {
            if (note01 == 0)
            {
                text01.GetComponent<Text>().text = visualizar.AnotCubo;
                note01++;
                print("OI");
                //anim.SetBool("ativo", true);
                anotar.pegar = true;
               //anim.SetBool("ativo", false);
            }
           


        }/


        if (visualizar.nanotacoes == 2)
        {

            if (note01 == 1)
            {
                text02.GetComponent<Text>().text = visualizar.AnotCubo;
                note01++;
                anotar.pegar = true;
                //nim.SetBool("ativo", true);
                //aanim.SetBool("ativo", false);
            }


        }*/



        if(visualizar.nanotacoes == note01 && visualizar.objetos != null)
        {
            if(note01 == visualizar.objetos.GetComponent<objeto>().id)
                textos[visualizar.nanotacoes].text = visualizar.AnotCubo;
                note01++;
                anotar.pegar = true; 
        }


       

    }

    //Textos = textos dos dias
    
    private void salvar()
    {
        datas.diario[0] = textos[1];
        datas.diario[1] = textos[2];
        datas.diario[2] = textos[3];
        datas.diario[3] = textos[4];
        datas.diario[4] = textos[5];
        datas.diario[5] = textos[6];
        datas.diario[6] = textos[7];
        datas.diario[7] = textos[8];
        datas.diario[8] = textos[9];
        datas.diario[9] = textos[10];
        datas.diario[10] = textos[11];
        datas.diario[11] = textos[12];
        datas.diario[12] = textos[13];
        datas.diario[13] = textos[14];
        datas.diario[14] = textos[15];
        datas.diario[15] = textos[16];
        datas.diario[16] = textos[17];
        datas.diario[17] = textos[18];
        datas.diario[18] = textos[19];
        datas.diario[19] = textos[20];
        datas.diario[20] = textos[21];
        datas.diario[21] = textos[22];
        datas.diario[22] = textos[23];
        datas.diario[23] = textos[24];

    }

    private void salvarsegundoCapitulo()
    {
        datas.diario02[0] = textos[1];
        datas.diario02[1] = textos[2];
        datas.diario02[2] = textos[3];
        datas.diario02[3] = textos[4];
        datas.diario02[4] = textos[5];
        datas.diario02[5] = textos[6];
        datas.diario02[6] = textos[7];
        datas.diario02[7] = textos[8];
        datas.diario02[8] = textos[9];
        datas.diario02[9] = textos[10];
        datas.diario02[10] = textos[11];
        datas.diario02[11] = textos[12];
        datas.diario02[12] = textos[13];
        datas.diario02[13] = textos[14];
        datas.diario02[14] = textos[15];
        datas.diario02[15] = textos[16];
        datas.diario02[16] = textos[17];
        datas.diario02[17] = textos[18];
        datas.diario02[18] = textos[19];
        datas.diario02[19] = textos[20];
        datas.diario02[20] = textos[21];
        datas.diario02[21] = textos[22];
        datas.diario02[22] = textos[23];
        datas.diario02[23] = textos[24];

    }



    private void salvar02()
    {
        datas.diario[0] = textos02[0];
        datas.diario[1] = textos02[1];
        datas.diario[2] = textos02[2];
        datas.diario[3] = textos02[3];
        datas.diario[4] = textos02[4];
        datas.diario[5] = textos02[5];
        datas.diario[6] = textos02[6];
        datas.diario[7] = textos02[7];
        datas.diario[8] = textos02[8];
        datas.diario[9] = textos02[9];
        datas.diario[10] = textos02[10];
        datas.diario[11] = textos02[11];
        datas.diario[12] = textos02[12];
        datas.diario[13] = textos02[13];
        datas.diario[14] = textos02[14];
        datas.diario[15] = textos02[15];
        datas.diario[16] = textos02[16];
        datas.diario[17] = textos02[17];
        datas.diario[18] = textos02[18];
        datas.diario[19] = textos02[19];
        datas.diario[20] = textos02[20];
        datas.diario[21] = textos02[21];
        datas.diario[22] = textos02[22];
        datas.diario[23] = textos02[23];
    }


    private void salvar03()
    {
        datas.diario02[0] = textos03[0];
        datas.diario02[1] = textos03[1];
        datas.diario02[2] = textos03[2];
        datas.diario02[3] = textos03[3];
        datas.diario02[4] = textos03[4];
        datas.diario02[5] = textos03[5];
        datas.diario02[6] = textos03[6];
        datas.diario02[7] = textos03[7];
        datas.diario02[8] = textos03[8];
        datas.diario02[9] = textos03[9];
        datas.diario02[10] = textos03[10];
        datas.diario02[11] = textos03[11];
        datas.diario02[12] = textos03[12];
        datas.diario02[13] = textos03[13];
        datas.diario02[14] = textos03[14];
        datas.diario02[15] = textos03[15];
        datas.diario02[16] = textos03[16];
        datas.diario02[17] = textos03[17];
        datas.diario02[18] = textos03[18];
        datas.diario02[19] = textos03[19];
        datas.diario02[20] = textos03[20];
        datas.diario02[21] = textos03[21];
        datas.diario02[22] = textos03[22];
        datas.diario02[23] = textos03[23];
    }

    private void salvarterceiroCapitulo()
    {
        datas.diario03[0] = textos[1];
        datas.diario03[1] = textos[2];
        datas.diario03[2] = textos[3];
        datas.diario03[3] = textos[4];
        datas.diario03[4] = textos[5];
        datas.diario03[5] = textos[6];
        datas.diario03[6] = textos[7];
        datas.diario03[7] = textos[8];
        datas.diario03[8] = textos[9];
        datas.diario03[9] = textos[10];
        datas.diario03[10] = textos[11];
        datas.diario03[11] = textos[12];
        datas.diario03[12] = textos[13];
        datas.diario03[13] = textos[14];
        datas.diario03[14] = textos[15];
        datas.diario03[15] = textos[16];
        datas.diario03[16] = textos[17];
        datas.diario03[17] = textos[18];
        datas.diario03[18] = textos[19];
        datas.diario03[19] = textos[20];
        datas.diario03[20] = textos[21];
        datas.diario03[21] = textos[22];
        datas.diario03[22] = textos[23];
        datas.diario03[23] = textos[24];

    }


    private void salvar04()
    {
        datas.diario03[0] = textos03[0];
        datas.diario03[1] = textos03[1];
        datas.diario03[2] = textos03[2];
        datas.diario03[3] = textos03[3];
        datas.diario03[4] = textos03[4];
        datas.diario03[5] = textos03[5];
        datas.diario03[6] = textos03[6];
        datas.diario03[7] = textos03[7];
        datas.diario03[8] = textos03[8];
        datas.diario03[9] = textos03[9];
        datas.diario03[10] = textos03[10];
        datas.diario03[11] = textos03[11];
        datas.diario03[12] = textos03[12];
        datas.diario03[13] = textos03[13];
        datas.diario03[14] = textos03[14];
        datas.diario03[15] = textos03[15];
        datas.diario03[16] = textos03[16];
        datas.diario03[17] = textos03[17];
        datas.diario03[18] = textos03[18];
        datas.diario03[19] = textos03[19];
        datas.diario03[20] = textos03[20];
        datas.diario03[21] = textos03[21];
        datas.diario03[22] = textos03[22];
        datas.diario03[23] = textos03[23];
    }


    private void salvarquartoCapitulo()
    {
        datas.diario04[0] = textos[1];
        datas.diario04[1] = textos[2];
        datas.diario04[2] = textos[3];
        datas.diario04[3] = textos[4];
        datas.diario04[4] = textos[5];
        datas.diario04[5] = textos[6];
        datas.diario04[6] = textos[7];
        datas.diario04[7] = textos[8];
        datas.diario04[8] = textos[9];
        datas.diario04[9] = textos[10];
        datas.diario04[10] = textos[11];
        datas.diario04[11] = textos[12];
        datas.diario04[12] = textos[13];
        datas.diario04[13] = textos[14];
        datas.diario04[14] = textos[15];
        datas.diario04[15] = textos[16];
        datas.diario04[16] = textos[17];
        datas.diario04[17] = textos[18];
        datas.diario04[18] = textos[19];
        datas.diario04[19] = textos[20];
        datas.diario04[20] = textos[21];
        datas.diario04[21] = textos[22];
        datas.diario04[22] = textos[23];
        datas.diario04[23] = textos[24];

    }

    private void salvar04p2()
    {
        datas.diario02[0] = textos04[0];
        datas.diario02[1] = textos04[1];
        datas.diario02[2] = textos04[2];
        datas.diario02[3] = textos04[3];
        datas.diario02[4] = textos04[4];
        datas.diario02[5] = textos04[5];
        datas.diario02[6] = textos04[6];
        datas.diario02[7] = textos04[7];
        datas.diario02[8] = textos04[8];
        datas.diario02[9] = textos04[9];
        datas.diario02[10] = textos04[10];
        datas.diario02[11] = textos04[11];
        datas.diario02[12] = textos04[12];
        datas.diario02[13] = textos04[13];
        datas.diario02[14] = textos04[14];
        datas.diario02[15] = textos04[15];
        datas.diario02[16] = textos04[16];
        datas.diario02[17] = textos04[17];
        datas.diario02[18] = textos04[18];
        datas.diario02[19] = textos04[19];
        datas.diario02[20] = textos04[20];
        datas.diario02[21] = textos04[21];
        datas.diario02[22] = textos04[22];
        datas.diario02[23] = textos04[23];

    }


    private void salvar05()
    {
        datas.diario04[0] = textos05[0];
        datas.diario04[1] = textos05[1];
        datas.diario04[2] = textos05[2];
        datas.diario04[3] = textos05[3];
        datas.diario04[4] = textos05[4];
        datas.diario04[5] = textos05[5];
        datas.diario04[6] = textos05[6];
        datas.diario04[7] = textos05[7];
        datas.diario04[8] = textos05[8];
        datas.diario04[9] = textos05[9];
        datas.diario04[10] = textos05[10];
        datas.diario04[11] = textos05[11];
        datas.diario04[12] = textos05[12];
        datas.diario04[13] = textos05[13];
        datas.diario04[14] = textos05[14];
        datas.diario04[15] = textos05[15];
        datas.diario04[16] = textos05[16];
        datas.diario04[17] = textos05[17];
        datas.diario04[18] = textos05[18];
        datas.diario04[19] = textos05[19];
        datas.diario04[20] = textos05[20];
        datas.diario04[21] = textos05[21];
        datas.diario04[22] = textos05[22];
        datas.diario04[23] = textos05[23];
    }

}

// 0 segunda 2 terca 3 quarta 4 quinta

// 4 = 0
// 3 = 3
// 0 = 2
// 2 = 4