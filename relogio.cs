using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class relogio : MonoBehaviour
{
    
    public GameObject ponteiro01, ponteiro02, ponteiroFalso, ponteiroFalso02, painelRelogio, setaMaior, setaMenor, chuverinho, numero01, numero02, porta;

    [SerializeField]
    Text textoRelogio;
    [SerializeField]
    int relogioCont, r1, r2;
    [SerializeField]
    Color verde;

    bool positivo01, positivo02, pousol, teste, teste02, teste03, teste04;

    int cont, contrada;

    string texto01, texto02;

    int cont01, cont02, cont03, cont04, cont05, cont06, cont07, cont08, cont09, cont10, cont11;
    int cont01m, cont02m, cont03m, cont04m, cont05m, cont06m, cont07m, cont08m, cont09m, cont10m, cont11m;
    int contFinal;
    [SerializeField]
    bool DEMO;

    // Start is called before the first frame update
    void Start()
    {
        positivo01 = false;
        positivo02 = false;
        if(textoRelogio != null)
        {
            textoRelogio.enabled = false;
            textoRelogio.text = "0/2";
        }




    }

    // Update is called once per frame
    void Update()
    {
        if(relogioCont == 2)
        {
            textoRelogio.color = verde;
        }
       

        if (gameObject.tag == "interagir")
        {
            numeros();
            numeros02();
        }
        

        numero01.GetComponent<Text>().text = texto01;
        numero02.GetComponent<Text>().text = texto02;


        if (teste == true)
        {
            setaMaior.transform.Rotate(0, 0, 40 * Time.deltaTime);
        }
        if (teste02 == true)
        {
            setaMaior.transform.Rotate(0, 0, -40 * Time.deltaTime);
        }
        if (teste03 == true)
        {
            setaMenor.transform.Rotate(0, 0, 30 * Time.deltaTime);
        }
        if (teste04 == true)
        {
            setaMenor.transform.Rotate(0, 0, -30 * Time.deltaTime);
        }




        if (positivo01 == true && positivo02 == true && contFinal == 0)
        {
            gameObject.tag = "interagir";
            contFinal = 1;
        }

        
        if(pousol == true && cont == 0 && gameObject.tag == "interagir")
        {
            pousoltrue();
            
        }
        
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            pousolgalse();
        }
        if(positivo01 == true)
        {
            ponteiro01.GetComponent<BoxCollider>().isTrigger = true;
            ponteiro01.GetComponent<Rigidbody>().isKinematic = true;
            ponteiro01.tag = "Untagged";
            ponteiro01.transform.position = ponteiroFalso.transform.position;
            ponteiro01.transform.rotation = ponteiroFalso.transform.rotation;
            ponteiro01.transform.localScale = ponteiroFalso02.transform.localScale;
            if (r1 == 0)
            {
                textoRelogio.enabled = true;
                r1 = 1;
                relogioCont++;
                textoRelogio.text = relogioCont + "/2";
            }
        }
        if (positivo02 == true)
        {
            ponteiro02.GetComponent<BoxCollider>().isTrigger = true;
            ponteiro02.GetComponent<Rigidbody>().isKinematic = true;
            ponteiro02.tag = "Untagged";
            ponteiro02.transform.position = ponteiroFalso02.transform.position;
            ponteiro02.transform.rotation = ponteiroFalso02.transform.rotation;
            ponteiro02.transform.localScale = ponteiroFalso02.transform.localScale;
            if (r2 == 0)
            {
                textoRelogio.enabled = true;
                r2 = 1;
                relogioCont++;
                textoRelogio.text = relogioCont + "/2";
            }
        }

    }


    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject == ponteiro01)
        {
           
            positivo01 = true;
            textoRelogio.enabled = true;
        }
        if(other.gameObject == ponteiro02)
        {
           
            positivo02 = true;
            textoRelogio.enabled = true;
        }
        

    }

    private void OnTriggerStay(Collider other)
    {


        /////
        if (other.gameObject == ponteiro01)
        {

            positivo01 = true;
           
        }
        if (other.gameObject == ponteiro02)
        {

            positivo02 = true;
            
        }



        ///////


        if (other.tag == "sensor" && Input.GetKeyDown(KeyCode.E) && positivo01 == true && positivo02 == true)
        {
            pousol = true;
        }


    }


    private void pousoltrue()
    {
        painelRelogio.SetActive(true);
        chuverinho.SetActive(true);
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
        contrada = 1;
    }
    public void pousolgalse()
    {
        if(contrada == 1)
        {
            pousol = false;
            painelRelogio.SetActive(false);
            chuverinho.SetActive(false);
            Cursor.visible = false;
            Cursor.lockState = CursorLockMode.Locked;
            cont = 0;
            contrada = 0;
        }
       
        
    }


    public void mudarMaiormais()
    {
        if(teste == false)
        {
            teste = true;
        }
        else if(teste == true)
        {
            teste = false;
        }
       
    }

    public void mudarMaiormenor()
    {
        if (teste02 == false)
        {
            teste02 = true;
        }
        else if (teste02 == true)
        {
            teste02 = false;
        }
       
    }

    public void mudarMenormais()
    {
        if (teste03 == false)
        {
            teste03 = true;
        }
        else if (teste03 == true)
        {
            teste03 = false;
        }
        
    }
    public void mudarMenormenos()
    {
        if (teste04 == false)
        {
            teste04 = true;
        }
        else if (teste04 == true)
        {
            teste04 = false;
        }
        
    }




    private void numeros()
    {

        if(setaMenor.transform.rotation.z >= 0 && setaMenor.transform.rotation.z < 0.024f || setaMenor.transform.rotation.z <= 0 && setaMenor.transform.rotation.z > -0.024f)
        {
            cont01 = 0;
            texto01 = "12";
        }
        if (setaMenor.transform.rotation.z >= 0.248f && setaMenor.transform.rotation.z < 0.284f)
        {
            if (cont01 == 0)
            {
                texto01 = "12";

            }
            else if (cont01 == 1)
            {
                texto01 = "11";
                
            }
            cont02 = 0;
        }
        if (setaMenor.transform.rotation.z >= 0.284f && setaMenor.transform.rotation.z < 0.511f)
        {
            cont01 = 1;
            if (cont02 == 0)
            {
                texto01 = "1";

            }
            else if (cont02 == 1)
            {
                texto01 = "10";

            }
            cont03 = 0;
        }
        if (setaMenor.transform.rotation.z >= 0.511f && setaMenor.transform.rotation.z < 0.726f)
        {
            cont02 = 1;
            if (cont03 == 0)
            {
                texto01 = "2";

            }
            else if (cont03 == 1)
            {
                texto01 = "9";

            }
            cont04 = 0;
        }
        if (setaMenor.transform.rotation.z >= 0.726f && setaMenor.transform.rotation.z < 0.897f)
        {
            cont03 = 1;
            if (cont04 == 0)
            {
                texto01 = "3";

            }
            else if (cont04 == 1)
            {
                texto01 = "8";

            }
            cont05 = 0;
        }
        if (setaMenor.transform.rotation.z >= 0.897f && setaMenor.transform.rotation.z < 0.966f)
        {
            cont04 = 1;
            if (cont05 == 0)
            {
                texto01 = "4";

            }
            else if (cont05 == 1)
            {
                texto01 = "7";

            }
            cont06 = 0;
        }
        if (setaMenor.transform.rotation.z >= 0.966f && setaMenor.transform.rotation.z < 0.985f)
        {
            cont05 = 1;
            if (cont06 == 0)
            {
                texto01 = "5";

            }
            else if (cont06 == 1)
            {

                texto01 = "6";
            }
            cont07 = 0;
        }

        if (setaMenor.transform.rotation.z >= 0.995f && setaMenor.transform.rotation.z < 1 || setaMenor.transform.rotation.z <= -0.995f && setaMenor.transform.rotation.z > -1)
        {
            cont06 = 1;
            texto01 = "6";
            cont08 = 0;
        }

        /*
        if (setaMenor.transform.rotation.z >= 0.581f && setaMenor.transform.rotation.z < 0.664f)
        {
            cont07 = 1;
            if (cont08 == 0)
            {
                texto01 = "4";
              
            }
            else if (cont08 == 1)
            {
                texto01 = "8";
              
            }

            cont09 = 0;
        }
        if (setaMenor.transform.rotation.z >= 0.664f && setaMenor.transform.rotation.z < 0.747f)
        {
            cont08 = 1;
            if (cont09 == 0)
            {
                texto01 = "4";
               
            }
            else if (cont09 == 1)
            {
                texto01 = "8";
               
            }
            cont10 = 0;
        }
        if (setaMenor.transform.rotation.z >= 0.747f && setaMenor.transform.rotation.z < 0.83f)
        {
            cont09 = 1;
            if (cont10 == 0)
            {
                texto01 = "5";
               
            }
            else if (cont10 == 1)
            {
                texto01 = "7";
               
            }
            cont11 = 0;
        }
        if (setaMenor.transform.rotation.z >= 0.83f && setaMenor.transform.rotation.z < 0.913f)
        {

            cont10 = 1;
            if (cont11 == 0)
            {
                texto01 = "5";

            }
            else if (cont11 == 1)
            {
                texto01 = "7";

            }
            
        }


        if (setaMenor.transform.rotation.z >= 0.913f && setaMenor.transform.rotation.z < 1f)
        {
            cont11 = 1;

            texto01 = "6";
        }


    */

        //////////////////////////////////////





       
        if (setaMenor.transform.rotation.z < -0.248f && setaMenor.transform.rotation.z > -0.284f)
        {
            if (cont01 == 0)
            {
                texto01 = "12";

            }
            else if (cont01 == 1)
            {
                texto01 = "11";

            }
            cont02 = 0;
        }
        if (setaMenor.transform.rotation.z <= -0.284f && setaMenor.transform.rotation.z > -0.511f)
        {
            cont01 = 1;
            if (cont02 == 0)
            {
                texto01 = "1";

            }
            else if (cont02 == 1)
            {
                texto01 = "10";

            }
            cont03 = 0;
        }
        if (setaMenor.transform.rotation.z <= -0.511f && setaMenor.transform.rotation.z > -0.726f)
        {
            cont02 = 1;
            if (cont03 == 0)
            {
                texto01 = "2";

            }
            else if (cont03 == 1)
            {
                texto01 = "9";

            }
            cont04 = 0;
        }
        if (setaMenor.transform.rotation.z <= -0.726f && setaMenor.transform.rotation.z > -0.897f)
        {
            cont03 = 1;
            if (cont04 == 0)
            {
                texto01 = "3";

            }
            else if (cont04 == 1)
            {
                texto01 = "8";

            }
            cont05 = 0;
        }
        if (setaMenor.transform.rotation.z <= -0.897f && setaMenor.transform.rotation.z > -0.966f)
        {
            cont04 = 1;
            if (cont05 == 0)
            {
                texto01 = "4";

            }
            else if (cont05 == 1)
            {
                texto01 = "7";

            }
            cont06 = 0;
        }
        if (setaMenor.transform.rotation.z <= -0.966f && setaMenor.transform.rotation.z > -0.980f)
        {
            cont05 = 1;
            if (cont06 == 0)
            {
                texto01 = "5";

            }
            else if (cont06 == 1)
            {
                texto01 = "6";

            }
            cont07 = 0;
        }



        /*
       if (setaMenor.transform.rotation.z <= -0.966f && setaMenor.transform.rotation.z > -0.999f)
       {
           cont07 = 1;
           if (cont08 == 0)
           {
               texto01 = "4";

           }
           else if (cont08 == 1)
           {
               texto01 = "8";

           }

           cont09 = 0;
       }



           if (setaMenor.transform.rotation.z <= -0.664f && setaMenor.transform.rotation.z > -0.747f)
           {
               cont08 = 1;
               if (cont09 == 0)
               {
                   texto01 = "4";

               }
               else if (cont09 == 1)
               {
                   texto01 = "8";

               }
               cont10 = 0;
           }
           if (setaMenor.transform.rotation.z <= -0.747f && setaMenor.transform.rotation.z > -0.83f)
           {
               cont09 = 1;
               if (cont10 == 0)
               {
                   texto01 = "5";

               }
               else if (cont10 == 1)
               {
                   texto01 = "7";

               }
               cont11 = 0;
           }
           if (setaMenor.transform.rotation.z <= -0.83f && setaMenor.transform.rotation.z > -0.913f)
           {

               cont10 = 1;
               if (cont11 == 0)
               {
                   texto01 = "5";

               }
               else if (cont11 == 1)
               {
                   texto01 = "7";

               }

           }


           if (setaMenor.transform.rotation.z <= -0.913f && setaMenor.transform.rotation.z > -1f)
           {
               cont11 = 1;

               texto01 = "6";
           }

       }
       */

    }

    /// <summary>
    /// ///////////////////////////////////////
    /// </summary>






    private void numeros02()
    {


        if (setaMaior.transform.rotation.z >= 0 && setaMaior.transform.rotation.z < 0.024f || setaMaior.transform.rotation.z <= 0 && setaMaior.transform.rotation.z > -0.024f)
        {
            cont01m = 0;
            texto02 = "12";
        }



        if (setaMaior.transform.rotation.z >= 0.248f && setaMaior.transform.rotation.z < 0.248f)
        {
            if (cont01m == 0)
            {
                texto02 = "12";

            }
            else if (cont01m == 1)
            {
                texto02 = "11";

            }
            cont02m = 0;
        }
        if (setaMaior.transform.rotation.z >= 0.248f && setaMaior.transform.rotation.z < 0.511f)
        {
            cont01m = 1;
            if (cont02m == 0)
            {
                texto02 = "1";

            }
            else if (cont02m == 1)
            {
                texto02 = "10";

            }
            cont03m = 0;
        }
        if (setaMaior.transform.rotation.z >= 0.511f && setaMaior.transform.rotation.z < 0.726f)
        {
            cont02m = 1;
            if (cont03m == 0)
            {
                texto02 = "2";

            }
            else if (cont03m == 1)
            {
                texto02 = "9";

            }
            cont04m = 0;
        }
        if (setaMaior.transform.rotation.z >= 0.726f && setaMaior.transform.rotation.z < 0.897f)
        {
            cont03m = 1;
            if (cont04m == 0)
            {
                texto02 = "3";

            }
            else if (cont04m == 1)
            {
                texto02 = "8";

            }
            cont05m = 0;
        }
        if (setaMaior.transform.rotation.z >= 0.897f && setaMaior.transform.rotation.z < 0.966f)
        {
            cont04m = 1;
            if (cont05m == 0)
            {
                texto02 = "4";

            }
            else if (cont05m == 1)
            {
                texto02 = "7";

            }
            cont06m = 0;
        }
        if (setaMaior.transform.rotation.z >= 0.966f && setaMaior.transform.rotation.z < 0.980f)
        {
            cont05m = 1;
            if (cont06m == 0)
            {
                texto02 = "5";

            }
            else if (cont06m == 1)
            {
                texto02 = "6";

            }
            cont07m = 0;
        }



        if (setaMaior.transform.rotation.z >= 0.995f && setaMaior.transform.rotation.z < 1 || setaMaior.transform.rotation.z <= -0.995f && setaMaior.transform.rotation.z > -1)
        {
            cont06m = 1;
            texto02 = "6";
            cont08m = 0;
        }


        /*
         




         
       if (setaMaior.transform.rotation.z >= 0.498f && setaMaior.transform.rotation.z < 0.581f)
       {
           cont06m = 1;



           if (cont07m == 0)
           {
               texto02 = "3";

           }
           else if (cont07m == 1)
           {
               texto02 = "9";

           }
           cont08m = 0;
       }
       if (setaMaior.transform.rotation.z >= 0.581f && setaMaior.transform.rotation.z < 0.664f)
       {
           cont07m = 1;
           if (cont08m == 0)
           {
               texto02 = "4";

           }
           else if (cont08m == 1)
           {
               texto02 = "8";

           }

           cont09m = 0;
       }
       if (setaMaior.transform.rotation.z >= 0.664f && setaMaior.transform.rotation.z < 0.747f)
       {
           cont08m = 1;
           if (cont09m == 0)
           {
               texto02 = "4";

           }
           else if (cont09m == 1)
           {
               texto02 = "8";

           }
           cont10m = 0;
       }
       if (setaMaior.transform.rotation.z >= 0.747f && setaMaior.transform.rotation.z < 0.83f)
       {
           cont09m = 1;
           if (cont10m == 0)
           {
               texto02 = "5";

           }
           else if (cont10m == 1)
           {
               texto02 = "7";

           }
           cont11m = 0;
       }
       if (setaMaior.transform.rotation.z >= 0.83f && setaMaior.transform.rotation.z < 0.913f)
       {

           cont10m = 1;
           if (cont11m == 0)
           {
               texto02 = "5";

           }
           else if (cont11m == 1)
           {
               texto02 = "7";

           }

       }


       if (setaMaior.transform.rotation.z >= 0.913f && setaMaior.transform.rotation.z < 1f)
       {
           cont11m = 1;

           texto02 = "6";
       }




       //////////////////////////////////////





   */




        if (setaMaior.transform.rotation.z < 0 && setaMaior.transform.rotation.z > -0.284f)
        {
            if (cont01m == 0)
            {
                texto02 = "12";

            }
            else if (cont01m == 1)
            {
                texto02 = "11";

            }
            cont02m = 0;
        }
        if (setaMaior.transform.rotation.z <= -0.284f && setaMaior.transform.rotation.z > -0.511f)
        {
            cont01m = 1;
            if (cont02m == 0)
            {
                texto02 = "1";

            }
            else if (cont02m == 1)
            {
                texto02 = "10";

            }
            cont03m = 0;
        }
        if (setaMaior.transform.rotation.z <= -0.511f && setaMaior.transform.rotation.z > -0.726f)
        {
            cont02m = 1;
            if (cont03m == 0)
            {
                texto02 = "2";

            }
            else if (cont03m == 1)
            {
                texto02 = "9";

            }
            cont04m = 0;
        }
        if (setaMaior.transform.rotation.z <= -0.726f && setaMaior.transform.rotation.z > -0.897f)
        {
            cont03m = 1;
            if (cont04m == 0)
            {
                texto02 = "3";

            }
            else if (cont04m == 1)
            {
                texto02 = "8";

            }
            cont05m = 0;
        }
        if (setaMaior.transform.rotation.z <= -0.897f && setaMaior.transform.rotation.z > -0.966f)
        {
            cont04m = 1;
            if (cont05m == 0)
            {
                texto02 = "4";

            }
            else if (cont05m == 1)
            {
                texto02 = "7";

            }
            cont06m = 0;
        }
        if (setaMaior.transform.rotation.z <= -0.966f && setaMaior.transform.rotation.z > -0.999f)
        {
            cont05m = 1;
            if (cont06m == 0)
            {
                texto02 = "5";

            }
            else if (cont06m == 1)
            {
                texto02 = "6";

            }
            cont07m = 0;
        }



        /*

        if (setaMaior.transform.rotation.z <= -0.498f && setaMaior.transform.rotation.z > -0.581f)
        {
            cont06m = 1;
            if (cont07m == 0)
            {
                texto02 = "3";

            }
            else if (cont07m == 1)
            {
                texto02 = "9";

            }
            cont08m = 0;
        }
        if (setaMaior.transform.rotation.z <= -0.581f && setaMaior.transform.rotation.z > -0.664f)
        {
            cont07m = 1;
            if (cont08m == 0)
            {
                texto02 = "4";

            }
            else if (cont08m == 1)
            {
                texto02 = "8";

            }

            cont09m = 0;
        }
        if (setaMaior.transform.rotation.z <= -0.664f && setaMaior.transform.rotation.z > -0.747f)
        {
            cont08m = 1;
            if (cont09m == 0)
            {
                texto02 = "4";

            }
            else if (cont09m == 1)
            {
                texto02 = "8";

            }
            cont10m = 0;
        }
        if (setaMaior.transform.rotation.z <= -0.747f && setaMaior.transform.rotation.z > -0.83f)
        {
            cont09m = 1;
            if (cont10m == 0)
            {
                texto02 = "5";

            }
            else if (cont10m == 1)
            {
                texto02 = "7";

            }
            cont11m = 0;
        }
        if (setaMaior.transform.rotation.z <= -0.83f && setaMaior.transform.rotation.z > -0.913f)
        {

            cont10m = 1;
            if (cont11m == 0)
            {
                texto02 = "5";

            }
            else if (cont11m == 1)
            {
                texto02 = "7";

            }

        }


        if (setaMaior.transform.rotation.z <= -0.913f && setaMaior.transform.rotation.z > -1f)
        {
            cont11m = 1;

            texto02 = "6";
        }

    }
   
    */
    }

    public void liberar()
    {
        if(DEMO == false)
        {
            if (texto01 == "3" && texto02 == "12")
            {
                textoRelogio.enabled = false;
                gameObject.tag = "Untagged";
                porta.GetComponent<Animator>().SetBool("troca", true);
                pousolgalse();
            }
        }
        else if(DEMO == true)
        {
            if (texto01 == "2" && texto02 == "5")
            {
                textoRelogio.enabled = false;
                gameObject.tag = "Untagged";
                porta.GetComponent<Animator>().SetBool("troca", true);
                pousolgalse();
            }
        }
        

    }

}
