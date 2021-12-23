using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class objetivos : MonoBehaviour
{

    public GameObject notificacaos, notificacaoMestres, remedioosss, sensorrr, destroir, escurecerdor;

    public GameObject objetivo01, objetivo02, objetivo03, objetivo04, objetivo05, objetivo06, objetivo07,objetivo08;

    public GameObject comida, bebida, remedio, painel;

    public GameObject menuItem, portoes;

    [SerializeField]
    Transform riscoo,novidades;

    [SerializeField]
    Color transparente, preto;

    menuPause menus;

    [SerializeField]
    GameObject player;

    Graphic visivel;
    Color viu;

    public Text topicos;
    public string escrita;
    public bool podedormir, mudar, apagao;
    public string topicos01, topico02, topico03, topico04, topico05, topico06, topico07, topico08, rasura01, rasura02, rasura03, rasura04, rasura05, rasura06, rasura07,rasura08;
    public int cont ,cont02, contmissao03, contmissao02;

    public int cont1, cont2, cont3, cont4, cont5, cont6, cont07,cont08,cont09;


    [SerializeField]
    string key01, key02, key03, key04, key05, key06, key07, key08;

    [SerializeField]
    string rkey01, rkey02, rkey03, rkey04, rkey05, rkey06, rkey07, rkey08;

    //musica ambiente


    AudioSource musica;
    [SerializeField]
    float vuluminho;

    public bool tocarMusica, mais, menos, voltar, inicoMusica, fimMusica, jaera, semana05;


    // Start is called before the first frame update
    void Start()
    {
        musica = GetComponent<AudioSource>();
        riscoo = notificacaoMestres.GetComponent<notificacaoMestre>().transform.Find("Image");
        novidades = notificacaoMestres.GetComponent<notificacaoMestre>().transform.Find("Text (1)");
        menus = GetComponent<menuPause>();

        if (key01 != null)
        {

            topicos01 = GameMultiLang.GetTraduction(key01);
            topico02 = GameMultiLang.GetTraduction(key02);
            topico03 = GameMultiLang.GetTraduction(key03);
            topico04 = GameMultiLang.GetTraduction(key04);
            topico05 = GameMultiLang.GetTraduction(key05);
            topico06 = GameMultiLang.GetTraduction(key06);
            topico07 = GameMultiLang.GetTraduction(key07);
            topico08 = GameMultiLang.GetTraduction(key08);

            rasura01 = GameMultiLang.GetTraduction(rkey01);
            rasura02 = GameMultiLang.GetTraduction(rkey02);
            rasura03 = GameMultiLang.GetTraduction(rkey03);
            rasura04 = GameMultiLang.GetTraduction(rkey04);
            rasura05 = GameMultiLang.GetTraduction(rkey05);
            rasura06 = GameMultiLang.GetTraduction(rkey06);
            rasura07 = GameMultiLang.GetTraduction(rkey07);
            rasura08 = GameMultiLang.GetTraduction(rkey08);

        }






        player = GameObject.FindGameObjectWithTag("Player");
       // menuItem = GameObject.Find("Spot Light");
        viu.a = 255;
        viu.r = 255;
        viu.g = 255;
        viu.b = 255;

        cont = 0;
        escrita = topicos01 + System.Environment.NewLine + topico02 + System.Environment.NewLine + topico03 + System.Environment.NewLine + topico04 + System.Environment.NewLine + topico05;
        topicos.text = escrita;
        podedormir = false;
        cont02 = 0;
        mudar = false;

        escurecerdor = GameObject.Find("escurecer");

        cont1 = 0;
        cont2 = 0;
        cont3 = 0;
        cont4 = 0;
        cont5 = 0;
        cont6 = 0;
        cont07 = 0;
        cont08 = 0;
        cont09 = 0;

        contmissao03 = 0;
        contmissao02 = 0;


        objetivo01.GetComponent<Text>().text = topicos01;
        objetivo02.GetComponent<Text>().text = topico02;
        objetivo03.GetComponent<Text>().text = topico03;
        objetivo04.GetComponent<Text>().text = topico04;
        objetivo05.GetComponent<Text>().text = topico05;
        objetivo06.GetComponent<Text>().text = topico06;
        objetivo07.GetComponent<Text>().text = topico07;
        objetivo08.GetComponent<Text>().text = topico08;

        
    }

    IEnumerator aumentar()
    {
        yield return new WaitForSeconds(1f);
        if(tocarMusica == true && vuluminho < 1)
        {
            vuluminho = vuluminho + 0.1f;
        }        
        mais = false;
        print("diminuindoMusica");
    }
    IEnumerator diminuir()
    {
        yield return new WaitForSeconds(1f);
        if(tocarMusica == false && vuluminho > 0)
        {
            vuluminho = vuluminho - 0.1f;
        }
        
        menos = false;
        print("diminuindoMusica");
    }
    IEnumerator voltarSom()
    {
        yield return new WaitForSeconds(110);
        tocarMusica = true;
        voltar = false;
        print("voltandoMusica");
    }
    IEnumerator sairSom()
    {
        yield return new WaitForSeconds(180);
        tocarMusica = false;
        fimMusica = false;
        print("saindoMusica");
    }

    // Update is called once per frame
    void Update()
    {


        //musica ambiente

        musica.volume = vuluminho;

        if(vuluminho < 0)
        {
            vuluminho = 0;
        }
        else if(vuluminho > 1)
        {
            vuluminho = 1;
        }

        if (tocarMusica == true && mais == false)
        {
            mais = true;
            StartCoroutine(aumentar());
        }
        else if(tocarMusica == false && menos == false)
        {
            menos = true;
            StartCoroutine(diminuir());
        }
        if(tocarMusica == false && voltar ==false && inicoMusica == true)
        {
            voltar = true;
            StartCoroutine(voltarSom());
        }
        if (cont6 != 0 && inicoMusica == false && semana05 == false)
        {
            inicoMusica = true;
            tocarMusica = true;
        }
        if(tocarMusica == true && fimMusica == false)
        {
            fimMusica = true;
            StartCoroutine(sairSom());
        }

        if(player.GetComponent<acabouTempo>().inimigoVei != null && jaera == false)
        {
            jaera = true;
            tocarMusica = false;
        }



        if (menus.agenda.activeSelf == true)
        {
            notificacaoMestres.GetComponent<Image>().enabled = false;
            notificacaos.GetComponent<Text>().color = transparente;
            riscoo.GetComponent<Image>().enabled = false;
            if(novidades != null)
            {
                novidades.GetComponent<Text>().enabled = false;
            }
        }
        else
        {
            notificacaoMestres.GetComponent<Image>().enabled = true;
            notificacaos.GetComponent<Text>().color = preto;
            riscoo.GetComponent<Image>().enabled = true;
            if (novidades != null)
            {
                novidades.GetComponent<Text>().enabled = true;
            }
        }


        if(sensorrr.GetComponent<visualizar>().objetos != null)
        {
            if (sensorrr.GetComponent<visualizar>().objetos.name == "bebida" || sensorrr.GetComponent<visualizar>().objetos.name == "comida")
            {
                destroir = sensorrr.GetComponent<visualizar>().objetos;
            }
        }
          
        
       



        if (cont6 == 0)
        {
            //escrita = topicos01 + System.Environment.NewLine + topico02 + System.Environment.NewLine + topico03 + System.Environment.NewLine + topico04 +System.Environment.NewLine + topico05;


            

        }


        topicosClass();
        obejtivosPrioritarios();

        if (cont02 == 0 && contmissao03 == 1 && contmissao02 == 1)
        {
            cont2 = 1;
            cont02++;

        }

        /*
        if(cont == 1)
        {
            if(cont02 == 0)
            {
                notificacaoMestres.SetActive(true);
                notificacaoMestres.GetComponent<notificacaoMestre>().trocar = true;
                notificacaos.GetComponent<Text>().text = topicos01;
                cont02++;
            }
           


            // escrita = "1 Achar a chaves" + System.Environment.NewLine + "2 Encontrar os remedios" + System.Environment.NewLine + "3 Analisar os objetos" + System.Environment.NewLine + "4 explorar os comodos";
            escrita = rasura01 + System.Environment.NewLine + topico02 + System.Environment.NewLine + topico03 + System.Environment.NewLine + topico04 + System.Environment.NewLine + topico05;
        }
        if (cont == 2)
        {
            if (cont02 == 1)
            {
                //notificacaoMestres.SetActive(true);
                notificacaoMestres.GetComponent<notificacaoMestre>().trocar = true;
                notificacaos.GetComponent<Text>().text = topico02;
                cont02++;
            }


            escrita = rasura01 + System.Environment.NewLine + rasura02 + System.Environment.NewLine + topico03 + System.Environment.NewLine + topico04 + System.Environment.NewLine + topico05;
        }
        if(cont == 3)
        {

            if (cont02 == 2)
            {
                //notificacaoMestres.SetActive(true);
                notificacaoMestres.GetComponent<notificacaoMestre>().trocar = true;
                notificacaos.GetComponent<Text>().text = topico03;
                cont02++;
            }



            escrita = rasura01 + System.Environment.NewLine + rasura02 + System.Environment.NewLine + rasura03 + System.Environment.NewLine + topico04 + System.Environment.NewLine + topico05;
        }
        if(cont == 4)
        {

            if (cont02 == 3)
            {
                //notificacaoMestres.SetActive(true);
                notificacaoMestres.GetComponent<notificacaoMestre>().trocar = true;
                notificacaos.GetComponent<Text>().text = topico04;
                Destroy(remedioosss.gameObject);
                podedormir = true;
                cont02++;
                

            }



            escrita = rasura01 + System.Environment.NewLine + rasura02 + System.Environment.NewLine + rasura03 + System.Environment.NewLine + rasura04 + System.Environment.NewLine + topico05;
        }
        if(cont == 5)
        {
            if (cont02 == 4)
            {
                //notificacaoMestres.SetActive(true);
                notificacaoMestres.GetComponent<notificacaoMestre>().trocar = true;
                notificacaos.GetComponent<Text>().text = topico05;
                cont02++;
            }



            escrita = rasura01 + System.Environment.NewLine + rasura02 + System.Environment.NewLine + rasura03 + System.Environment.NewLine + rasura04 + System.Environment.NewLine + rasura05;
        }

        topicos.text = escrita;
        */
    }



    public void topicosClass()
    {
        if(cont1 == 1)
        {

            notificacaoMestres.SetActive(true);
            notificacaoMestres.GetComponent<notificacaoMestre>().trocar = true;
            notificacaos.GetComponent<Text>().text = topicos01;
           
            objetivo01.GetComponent<Text>().text = rasura01;
            cont6++;
            cont1++;
            if (escurecerdor.GetComponent<escurecer>().cenaAtual == "semana03")
            {
                apagao = true;
                portoes.GetComponent<porta>().chave = true;
            }

        }

        if(cont2 == 1)
        {


            notificacaoMestres.SetActive(true);
            notificacaoMestres.GetComponent<notificacaoMestre>().trocar = true;
            notificacaos.GetComponent<Text>().text = topico02;
            
            objetivo02.GetComponent<Text>().text = rasura02;
            cont6++;
            cont2++;
        }


        if(cont3 == 1)
        {
            notificacaoMestres.SetActive(true);
            notificacaoMestres.GetComponent<notificacaoMestre>().trocar = true;
            notificacaos.GetComponent<Text>().text = topico03;
           
            objetivo03.GetComponent<Text>().text = rasura03;
            cont6++;
            cont3++;
        }

        if(cont4 == 1)
        {
            notificacaoMestres.SetActive(true);
            notificacaoMestres.GetComponent<notificacaoMestre>().trocar = true;
            notificacaos.GetComponent<Text>().text = topico04;
            if(escurecerdor.GetComponent<escurecer>().cenaAtual == "semana01")
            {
                escurecerdor.GetComponent<Animator>().SetBool("tomouBanho", true);
            }
            

            //mudar = true;

            objetivo04.GetComponent<Text>().text = rasura04;
            cont6++;
            cont4++;
        }

        if(cont5 == 1)
        {

            notificacaoMestres.SetActive(true);
            notificacaoMestres.GetComponent<notificacaoMestre>().trocar = true;
            notificacaos.GetComponent<Text>().text = topico05;
           
            objetivo05.GetComponent<Text>().text = rasura05;
            cont5++;
        }


        if (cont4 > 0 && cont3 > 0 && cont2 > 0 && cont1 > 0 && cont07 > 0 && cont08 > 0 && cont09 > 0 
            || cont3 > 0 && cont2 > 0 && cont1 > 0 && cont07 > 0 && cont08 > 0 && cont09 > 0 && escurecerdor.GetComponent<escurecer>().cenaAtual == "semana05")
        {
            notificacaoMestres.SetActive(true);
            podedormir = true;
        }

        /*if(mudar == true)
        {
            escurecerdor.GetComponent<Animator>().SetBool("tomouBanho", false);
            mudar = false;
        }*/

    }




    private void obejtivosPrioritarios()
    {


        if (cont07 == 0 && menuItem.GetComponent<lanterna>().cont01 == 1)
        {
            notificacaoMestres.SetActive(true);
            notificacaoMestres.SetActive(true);
            notificacaoMestres.GetComponent<notificacaoMestre>().trocar = true;
            notificacaos.GetComponent<Text>().text = topico06;
            objetivo06.GetComponent<Text>().text = rasura06;
            cont6++;
            cont07++;
            
            //comida.GetComponent<Image>().color = viu;

           // Destroy(destroir);
            sensorrr.GetComponent<sensor>().colidiu = false;
        }


        if (cont08 == 0 && menuItem.GetComponent<lanterna>().cont02 == 1)
        {
            notificacaoMestres.SetActive(true);
            notificacaoMestres.GetComponent<notificacaoMestre>().trocar = true;
            notificacaos.GetComponent<Text>().text = topico07;
            objetivo07.GetComponent<Text>().text = rasura07;
            cont6++;
            cont08++;
            
            //bebida.GetComponent<Image>().color = viu;
            //Destroy(destroir);
            sensorrr.GetComponent<sensor>().colidiu = false;

        }


        if (cont09 == 0 && menuItem.GetComponent<lanterna>().cont03 == 1)
        {
            notificacaoMestres.SetActive(true);
            notificacaoMestres.GetComponent<notificacaoMestre>().trocar = true;
            notificacaos.GetComponent<Text>().text = topico08;
            //Destroy(remedioosss.gameObject);

            sensorrr.GetComponent<sensor>().colidiu = false;

            //remedio.GetComponent<Image>().color = viu;
            player.GetComponent<acabouTempo>().voltou = true;
            objetivo08.GetComponent<Text>().text = rasura08;
            cont6++;
            cont09++;




        }


    }


}
