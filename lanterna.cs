using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class lanterna : MonoBehaviour
{

    bool espera;
    public bool pode;
    GameObject visualizarr, lanternaa, canvass,comida, bebida, remedio;
    Color inteira, meia, vazia;
    int numero;

    public bool[] usar;

    GameObject image01, image02, image03, image04, canvasss;
    public GameObject[] botao01;
    public int cont01, cont02, cont03;

    [SerializeField]
    trailer oi;
    [SerializeField]
    GameObject cameraa, playerrr;
    [SerializeField]
    float velocidade;

    Quaternion quatro;

    float x, y, z, w, mouse;

    // Start is called before the first frame update
    void Start()
    {

        canvasss = GameObject.Find("Canvas");
        cont01 = 0;

        inteira.a = 255;
        inteira.r = 255;
        inteira.g = 255;
        inteira.b = 255;

        vazia.a = 0;
        vazia.r = 255;
        vazia.g = 255;
        vazia.b = 255;


        image01 = GameObject.Find("botao01Menu");
        image02 = GameObject.Find("botao02Menu");
        image03 = GameObject.Find("botao03Menu");
        image04 = GameObject.Find("botao04Menu");
        canvass = GameObject.Find("Canvas");

        
            botao01[0] = GameObject.Find("botaoUsar01");
        if (botao01[0] != null)
        {

            botao01[0].SetActive(false);
            botao01[1] = GameObject.Find("botaoUsar02");
            botao01[1].SetActive(false);
            botao01[2] = GameObject.Find("botaoUsar03");
            botao01[2].SetActive(false);
            botao01[3] = GameObject.Find("botaoUsar04");
            botao01[3].SetActive(false);
            botao01[4] = GameObject.Find("removerBotao01");
            botao01[5] = GameObject.Find("removerBotao02");
            botao01[6] = GameObject.Find("removerBotao03");
            botao01[7] = GameObject.Find("removerBotao04");
        }

        


        usar[0] = false;
        usar[1] = false;
        usar[2] = false;
        usar[3] = false;


        
        comida = canvass.GetComponent<objetivos>().comida;
        bebida = canvass.GetComponent<objetivos>().bebida;
        remedio = canvass.GetComponent<objetivos>().remedio;

        meia.a = 0.153f;
        meia.b = 255;
        meia.g = 255;
        meia.r = 255;

        numero = 1;

        lanternaa = GameObject.Find("lanterninha");
        visualizarr = GameObject.Find("sensor");
        pode = false;
        espera = false;
        gameObject.GetComponent<Light>().enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        mouse = Input.GetAxis("Mouse ScrollWheel");

        if(mouse < 0)
        {
            numero++;
        }
        else if (mouse > 0)
        {
            numero--;
        }
        if(numero > 4)
        {
            numero = 1;
        }
        if(numero < 1)
        {
            numero = 4;
        }

        x = cameraa.transform.rotation.x;
        y = playerrr.transform.rotation.y;
        z = cameraa.transform.rotation.z;
        w = cameraa.transform.rotation.w;


        quatro = new Quaternion(x, y, z, w);
        
            transform.position = cameraa.transform.position;

            transform.rotation = Quaternion.Lerp(transform.rotation, quatro, velocidade * Time.deltaTime);

        



        menusinho();
        novinho();

        if(oi != null)
        {
            if (oi.ativado == false)
            {
                selecao();
            }
        }
        else if(oi == null)
        {
            selecao();
        }
       
        



        conferirColor();






        if (usar[0] == true || usar[1] == true || usar[2] == true || usar[3] == true)
        {
            tirar();
        }
       

        pode = visualizarr.GetComponent<visualizar>().tomou04;

        
        if(pode == true)
        {
           
        }

    }



    private void menusinho()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            numero = 1;
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            numero = 2;
        }
        if(Input.GetKeyDown(KeyCode.Alpha3))
        {
            numero = 3;
        }
        if(Input.GetKeyDown(KeyCode.Alpha4))
        {
            numero = 4;
        }
    }


    private void novinho()
    {
        if(numero == 1 && pode == true)
        {
            lanternaa.GetComponent<Image>().color = inteira;
            if (Input.GetKeyDown(KeyCode.Mouse1) && pode == true)
            {             
                    usar01();
            }
        }
        else if (numero != 1 && pode == true)
        {
            lanternaa.GetComponent<Image>().color = meia;
            gameObject.GetComponent<Light>().enabled = false;
            espera = false;
        }
        if(numero == 2 && visualizarr.GetComponent<visualizar>().tomou02 == true)
        {
            comida.GetComponent<Image>().color = inteira;
            if (Input.GetKeyDown(KeyCode.Mouse1))
            {
                usar02();
            }
        }
        else if (numero != 2 && visualizarr.GetComponent<visualizar>().tomou02 == true)
        {
            comida.GetComponent<Image>().color = meia;
        }
        if(numero == 3 && visualizarr.GetComponent<visualizar>().tomou03 == true)
        {
            bebida.GetComponent<Image>().color = inteira;
            if (Input.GetKeyDown(KeyCode.Mouse1))
            {
                usar03();
            }
        }
        else if (numero != 3 && visualizarr.GetComponent<visualizar>().tomou03 == true)
        {
            bebida.GetComponent<Image>().color = meia;
        }
        if(numero == 4 && visualizarr.GetComponent<visualizar>().tomou == true)
        {
            remedio.GetComponent<Image>().color = inteira;
            if (Input.GetKeyDown(KeyCode.Mouse1) )
            {
                usar04();
            }
        }
        else if (numero != 4 && visualizarr.GetComponent<visualizar>().tomou == true)
        {
            remedio.GetComponent<Image>().color = meia;
        }
    }


   private void selecao()
    {
        if(numero == 1)
        {
            image01.GetComponent<Image>().enabled = true;
        }
        else if (numero != 1)
        {
            image01.GetComponent<Image>().enabled = false;
        }
        if(numero == 2)
        {
            image02.GetComponent<Image>().enabled = true;
        }
        else if(numero != 2)
        {
            image02.GetComponent<Image>().enabled = false;
        }
        if(numero == 3)
        {
            image03.GetComponent<Image>().enabled = true;
        }
        else if(numero != 3)
        {
            image03.GetComponent<Image>().enabled = false;
        }
        if(numero == 4)
        {
            image04.GetComponent<Image>().enabled = true;
        }
        else if(numero != 4)
        {
            image04.GetComponent<Image>().enabled = false;
        }
    }


    public void usarItem()
    {
        numero = 1;
        if(pode == true)
        {
            if (usar[0] == false && pode == true)
            {
                numero = 1;
                botao01[0].SetActive(true);
                usar[0] = true;
            }
            else if (usar[0] == true)
            {
                botao01[0].SetActive(false);
                usar[0] = false;
            }
        }
        
    }

    public void usarItemDois()
    {
        numero = 2;
        if (visualizarr.GetComponent<visualizar>().tomou02 == true)
        {
            if (usar[1] == false && visualizarr.GetComponent<visualizar>().tomou02 == true)
            {
                numero = 2;
                botao01[1].SetActive(true);
                usar[1] = true;
            }
            else if (usar[1] == true || botao01[5].GetComponent<menuInventario>().fechar == false)
            {
                botao01[1].SetActive(false);
                usar[1] = false;
            }
        }
        
    }

    public void usarItemTres()
    {
        numero = 3;
        if (visualizarr.GetComponent<visualizar>().tomou03 == true)
        {
            if (usar[2] == false && visualizarr.GetComponent<visualizar>().tomou03 == true)
            {
                numero = 3;
                botao01[2].SetActive(true);
                usar[2] = true;
            }
            else if (usar[2] == true || botao01[6].GetComponent<menuInventario>().fechar == false)
            {
                botao01[2].SetActive(false);
                usar[2] = false;
            }
        }
        
    }

    public void usarItemQuatro()
    {
        numero = 4;
        if (visualizarr.GetComponent<visualizar>().tomou == true)
        {
            if (usar[3] == false && visualizarr.GetComponent<visualizar>().tomou == true)
            {
                numero = 4;
                botao01[3].SetActive(true);
                usar[3] = true;
            }
            else if (usar[3] == true || botao01[7].GetComponent<menuInventario>().fechar == false)
            {
                botao01[3].SetActive(false);
                usar[3] = false;
            }
        }
       
    }

    private void tirar()
    {
        
        if (botao01[4].GetComponent<menuInventario>().fechar == false)
        {
            botao01[0].SetActive(false);
            usar[0] = false;
            
        }

            if (botao01[5].GetComponent<menuInventario>().fechar == false)
        {
            botao01[1].SetActive(false);
            usar[1] = false;
        }

        if (botao01[6].GetComponent<menuInventario>().fechar == false)
        {
            botao01[2].SetActive(false);
            usar[2] = false;
        }


            if (botao01[7].GetComponent<menuInventario>().fechar == false)
        {
            botao01[3].SetActive(false);
            usar[3] = false;
        }
    }


    public void usar01()
    {
        if (espera == false)
        {
      
                gameObject.GetComponent<Light>().enabled = true;
                espera = true;
            
            
        }
        else
        {

                gameObject.GetComponent<Light>().enabled = false;
                espera = false;
            
            
        }
    }


    public void usar02()
    {
        cont01 = 1;
        comida.GetComponent<Image>().color = vazia;
        if(comida.GetComponent<Image>().color == vazia)
        {
            canvasss.GetComponent<menuPause>().fecharInventario();
            visualizarr.GetComponent<visualizar>().tomou02 = false;
        }
        
    }

    public void usar03()
    {
        cont02 = 1;
        bebida.GetComponent<Image>().color = vazia;
        if (bebida.GetComponent<Image>().color == vazia)
        {
            canvasss.GetComponent<menuPause>().fecharInventario();
            visualizarr.GetComponent<visualizar>().tomou03 = false;
        }
    }
    public void usar04()
    {
        cont03 = 1;
        remedio.GetComponent<Image>().color = vazia;
        if (remedio.GetComponent<Image>().color == vazia)
        {
            canvasss.GetComponent<menuPause>().fecharInventario();
            visualizarr.GetComponent<visualizar>().tomou = false;
        }
    }


    private void conferirColor()
    {
        if (cont01 == 1)
        {
            comida.GetComponent<Image>().color = vazia;
        }
        if (cont02 == 1)
        {
            bebida.GetComponent<Image>().color = vazia;
        }
        if (cont03 == 1)
        {
            remedio.GetComponent<Image>().color = vazia;
        }
    }

}
