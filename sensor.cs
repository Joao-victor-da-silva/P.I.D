using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class sensor : MonoBehaviour
{

    public GameObject interagir, objeto, booleano, items, testo, visualizando, dormindoo, sensorSegundo, missaoo01, missao02, missao03 ,player, naoColide;
    Transform posicao01;
    public Transform posicao02;
    public bool pegou, sortarr, podePegar, colidiu;
    Rigidbody gravidadeObjeto;
    BoxCollider objetoColicao, estaCaixa;
    objeto item;
    public int cont;
    SphereCollider esfera;


    public float alcansandoo;

    float bx, by, bz, nbz, bcx, bcy, bcz, nbcz, esferaZ, esferaAtual, esferaX, esferaY , esferaSize, esferaCenter;


    //

    [SerializeField]
    AudioClip song;

    AudioSource audios;
    int contSong;

    [SerializeField]
    public GameObject tutorial01, tutorial02, tutorial03, tutorial04, tutorial05, tutorial07, tutorial08;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(oi());
        audios = GetComponent<AudioSource>();
        naoColide = GameObject.Find("colicaooo");
        esfera = sensorSegundo.GetComponent<SphereCollider>();
        interagir.SetActive(false);
        pegou = false;
        sortarr = false;
        cont = 0;
        objeto =  null;

        colidiu = false;

        estaCaixa = GetComponent<BoxCollider>();

        //bx = estaCaixa.size.x;
        //by = estaCaixa.size.y;
        //bz = estaCaixa.size.z;
        nbz = bz;
        //bcx = estaCaixa.center.x;
        //bcy = estaCaixa.center.y;
        //bcz = estaCaixa.center.z;
        nbcz = bcz;
        //esferaZ = esfera.center.z; aueterei 09/10/2020
        podePegar = false;
        //esferaX = esfera.center.x; aueterei 09 / 10 / 2020
        //esferaY = esfera.center.y; aueterei 09 / 10 / 2020

    }

    // Update is called once per frame
    void Update()
    {

        concertar();


        if (pegou == true && contSong == 0)
        {
            contSong = 1;
            audios.clip = song;
            audios.Play();
        }
        if(pegou == false)
        {
            contSong = 0;
            if (audios.clip == song)
            {
                audios.Stop();
            }
        }


        if(objeto != null)
        {
            if (objeto.tag == "Untagged")
            {
                pegou = false;
            }
        }
       

        podePegar = sensorSegundo.GetComponent<sensor02>().pegadinha;

        //Physics.IgnoreCollision(missaoo01.GetComponent<Collider>(), GetComponent<Collider>());
        //Physics.IgnoreCollision(missao02.GetComponent<Collider>(), GetComponent<Collider>());
        //Physics.IgnoreCollision(missao03.GetComponent<Collider>(), GetComponent<Collider>());
        //Physics.IgnoreCollision(player.GetComponent<Collider>(), GetComponent<Collider>());
        //Physics.IgnoreCollision(naoColide.GetComponent<Collider>(), GetComponent<Collider>());

        objeto = sensorSegundo.GetComponent<sensor02>().obetinho;

        if(testo == null)
        {
            interagir.SetActive(false);
        }

        if(colidiu == true )
        {
            alcanceDiminuir();
        }
        else if(colidiu == false)
        {
            alcance();
        }
        
        

        //testando

        if (nbz < bz && nbcz < bcz)
        {

          //alcance();


        }


        corrigirSensor();

        if (podePegar == true && sortarr == false || pegou == true && sortarr == false)
        {

            if (Input.GetKeyDown(KeyCode.Mouse0))
            {

                pegarObjeto();
            }

            if (Input.GetKeyUp(KeyCode.Mouse0))
            {

                soltarObjeto();

            }


        }




            if (visualizando.GetComponent<visualizar>().verificando == true || pegou == true)
        {
            interagir.SetActive(false);
        }



        if (booleano.activeSelf == false)
        {
            


            if (objeto != null)
            {
                item = objeto.GetComponent<objeto>();
                sortarr = item.soltar;
            }

            if (sortarr == true)
            {
                soltarObjeto();
            }

            if (pegou == true)
            {
                /*if (cont == 0)
                {
                    
                    cont++;
                }*/

                if(objeto != null && posicao02 != null)
                {
                    objeto.transform.position = posicao02.position;
                } 
                

            }
            if (pegou == false)
            {
                cont = 0;
            }

        }

    }






    private void OnTriggerEnter(Collider other)
    {


       // if (other.tag != "objeto" && other.tag != "olhar" && other.tag != "Player" && other.tag != "MainCamera" && other.tag != "interagir")
        //{

            colidiu = true;
     
        //}



        if (booleano.activeSelf == false)
        {


            //Abrir Porta

            


            //Analisar Item



            if (other.tag == "objeto")
            {
                
                  if(cont == 0)
                {
                   // objeto = other.gameObject;
                    cont = 1;
                }
                  


                   //objeto = other.gameObject;
                    //posicao01 = objeto.transform; < ------------------ alterou aqui
                    if(objeto != null)
                     {
                        item = objeto.GetComponent<objeto>();
                     }
                   
               // podePegar = true;
                /*
                    if (Input.GetKeyDown(KeyCode.Mouse0))
                    {

                    pegarObjeto();
                    }

                if (Input.GetKeyUp(KeyCode.Mouse0))
                {

                    soltarObjeto();

                }
                */

            }
            
        }

    }






    private void OnTriggerStay(Collider other)
    {
        //////////////

       

        ////////


        


        //if (other.tag != "objeto" && other.tag != "olhar" && other.tag != "Player" && other.tag != "MainCamera" && other.tag != "interagir" )
        //{
            //  alcanceDiminuir();
            colidiu = true;
           

        //}




        if (booleano.activeSelf == false)
        {


            

            //Analisar Item



            if (other.tag == "objeto")
            {

                
                if (cont == 0)
                {
                    //objeto = other.gameObject;
                    cont = 1;
                }



               


                //objeto = other.gameObject;
               // posicao01 = objeto.transform; <--------- alterou aqui
               if(objeto != null)
                {
                    item = objeto.GetComponent<objeto>();
                }
                  
                /*
                    if (Input.GetKeyDown(KeyCode.Mouse0))
                    {

                        pegarObjeto();
                    }
                    if (Input.GetKeyUp(KeyCode.Mouse0))
                    {

                        soltarObjeto();
                    }
                    */
                
            }
        }
        
    }

    private void OnTriggerExit(Collider other)
    {
        if(colidiu == true)
        {
            colidiu = false;
           
        }
       

        if (booleano.activeSelf == false)
        {
            if (other.tag == "interagir" || other.tag == "objeto" || other.tag == "olhar")
            {
               // podePegar = false;
                interagir.SetActive(false);
            }
            if(pegou == false)
            {
                //objeto = null;
            }
            
            
        }
    }


    public void pegarObjeto()
    {
        if (booleano.activeSelf == false)
        {


            
           gravidadeObjeto = objeto.GetComponent<Rigidbody>();
           objetoColicao = objeto.GetComponent<BoxCollider>();



            
            objetoColicao.isTrigger = true;
            gravidadeObjeto.isKinematic = true;
            objeto.layer = 11;
            pegou = true;

        }
    }


    public void soltarObjeto()
    {

        if (booleano.activeSelf == false)
        {
            if (objeto != null)
            {
                    gravidadeObjeto = objeto.GetComponent<Rigidbody>();
                    objetoColicao = objeto.GetComponent<BoxCollider>();
                objetoColicao.isTrigger = false;
                gravidadeObjeto.isKinematic = false;
                objeto.layer = 0;
                pegou = false;
                
               // objeto.transform.position = posicao01.position; <----- alterou aqui
            }


        }

    }
    
    public void soltarObjetoDefinitivo()
    {
        try
        {
            gravidadeObjeto = objeto.GetComponent<Rigidbody>();
            objetoColicao = objeto.GetComponent<BoxCollider>();
            objetoColicao.isTrigger = false;
            gravidadeObjeto.isKinematic = false;
            objeto.layer = 0;
            pegou = false;
            print("caraiiid eu Porra");
        }
        catch
        {

        }
    }
    

    private void alcance()
    {
        
         if(colidiu == false)

        {
            if (nbz < bz && nbcz < bcz)
            {
               
                    nbcz = nbcz + alcansandoo ;
                    nbz = nbz + alcansandoo ;
                    //estaCaixa.size = new Vector3(bx, by, nbz);
                    //estaCaixa.center = new Vector3(bcx, bcy, nbcz);
                
               
            }
        }
        


    }

    private void alcanceDiminuir()
    {
        if(colidiu == true && visualizando.GetComponent<visualizar>().visualizando == false)
        {
            if (nbz > 0 && nbcz > 0)
            {
               
                    nbcz = nbcz - alcansandoo ;
                    nbz = nbz - alcansandoo ;
                    //estaCaixa.size = new Vector3(bx, by, nbz);
                    //estaCaixa.center = new Vector3(bcx, bcy, nbcz);
                
                
            }
        }
        
    }



    private void corrigirSensor()
    {
        /*
         && other.tag != "chao"
          
        bz
        ncz
        esferaZ


        bz -------- esferaZ
        nbz ------- esferaAtual;


        esferaAtual = (esferaZ * nbz) / bz
        esferaSize = (esferaZ * nbz) / bz

        ncz ------- esferaZ
        nbcz ------- esferaAtual


        esferaAtual = (esferaZ * nbcz) / ncz
        esferaCenter = (esferaZ * nbcz) / ncz

        esferaAtual = esferaSize - esferaCenter;

        nbz
        nbcz
        esferaAtual
        
         

        */






        //auterei aquiiii 09/10/2020

        //esferaSize = (esferaZ * nbz) / bz;
        //esferaCenter = (esferaZ * nbcz) / bcz;
        //esferaAtual = esferaSize + esferaCenter;

        //esfera.center = new Vector3(esferaX, esferaY, esferaAtual / 2);



    }



    private void concertar()
    {

        if(objeto != null)
        {
            tutorial01.SetActive(false);
            tutorial02.SetActive(false);
            tutorial03.SetActive(false);
            tutorial04.SetActive(false);
            tutorial05.SetActive(false);
            tutorial07.SetActive(true);
            tutorial08.SetActive(true);
        }
        else if(objeto == null)
        {
            tutorial01.SetActive(true);
            tutorial02.SetActive(true);
            tutorial03.SetActive(true);
            tutorial04.SetActive(true);
            tutorial05.SetActive(true);
            tutorial07.SetActive(false);
            tutorial08.SetActive(false);
        }

    }



    private IEnumerator oi()
    {
        yield return new WaitForSeconds(2f);
        colidiu = false;
        //print("maconha");
        StartCoroutine(oi());
    }

}
