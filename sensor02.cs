using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class sensor02 : MonoBehaviour
{


    public GameObject obetinho , sensorPrimeiro, objetinho;
    public int cont;
    public bool pegadinha;
    [SerializeField]
    Sprite mao01, mao02, mao3, mao4;
    [SerializeField]
    GameObject mao, veriavel;


    [SerializeField]
    GameObject mira;


    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {

        mirar();

        if (veriavel == null || veriavel.tag == "Untagged")
        {
            sensorPrimeiro.GetComponent<sensor>().interagir.SetActive(false);
        }


        if(sensorPrimeiro.GetComponent<sensor>().pegou == false)
        {
            if (sensorPrimeiro.GetComponent<sensor>().interagir.activeSelf == false)
            {
                mao.SetActive(false);
            }
        }
        

        if(obetinho == null)
        {
            pegadinha = false;
        }

        if (sensorPrimeiro.GetComponent<sensor>().testo != null)
        {
            if (sensorPrimeiro.GetComponent<sensor>().pegou == false && sensorPrimeiro.GetComponent<sensor>().testo.tag != "naoAbre")
            {
                mao.GetComponent<Image>().sprite = mao01;
            }
            if (sensorPrimeiro.GetComponent<sensor>().pegou == false && sensorPrimeiro.GetComponent<sensor>().testo.tag == "naoAbre")
            {
                mao.GetComponent<Image>().sprite = mao3;
            }
            else if (sensorPrimeiro.GetComponent<sensor>().pegou == true)
            {
                mao.GetComponent<Image>().sprite = mao02;
            }
            if(sensorPrimeiro.GetComponent<sensor>().pegou == false && sensorPrimeiro.GetComponent<sensor>().testo.tag == "folha" 
                || sensorPrimeiro.GetComponent<sensor>().pegou == false && sensorPrimeiro.GetComponent<sensor>().testo.tag == "olhar" || sensorPrimeiro.GetComponent<sensor>().pegou == false && sensorPrimeiro.GetComponent<sensor>().testo.tag == "item")
            {
                mao.GetComponent<Image>().sprite = mao4;
            }

        }


        if (sensorPrimeiro.GetComponent<sensor>().testo == null && sensorPrimeiro.GetComponent<sensor>().pegou == false || sensorPrimeiro.GetComponent<visualizar>().visualizando == true)
        {
            mao.SetActive(false);
        }

        if(sensorPrimeiro.GetComponent<visualizar>().visualizando == false)
        {
            if(sensorPrimeiro.GetComponent<visualizar>().objetos != objetinho)
            {
                sensorPrimeiro.GetComponent<visualizar>().objetos = null;
            } 
        }


    }


    private void OnTriggerEnter(Collider other)
    {
        ////

        if(other.tag == "interagir" || other.tag == "objeto" || other.tag == "olhar" || other.tag == "folha" || other.tag == "naoAbre" || other.tag == "item" || other.tag == "obejtoJaPego")
        {
            veriavel = other.gameObject;
        }


        if (other.tag == "objeto" || other.tag == "olhar" || other.tag == "folha" || other.tag == "item" || other.tag == "obejtoJaPego")
        {
            objetinho = other.gameObject;
            sensorPrimeiro.GetComponent<visualizar>().objetos = other.gameObject;
            sensorPrimeiro.GetComponent<visualizar>().caixa = sensorPrimeiro.GetComponent<visualizar>().objetos.GetComponent<BoxCollider>();
            if (sensorPrimeiro.GetComponent<visualizar>().objetos.tag != "olhar" || sensorPrimeiro.GetComponent<visualizar>().objetos.tag != "folha" || sensorPrimeiro.GetComponent<visualizar>().objetos.tag != "item")
            {
                sensorPrimeiro.GetComponent<visualizar>().fisica = sensorPrimeiro.GetComponent<visualizar>().objetos.GetComponent<Rigidbody>();
            }

            sensorPrimeiro.GetComponent<visualizar>().items = sensorPrimeiro.GetComponent<visualizar>().objetos.gameObject.GetComponent<objeto>();
            sensorPrimeiro.GetComponent<visualizar>().localObjeto = sensorPrimeiro.GetComponent<visualizar>().items.local;

            if (Input.GetKeyDown(KeyCode.E))
            {

            }


        }
        






        ////
        if (sensorPrimeiro.GetComponent<sensor>().booleano.activeSelf == false)
         {
            if (other.tag == "interagir" || other.tag == "objeto" || other.tag == "olhar" || other.tag =="naoAbre" || other.tag == "folha" || other.tag == "item" || other.tag == "obejtoJaPego")
            {
                sensorPrimeiro.GetComponent<sensor>().testo = other.gameObject;

                if (sensorPrimeiro.GetComponent<sensor>().visualizando.GetComponent<visualizar>().verificando == false)
                {
                    if (sensorPrimeiro.GetComponent<sensor>().testo.name != "cama" || sensorPrimeiro.GetComponent<sensor>().dormindoo.GetComponent<objetivos>().podedormir == true)
                    {
                        sensorPrimeiro.GetComponent<sensor>().interagir.SetActive(true);
                        sensorPrimeiro.GetComponent<sensor>().interagir.GetComponent<Text>().text = sensorPrimeiro.GetComponent<sensor>().testo.GetComponent<nomesDosObjetos>().nomeObjeto + System.Environment.NewLine + GameMultiLang.GetTraduction("Interagir (E)");
                        if (sensorPrimeiro.GetComponent<sensor>().testo.tag == "olhar" || sensorPrimeiro.GetComponent<sensor>().testo.tag == "folha" || sensorPrimeiro.GetComponent<sensor>().testo.tag == "item")
                        {
                            sensorPrimeiro.GetComponent<sensor>().interagir.GetComponent<Text>().text = sensorPrimeiro.GetComponent<sensor>().testo.GetComponent<nomesDosObjetos>().nomeObjeto + System.Environment.NewLine + GameMultiLang.GetTraduction("Visualizar (E)");
                        }
                        if (sensorPrimeiro.GetComponent<sensor>().testo.tag == "objeto" || sensorPrimeiro.GetComponent<sensor>().testo.tag == "obejtoJaPego")
                        {
                            sensorPrimeiro.GetComponent<sensor>().interagir.GetComponent<Text>().text = sensorPrimeiro.GetComponent<sensor>().testo.GetComponent<nomesDosObjetos>().nomeObjeto + System.Environment.NewLine + GameMultiLang.GetTraduction("Visualizar (E)") + System.Environment.NewLine + GameMultiLang.GetTraduction("Pegar (MOUSE)");
                        }
                        if (sensorPrimeiro.GetComponent<sensor>().testo.tag == "naoAbre")
                        {
                            //sensorPrimeiro.GetComponent<sensor>().interagir.SetActive(true);
                            sensorPrimeiro.GetComponent<sensor>().interagir.GetComponent<Text>().text = sensorPrimeiro.GetComponent<sensor>().testo.GetComponent<nomesDosObjetos>().nomeObjeto + System.Environment.NewLine + GameMultiLang.GetTraduction("Naoabre");
                        }
                        mao.SetActive(true);
                    }

                    else if (sensorPrimeiro.GetComponent<sensor>().dormindoo.GetComponent<objetivos>().podedormir == false
                        && sensorPrimeiro.GetComponent<sensor>().testo.name == "cama")
                    {
                        mao.SetActive(true);
                        sensorPrimeiro.GetComponent<sensor>().interagir.SetActive(true);
                        sensorPrimeiro.GetComponent<sensor>().interagir.GetComponent<Text>().text = sensorPrimeiro.GetComponent<sensor>().testo.GetComponent<nomesDosObjetos>().nomeObjeto + System.Environment.NewLine + GameMultiLang.GetTraduction("Tenho que terminar os Objetivos");
                    }

                    if (sensorPrimeiro.GetComponent<sensor>().testo.name == "Ligar" && sensorPrimeiro.GetComponent<sensor>().dormindoo.GetComponent<objetivos>().podedormir == false)
                    {
                        sensorPrimeiro.GetComponent<sensor>().interagir.GetComponent<Text>().text = sensorPrimeiro.GetComponent<sensor>().testo.GetComponent<nomesDosObjetos>().nomeObjeto + System.Environment.NewLine + GameMultiLang.GetTraduction("Tenho que terminar os Objetivos");//
                    }
                    else if (sensorPrimeiro.GetComponent<sensor>().dormindoo.GetComponent<objetivos>().podedormir == true)
                    {
                        sensorPrimeiro.GetComponent<sensor>().interagir.GetComponent<Text>().text = sensorPrimeiro.GetComponent<sensor>().testo.GetComponent<nomesDosObjetos>().nomeObjeto + System.Environment.NewLine + GameMultiLang.GetTraduction("Interagir (E)");//
                    }

                }



            }












            if (other.tag == "objeto" || other.tag == "obejtoJaPego")
            {

           
                if (cont == 0)
               {
                    obetinho = other.gameObject;
                    cont++;
              }
            }
        }
    }
   private void OnTriggerStay(Collider other)
    {
        ////

        if (other.tag == "interagir" || other.tag == "objeto" || other.tag == "olhar" || other.tag == "folha" || other.tag == "naoAbre" || other.tag == "item" || other.tag == "obejtoJaPego")
        {
            veriavel = other.gameObject;
        }



        ////

        if (other.tag == "objeto" || other.tag == "olhar" || other.tag == "folha" || other.tag == "item" || other.tag == "obejtoJaPego")
        {
            objetinho = other.gameObject;
            sensorPrimeiro.GetComponent<visualizar>().objetos = other.gameObject;
            sensorPrimeiro.GetComponent<visualizar>().caixa = sensorPrimeiro.GetComponent<visualizar>().objetos.GetComponent<BoxCollider>();
            if (sensorPrimeiro.GetComponent<visualizar>().objetos.tag != "olhar" || sensorPrimeiro.GetComponent<visualizar>().objetos.tag != "folha" || sensorPrimeiro.GetComponent<visualizar>().objetos.tag != "item")
            {
                sensorPrimeiro.GetComponent<visualizar>().fisica = sensorPrimeiro.GetComponent<visualizar>().objetos.GetComponent<Rigidbody>();
            }

            sensorPrimeiro.GetComponent<visualizar>().items = sensorPrimeiro.GetComponent<visualizar>().objetos.gameObject.GetComponent<objeto>();
            sensorPrimeiro.GetComponent<visualizar>().localObjeto = sensorPrimeiro.GetComponent<visualizar>().items.local;



        }
        
        ////

        if (other.tag == "interagir" || other.tag == "objeto" || other.tag == "olhar" || other.tag == "naoAbre" || other.tag == "folha" || other.tag == "item" || other.tag == "obejtoJaPego")
        {

          
                sensorPrimeiro.GetComponent<sensor>().testo = other.gameObject;//
           
            

            if (sensorPrimeiro.GetComponent<sensor>().visualizando.GetComponent<visualizar>().verificando == false)
            {
                if (sensorPrimeiro.GetComponent<sensor>().testo.name != "cama"  || sensorPrimeiro.GetComponent<sensor>().dormindoo.GetComponent<objetivos>().podedormir == true)
                {
                    sensorPrimeiro.GetComponent<sensor>().interagir.SetActive(true);
                   sensorPrimeiro.GetComponent<sensor>().interagir.GetComponent<Text>().text = sensorPrimeiro.GetComponent<sensor>().testo.GetComponent<nomesDosObjetos>().nomeObjeto + System.Environment.NewLine + GameMultiLang.GetTraduction("Interagir (E)");//
                    if (sensorPrimeiro.GetComponent<sensor>().testo.tag == "olhar" || sensorPrimeiro.GetComponent<sensor>().testo.tag == "folha" || sensorPrimeiro.GetComponent<sensor>().testo.tag == "item")
                    {
                        sensorPrimeiro.GetComponent<sensor>().interagir.GetComponent<Text>().text = sensorPrimeiro.GetComponent<sensor>().testo.GetComponent<nomesDosObjetos>().nomeObjeto + System.Environment.NewLine + GameMultiLang.GetTraduction("Visualizar (E)");
                    }
                    if (sensorPrimeiro.GetComponent<sensor>().testo.tag == "objeto" || sensorPrimeiro.GetComponent<sensor>().testo.tag == "obejtoJaPego")
                    {
                        sensorPrimeiro.GetComponent<sensor>().interagir.GetComponent<Text>().text = sensorPrimeiro.GetComponent<sensor>().testo.GetComponent<nomesDosObjetos>().nomeObjeto + System.Environment.NewLine + GameMultiLang.GetTraduction("Visualizar (E)") + System.Environment.NewLine + GameMultiLang.GetTraduction("Pegar (MOUSE)");
                    }
                    if(sensorPrimeiro.GetComponent<sensor>().testo.tag == "naoAbre")
                    {
                        //sensorPrimeiro.GetComponent<sensor>().interagir.SetActive(true);
                        sensorPrimeiro.GetComponent<sensor>().interagir.GetComponent<Text>().text = sensorPrimeiro.GetComponent<sensor>().testo.GetComponent<nomesDosObjetos>().nomeObjeto + System.Environment.NewLine + GameMultiLang.GetTraduction("Naoabre");
                    }
                    mao.SetActive(true);
                }

                else if (sensorPrimeiro.GetComponent<sensor>().testo.name == "cama" && sensorPrimeiro.GetComponent<sensor>().dormindoo.GetComponent<objetivos>().podedormir == false)
                {
                    sensorPrimeiro.GetComponent<sensor>().interagir.SetActive(true);
                    mao.SetActive(true);
                    sensorPrimeiro.GetComponent<sensor>().interagir.GetComponent<Text>().text = sensorPrimeiro.GetComponent<sensor>().testo.GetComponent<nomesDosObjetos>().nomeObjeto + System.Environment.NewLine + GameMultiLang.GetTraduction("Tenho que terminar os Objetivos");//
                }


                if (sensorPrimeiro.GetComponent<sensor>().testo.name == "Ligar" && sensorPrimeiro.GetComponent<sensor>().dormindoo.GetComponent<objetivos>().podedormir == false)
                {
                    sensorPrimeiro.GetComponent<sensor>().interagir.GetComponent<Text>().text = sensorPrimeiro.GetComponent<sensor>().testo.GetComponent<nomesDosObjetos>().nomeObjeto + System.Environment.NewLine + GameMultiLang.GetTraduction("Tenho que terminar os Objetivos");//
                }
                else if(sensorPrimeiro.GetComponent<sensor>().dormindoo.GetComponent<objetivos>().podedormir == true)
                {
                    sensorPrimeiro.GetComponent<sensor>().interagir.GetComponent<Text>().text = sensorPrimeiro.GetComponent<sensor>().testo.GetComponent<nomesDosObjetos>().nomeObjeto + System.Environment.NewLine + GameMultiLang.GetTraduction("Interagir (E)");//
                }

            }



        }


       

       



        if (sensorPrimeiro.GetComponent<sensor>().booleano.activeSelf == false)
        {
            if(other.tag == "objeto" || other.tag == "obejtoJaPego")
            {
               pegadinha = true;

               if (cont == 0)
                {
                    obetinho = other.gameObject;
                    cont++;
               }
            }
           
        }
    }


        private void OnTriggerExit(Collider other)
    {

        if (other.tag == "interagir" || other.tag == "objeto" || other.tag == "olhar" || other.tag == "folha" || other.tag == "naoAbre" || other.tag == "item" || other.tag == "obejtoJaPego")
        {
            veriavel = null;
        }

        ///
        if (other.tag == "objeto" || other.tag == "olhar" || other.tag == "folha" || other.tag == "item" || other.tag == "obejtoJaPego")
        {
            objetinho = null;
        }
        if (sensorPrimeiro.GetComponent<visualizar>().visualizando == false)
        {
            if (other.tag == "objeto" || other.tag == "olhar" || other.tag == "folha" || other.tag == "item" || other.tag == "obejtoJaPego")
            {
                if(sensorPrimeiro.GetComponent<visualizar>().objetos != null)
                {
                    if (sensorPrimeiro.GetComponent<visualizar>().objetos.tag != "olhar" || sensorPrimeiro.GetComponent<visualizar>().objetos.tag != "folha" || sensorPrimeiro.GetComponent<visualizar>().objetos.tag != "item")
                    {
                        sensorPrimeiro.GetComponent<visualizar>().fisica = null;
                    }
                    sensorPrimeiro.GetComponent<visualizar>().objetos = null;
                    sensorPrimeiro.GetComponent<visualizar>().localObjeto = null;
                    sensorPrimeiro.GetComponent<visualizar>().caixa = null;

                }

            }
        }


        /*
       
        */
        ///

        if (sensorPrimeiro.GetComponent<sensor>().booleano.activeSelf == false)
        {
            if (other.tag == "interagir" || other.tag == "objeto" || other.tag == "olhar" || other.tag == "naoAbre" || other.tag == "folha" || other.tag == "item" || other.tag == "obejtoJaPego")
            {
                // podePegar = false;
                sensorPrimeiro.GetComponent<sensor>().interagir.SetActive(false);
                if(sensorPrimeiro.GetComponent<sensor>().pegou == false)
                {
                    mao.SetActive(false);
                }
            }






            if (other.tag == "objeto" || other.tag == "obejtoJaPego")
            {
                pegadinha = false;
            }

            if (sensorPrimeiro.GetComponent<sensor>().pegou == false)
            {
                obetinho = null;
                cont = 0;
            }
        }
    }


    private void mirar()
    {
        if(mao.activeSelf == false)
        {
            mira.SetActive(true);
        }
        if(mao.activeSelf == true || Time.timeScale == 0 || Cursor.visible == true || sensorPrimeiro.GetComponent<visualizar>().visualizando == true)
        {
            mira.SetActive(false);
        }
    }


}
