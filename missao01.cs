using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class missao01 : MonoBehaviour
{
    public GameObject objetivo, segundaSala, analizandosss, objetinho, lanternaa;
    int cont, cont02, cont03, cont04, cont05, cont06, cont07, contmissao03, contmissao02;
    string nome;



    // Start is called before the first frame update
    void Start()
    {
        lanternaa = GameObject.Find("Spot Light");
        cont = 0;
        cont02 = 0;
        cont05 = 0;
        contmissao03 = 0;
        contmissao02 = 0;
    }

    // Update is called once per frame
    void Update()
    {
        //missao04();
        //missao06();
        //misssao07();

      

        if (objetinho != null)
        {
            Physics.IgnoreCollision(objetinho.GetComponent<Collider>(), GetComponent<Collider>());
        }

    /*
       if (cont05 == 1)
        {
            objetivo.GetComponent<objetivos>().cont09 = 1;
            cont05++;
          
        }

        */

        missao03();

        if (cont04 == 0)
        {
           if( cont03 == 2)
            {
                objetivo.GetComponent<objetivos>().cont3 = 1;
                cont04++;
            }
        }


       


    }


    private void OnTriggerEnter(Collider other)
    {

        if(other.tag == "objeto")
        {
            objetinho = other.gameObject;

            
        }


        if(gameObject.name == "missao01")
        {
            if (other.tag == "Player")
            {
                if (cont == 0)
                {
                    objetivo.GetComponent<objetivos>().cont1 = 1;
                   
                    cont++;
                }
            }
        }


        if(gameObject.name == "missao03" || gameObject.name == "missao02")
        {

            if (other.tag == "Player")
            {

               if (gameObject.name == "missao03")
                {
                    if (contmissao03 == 0)
                    {
                       ;
                       contmissao03++;
                       objetivo.GetComponent<objetivos>().contmissao03 = contmissao03;

                    }
                        
                }

                if (gameObject.name == "missao02")
                {
                    if (contmissao02 == 0)
                    {
                     
                        contmissao02++;
                        objetivo.GetComponent<objetivos>().contmissao02 = contmissao02;
                    }

                }

               
            }
        }

        
    }



    private void missao03()
    {
        if(analizandosss.GetComponent<visualizar>().visualizando == true && analizandosss.GetComponent<visualizar>().objetos != null)
        {
            if(analizandosss.GetComponent<visualizar>().objetos.name == "diploma de psicologia")
            {
                if (cont03 == 0 || nome != analizandosss.GetComponent<visualizar>().objetos.name)
                {
                    cont03++;
                    
                    nome = analizandosss.GetComponent<visualizar>().objetos.name;
                }
            }
            if(analizandosss.GetComponent<visualizar>().objetos.name == "diploma de psiquiatria")
            {
                if (cont03 == 0 || nome != analizandosss.GetComponent<visualizar>().objetos.name)
                {
                    cont03++;
                    
                    nome = analizandosss.GetComponent<visualizar>().objetos.name;
                }
                
            }
        }
    }
    /*
    private void missao04()
    {
        if(cont05 == 0 && lanternaa.GetComponent<lanterna>().cont03 == 1)
        {
         
            if (analizandosss.GetComponent<visualizar>().tomou == true)
            {
                
                cont05 = 1;
                if(cont05 == 1)
                {
                    analizandosss.GetComponent<visualizar>().tomou = false;
                }
                


            }
        }
            
       
       
    }

    private void missao06()
    {
        if(cont06 == 0 && lanternaa.GetComponent<lanterna>().cont02 == 1)
        {

            if (analizandosss.GetComponent<visualizar>().tomou03 == true)
            {

                //objetivo.GetComponent<objetivos>().cont08 = 1;
                //cont06 = 1;
                analizandosss.GetComponent<visualizar>().tomou03 = false;
            }

        }

       

    }

    private void misssao07()
    {
        if(cont07 == 0 && lanternaa.GetComponent<lanterna>().cont01 == 1)
        {
            if (analizandosss.GetComponent<visualizar>().tomou02 == true)
            {

                objetivo.GetComponent<objetivos>().cont07 = 1;
                cont07 = 1;
                print("oi");
                analizandosss.GetComponent<visualizar>().tomou02 = false;
            }
        }
        
    }

    */

}



