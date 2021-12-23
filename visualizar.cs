using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class visualizar : MonoBehaviour
{

    public GameObject objetos, boleano, sensorial, segurou, titulo, descricao, verificacao, remedio, objetivosss, visualizandoPainel, menuPausar;
    public objeto items;
    public Transform localObjeto, localVisualizar;
    public bool visualizando, fixar, verificando, tomarRemedios, tomou, tomou02, tomou03 ,tomou04, tomou05, tomou06, tomou07, tomou08;
    public BoxCollider caixa;
    public Rigidbody fisica;
    sensor pegando;
    [SerializeField]
    AudioClip song, errou;
    AudioSource audius;

    GameObject lanterninha;

    public int cont, cont02,cont03 , cont04, cont05, cont06, cont007, cont008, cont009;

    
    

    bool chega;
    //numeros objetos
    string nome;
    public  int nanotacoes;
   
    public string AnotCubo, descrcao;

    int contSong, cont07;

    int ncubo, nbloco;

    string pegarObjeto, naoPergar;
    // Start is called before the first frame update
    void Start()
    {

        tomarRemedios = true;
        tomou = true;

        naoPergar = GameMultiLang.GetTraduction("O item não pode ser coletado");
        pegarObjeto = GameMultiLang.GetTraduction("Pegar item pressione Enter");
        audius = GetComponent<AudioSource>();
        lanterninha = GameObject.Find("Lanterna");
        verificando = false;
        nbloco = 0;
        ncubo = 0;
        nanotacoes = 0;
        visualizando = false;
        fixar = false;
        boleano.SetActive(false);
        pegando = sensorial.GetComponent<sensor>();
        cont = 0;
        tomarRemedios = false;
        tomou = false;
        // visualizandoPainel = GameObject.Find("visualizandoPainel");
    }

    // Update is called once per frame
    void Update()
    {

        naoPega();

        if(GetComponent<sensor>().objeto != null)
        {
            objetos = GetComponent<sensor>().objeto;
            caixa = GetComponent<sensor>().objeto.GetComponent<BoxCollider>();
            fisica = GetComponent<sensor>().objeto.GetComponent<Rigidbody>();
        }


        //////////
        if (objetos != null)
        {
            if (tomou05 == true && objetos.tag == "folha")
            {
                tomou05 = false;
                cont06 = 0;
            }
        }




        //////////

        if(visualizando == true && contSong ==0)
        {
            contSong = 1;
            audius.clip = song;
            audius.Play();
        }
        if(visualizando == false)
        {
            contSong = 0;
            if(audius.clip == song)
            {
                audius.Stop();
            }
            
        }
        


        ////
        if(objetos != null)
        {
            if(objetos.tag == "Untagged")
            {
                objetos = null;
            }
        }


        if(fixar == true && objetos != null)
        {
            objetos.transform.position = localVisualizar.transform.position;
        }

        if(objetos != null && visualizando == true)
        {
            if (objetos.name == "Benperidol")
            {

                remedio.GetComponent<Text>().text = naoPergar;

                if (cont == 0)
                {
                    remedio.GetComponent<Text>().text = pegarObjeto;
                    remedio.SetActive(true);
                    if (Input.GetKeyDown(KeyCode.Return))
                    {
                        remedio.SetActive(false);
                        cont++;
                        tomarRemedios = true;
                        tomou = true;
                        Destroy(objetos);
                        gameObject.GetComponent<sensor>().colidiu = false;
                        gameObject.GetComponent<sensor>().pegou = false;
                    }
                }


            }



            else if (objetos.name == "comida")
            {
                remedio.GetComponent<Text>().text = naoPergar;
                if (cont02 == 0)
                {
                    remedio.GetComponent<Text>().text = pegarObjeto;
                    remedio.SetActive(true);
                    if (Input.GetKeyDown(KeyCode.Return))
                    {
                        remedio.SetActive(false);
                        cont02++;
                        tomarRemedios = true;
                        tomou02 = true;
                        Destroy(objetos);
                        gameObject.GetComponent<sensor>().colidiu = false;
                        gameObject.GetComponent<sensor>().pegou = false;
                    }
                }


            }


            else if (objetos.name == "bebida")
            {
                remedio.GetComponent<Text>().text = naoPergar;
                if (cont03 == 0)
                {
                    remedio.GetComponent<Text>().text = pegarObjeto;
                    remedio.SetActive(true);
                    if (Input.GetKeyDown(KeyCode.Return))
                    {
                        remedio.SetActive(false);
                        cont03++;
                        tomarRemedios = true;
                        tomou03 = true;
                        Destroy(objetos);
                        gameObject.GetComponent<sensor>().colidiu = false;
                        gameObject.GetComponent<sensor>().pegou = false;
                    }
                }


            }

            else if (objetos.name == "Lanterna")
            {
                remedio.GetComponent<Text>().text = naoPergar;
                if (cont04 == 0)
                {
                    remedio.GetComponent<Text>().text = pegarObjeto;
                    remedio.SetActive(true);
                    if (Input.GetKeyDown(KeyCode.Return))
                    {
                        remedio.SetActive(false);
                        cont04++;
                        tomarRemedios = true;
                        tomou04 = true;
                        Destroy(objetos);
                        gameObject.GetComponent<sensor>().colidiu = false;
                        gameObject.GetComponent<sensor>().pegou = false;
                    }
                }


            }

            else if (objetos.name == "madeira")
            {
                remedio.GetComponent<Text>().text = naoPergar;
                if (cont007 == 0)
                {
                    remedio.GetComponent<Text>().text = pegarObjeto;
                    remedio.SetActive(true);
                    if (Input.GetKeyDown(KeyCode.Return))
                    {
                        remedio.SetActive(false);
                        cont007++;
                        tomarRemedios = true;
                        tomou06 = true;
                        Destroy(objetos);
                        gameObject.GetComponent<sensor>().colidiu = false;
                        gameObject.GetComponent<sensor>().pegou = false;
                    }
                }


            }



            else if (objetos.name == "velas")
            {
                remedio.GetComponent<Text>().text = naoPergar;
                if (cont008 == 0)
                {
                    remedio.GetComponent<Text>().text = pegarObjeto;
                    remedio.SetActive(true);
                    if (Input.GetKeyDown(KeyCode.Return))
                    {
                        remedio.SetActive(false);
                        cont008++;
                        tomarRemedios = true;
                        tomou07 = true;
                        Destroy(objetos);
                        gameObject.GetComponent<sensor>().colidiu = false;
                        gameObject.GetComponent<sensor>().pegou = false;
                    }
                }


            }



            else if (objetos.tag == "folha")
            {
                if (cont06 == 0)
                {
                    remedio.GetComponent<Text>().text = pegarObjeto;
                    remedio.SetActive(true);
                    if (Input.GetKeyDown(KeyCode.Return))
                    { 
                        objetos.GetComponent<objeto>().naoPode = true;
                    }
                    if (objetos.GetComponent<objeto>().podeDestroir == true)
                    {
                        remedio.SetActive(false);
                        cont06++;
                        tomarRemedios = true;
                        tomou05 = true;
                        Destroy(objetos);
                        gameObject.GetComponent<sensor>().colidiu = false;
                        gameObject.GetComponent<sensor>().pegou = false;
                    }
                    

                }


            }
            else if (objetos.name == "esqueiro")
            {
                remedio.GetComponent<Text>().text = naoPergar;
                if (cont009 == 0)
                {
                    remedio.GetComponent<Text>().text = pegarObjeto;
                    remedio.SetActive(true);
                    if (Input.GetKeyDown(KeyCode.Return))
                    {
                        remedio.SetActive(false);
                        cont009++;
                        tomarRemedios = true;
                        tomou08 = true;
                        if(tomou08 == true)
                        {
                            Destroy(objetos);
                        }
                        
                        gameObject.GetComponent<sensor>().colidiu = false;
                        gameObject.GetComponent<sensor>().pegou = false;
                    }
                }


            }


        
            else
            {
                remedio.GetComponent<Text>().text = naoPergar;
            }


        }



        if(tomarRemedios == true)
        {

            remedio.SetActive(false);
            verificando = false;
            //Cursor.lockState = CursorLockMode.Locked;
            //Time.timeScale = 1;
            visualizandoPainel.SetActive(false);
            titulo.SetActive(false);
            descricao.SetActive(false);
            titulo.GetComponent<Text>().text = null;
            descricao.GetComponent<Text>().text = null;
            ncubo = 0;

            if (pegando.pegou == false)
            {
                boleano.SetActive(false);
                fixar = false;
                objetos.transform.position = items.posicao;
                objetos.transform.rotation = items.rotacao;
                visualizando = false;
                caixa.isTrigger = false;
                if (objetos.tag != "olhar" && objetos.tag != "folha" && objetos.tag != "item")
                {
                    fisica.isKinematic = false;
                }
            }
            else if (pegando.pegou == true)
            {
                boleano.SetActive(false);
                fixar = false;
                objetos.transform.position = segurou.transform.position;
                objetos.transform.rotation = items.rotacao;
                visualizando = false;
                caixa.isTrigger = true;
                if (objetos.tag != "olhar" && objetos.tag != "folha" && objetos.tag != "item")
                {
                    fisica.isKinematic = true;
                }
            }

           
            tomarRemedios = false;

        }

        



        if (objetos != null && Input.GetKeyDown(KeyCode.E) || visualizando == true && Input.GetKeyDown(KeyCode.Escape))
        {
            
             verificacao = objetos;
            

            if (visualizando == false)
            {



                remedio.SetActive(true);
                verificando = true;
                visualizandoPainel.SetActive(true);
                titulo.SetActive(true);
                descricao.SetActive(true);
                //titulo.GetComponent<Text>().text = objetos.name;
                titulo.GetComponent<Text>().text = objetos.GetComponent<objeto>().nomeObjeto;
                descricao.GetComponent<Text>().text = objetos.GetComponent<objeto>().descricao;
                    
                    boleano.SetActive(true);
                    fixar = true;


                    visualizando = true;



                print("aaaaaaaaaaaaaaa");
                    caixa.isTrigger = true;
                if (objetos.tag != "olhar" && objetos.tag != "folha" && objetos.tag != "item")
                {
                    fisica.isKinematic = true;
                }


                nome = objetos.name;


                anotacoes();


                cont05 = 0;
            }

            else
            {
                menuPausar.GetComponent<menuPause>().podePausar = false;

                remedio.SetActive(false);
                verificando = false;
                //Cursor.lockState = CursorLockMode.Locked;
                //Time.timeScale = 1;
                visualizandoPainel.SetActive(false);
                titulo.SetActive(false);
                descricao.SetActive(false);
                titulo.GetComponent<Text>().text = null;
                descricao.GetComponent<Text>().text = null;
                ncubo = 0;

                if (pegando.pegou == false)
                {
                    boleano.SetActive(false);
                    fixar = false;
                    objetos.transform.position = items.posicao;
                    objetos.transform.rotation = items.rotacao;
                    visualizando = false;
                    caixa.isTrigger = false;
                    if (objetos.tag != "olhar" && objetos.tag != "folha" && objetos.tag != "item")
                    {
                        fisica.isKinematic = false;
                    }
                }
                else if(pegando.pegou == true)
                {
                    boleano.SetActive(false);
                    fixar = false;
                    objetos.transform.position = segurou.transform.position;
                    objetos.transform.rotation = items.rotacao;
                    visualizando = false;
                    caixa.isTrigger = true;
                    if (objetos.tag != "olhar" && objetos.tag != "folha" && objetos.tag != "item")
                    {
                        fisica.isKinematic = true;
                    }
                }

                if (cont05 == 0)
                {
                    StartCoroutine(menuPausar.GetComponent<menuPause>().parara());
                    cont05 = 1;
                }

            }

            
        }


        if (objetos == null && Input.GetKeyDown(KeyCode.E) && visualizando == true)
        {

            remedio.SetActive(false);
            verificando = false;
            //Cursor.lockState = CursorLockMode.Locked;
            //Time.timeScale = 1;
            visualizandoPainel.SetActive(false);
            titulo.SetActive(false);
            descricao.SetActive(false);
            titulo.GetComponent<Text>().text = null;
            descricao.GetComponent<Text>().text = null;
            ncubo = 0;

            if (pegando.pegou == false)
            {
                
                boleano.SetActive(false);
                fixar = false;
                //objetos.transform.position = items.posicao;
                //objetos.transform.rotation = items.rotacao;
                visualizando = false;
               // caixa.isTrigger = false;
                //if (objetos.tag != "olhar")
                //{
                    //fisica.isKinematic = false;
                //}
            }
            else if (pegando.pegou == true)
            {
                
                boleano.SetActive(false);
                fixar = false;
                //objetos.transform.position = segurou.transform.position;
                //objetos.transform.rotation = items.rotacao;
                visualizando = false;
                //caixa.isTrigger = true;
              //  if (objetos.tag != "olhar")
               // {
                    //fisica.isKinematic = true;
               // }
            }

        }






    }



    


    private void OnTriggerEnter(Collider other)
    {
        /*
        if (other.tag == "objeto" || other.tag == "olhar")
        {
            objetos = other.gameObject;
            caixa = objetos.GetComponent<BoxCollider>();
            if(objetos.tag != "olhar")
            {
                fisica = objetos.GetComponent<Rigidbody>();
            }
            
            items = objetos.gameObject.GetComponent<objeto>();
            localObjeto = items.local;

            if (Input.GetKeyDown(KeyCode.E))
            {
               
            }


        }
        */
    }
    /*
    private void OnTriggerExit(Collider other)
    {
        
       if(other.tag == "objeto" || other.tag == "olhar")
        {
            if (objetos.tag != "olhar")
            {
                fisica = null;
            }
            objetos = null;
            localObjeto = null;
            caixa = null;
      
        }
        
    }

    */


        private void naoPega()
         {
            if(remedio.GetComponent<Text>().text == naoPergar && visualizando == true && Input.GetKeyDown(KeyCode.Return))
            {
            if(cont07 == 0)
            {
                cont07 = 1;
                audius.Stop();
                audius.clip = errou;
                audius.Play(2);
                print("oi");
            }
     
            }
        if (Input.GetKeyUp(KeyCode.Return))
        {
            cont07 = 0;
           
        }
    }



    public void anotacoes()
    {
        if(objetos.tag == "objeto" || objetos.tag == "olhar")
        {
            if (ncubo == 0 && objetos.GetComponent<objeto>().id == 0)
            {
                //AnotCubo =" esse cubo me lembra MINECRAFT ";
                AnotCubo = objetos.GetComponent<objeto>().anotacao;
                nanotacoes++;
            }
            ncubo = 1;
        }
            
            
            
        


        
               // AnotCubo = " esse outro cubo tambem me lembra";
               
       

        


    }



    




}
