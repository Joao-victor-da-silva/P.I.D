using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class objeto : MonoBehaviour
{

    public string nomeObjeto, traducaoObjeto;

    public bool soltar, verificar;
    public Transform local, pai;
    sensor checar;
    public GameObject sensorr, sensortial, booleano, sensorrrr, missaoo01, missao02, missao03, canvas, naoColide;
    float px, py, pz, rx, ry, rz, rw, sx, sy, sz;
    public Vector3 posicao;
    public Quaternion rotacao;
    BoxCollider caixinha;
    public int id, ids;

    public string anotacao, descricao;

    public bool one;
    Shader normal;
    public Shader outline;
    [SerializeField]
    public Material esteMaterial;

    public Sprite teste;
    
    int cont, cont02;


    Color corBranca;
    //Outline contorno;
    public bool podeDestroir, naoPode;
    
    /// ////
    
    public Material material01, material02; ///
    [SerializeField]
    Material[] materalis;
    bool trocando;


    Renderer capa;

    /// 
    [SerializeField]
    string kaydescri, keyanot;

    // Start is called before the first frame update
    void Start()
    {

        sensortial = GameObject.Find("FPSController");
        booleano = GameObject.Find("noleano");
        sensorrrr = GameObject.Find("sensor");

        nomeObjeto = GameMultiLang.GetTraduction(traducaoObjeto);

        if (kaydescri != null)
        {
            descricao = GameMultiLang.GetTraduction(kaydescri);
            anotacao = GameMultiLang.GetTraduction(keyanot);
        }
       
        capa = GetComponent<Renderer>();
        trocando = false;
       // contorno = GetComponent<Outline>();
       // contorno.enabled = false;
        corBranca.r = 255;
        corBranca.g = 255;
        corBranca.a = 255;
        corBranca.b = 255;
        canvas = GameObject.Find("Canvas");
        naoColide = GameObject.Find("colicaooo");
        cont = 0;
        sx = transform.localScale.x;
        sy = transform.localScale.y;
        sz = transform.localScale.z;
        pai = transform.parent;
        missaoo01 = GameObject.Find("missao01");
        if(missaoo01 == null)
        {
            missaoo01 = GameObject.Find("missao0223");
        }
        missao02 = GameObject.Find("missao02");
        if(missao02 == null)
        {
            missao02 = GameObject.Find("missao022");
        }
        missao03 = GameObject.Find("missao03");
        if(missao03 == null)
        {
            missao03 = GameObject.Find("missao033");
        }
        esteMaterial = GetComponent<MeshRenderer>().material;
        materalis[0] = esteMaterial;
        materalis[1] = esteMaterial;
        materalis[2] = esteMaterial;


        



        definirPosicao();

        outline = Shader.Find("Custom/OutlineColidida");

        soltar = false;
        //sensortial = GameObject.Find("sensor");
        checar = sensorrrr.GetComponent<sensor>();
        caixinha = GetComponent<BoxCollider>();
        local = transform;
    }

    // Update is called once per frame
    void Update()
    {

        

        
        retorn();
        enviaritem();
        if (id != 0 && cont == 0)
        {
            canvas.GetComponent<anotacoes>().textos[id].text = anotacao;
            canvas.GetComponent<anotacoes>().textos[id].gameObject.GetComponent<inventarioDescricao>().id = id;
            canvas.GetComponent<anotacoes>().textos[id].gameObject.GetComponent<inventarioDescricao>().descricao = descricao;
            //canvas.GetComponent<anotacoes>().textos[id].gameObject.GetComponent<inventarioDescricao>().titulo = gameObject.name;
            canvas.GetComponent<anotacoes>().textos[id].gameObject.GetComponent<inventarioDescricao>().titulo = nomeObjeto;
            if (teste != null)
            {
                canvas.GetComponent<anotacoes>().textos[id].gameObject.GetComponent<inventarioDescricao>().doOBjeto = teste;
            }
            cont = 1;
        }


        ///contorno.enabled == true
        if (capa.materials[1] != esteMaterial && trocando == true)
        {
            if (sensorrrr.GetComponent<sensor>().testo != null)
            {
                if (sensorrrr.GetComponent<sensor>().testo.name != gameObject.name || sensorrrr.GetComponent<sensor>().interagir.activeSelf == false)
                {
                    //esteMaterial.shader = normal;
                    //contorno.enabled = false;
                    //GetComponent<MeshRenderer>().materials[1] = esteMaterial;
                    //GetComponent<MeshRenderer>().materials[2] = esteMaterial;////////////
                    materalis[1] = esteMaterial;
                    materalis[2] = esteMaterial;
                    
                    capa.materials = materalis;
                    trocando = false;
                }
            }
        }

        if (sensorrrr.GetComponent<sensor>().pegou == true && trocando == true)
        {

            // contorno.enabled = false;
            //GetComponent<MeshRenderer>().materials[1] = esteMaterial;//////////////////////////
            //GetComponent<MeshRenderer>().materials[2] = esteMaterial;
            materalis[1] = esteMaterial;
            materalis[2] = esteMaterial;
            
            capa.materials = materalis;
            //esteMaterial.shader = normal;
            trocando = false;
        }
       
        

        if(gameObject.tag == "objeto" || gameObject.tag == "olhar" || gameObject.tag == "folha")
        {
            if (sensorrrr.GetComponent<visualizar>().verificacao != null)
            {
                if (sensorrrr.GetComponent<visualizar>().verificacao.name == gameObject.name && id < 1)
                {
                    if(gameObject.tag == "objeto" || gameObject.tag == "olhar")
                    {
                        id = sensorrrr.GetComponent<visualizar>().nanotacoes;
                    }
                    ids = 1;
                }
            }
        }

       
        





        booleano = GameObject.Find("noleano");
        Physics.IgnoreCollision(sensortial.GetComponent<Collider>(), GetComponent<Collider>());
        Physics.IgnoreCollision(missaoo01.GetComponent<Collider>(), GetComponent<Collider>());
        Physics.IgnoreCollision(missao02.GetComponent<Collider>(), GetComponent<Collider>());
        Physics.IgnoreCollision(missao03.GetComponent<Collider>(), GetComponent<Collider>());
        Physics.IgnoreCollision(naoColide.GetComponent<Collider>(), GetComponent<Collider>());
        //soltar = checar.sortarr;


        if (checar.pegou == true)
        {
            one = false;
        }
        else if(checar.pegou == false)
        {
            one = true;
        }


        if(caixinha.isTrigger == true)
        {
            moverObjeto();
        }


    }


    private void OnTriggerEnter(Collider other)
    {

       
        sensorr = other.gameObject;

        if (other.tag != "sensor")
        {
            soltar = true;
            //sensorrrr.GetComponent<sensor>().soltarObjetoDefinitivo();
            print("colidiuTrigger");

        }



        if (other.tag == "sensor")
        {
            if(sensorrrr.GetComponent<visualizar>().visualizando == false)
            {
                definirPosicao();
            }
           
        }
        if (other.tag == "sensor" || other.tag == "sensorAntigo")
        {
            soltar = false;
        }


        if (other.tag == "sensor" && sensorrrr.GetComponent<sensor>().pegou == false && trocando == false || other.tag == "sensorAntigo" && sensorrrr.GetComponent<sensor>().pegou == false && trocando == false)
        {

            materalis[1] = material01;
            materalis[2] = material02;
            trocando = true;
            capa.materials = materalis;
        }

    }

   


    private void OnTriggerExit(Collider other)
    {
        sensorr = null;
        if(other.tag == "sensor" && trocando == true)
        {

            materalis[1] = esteMaterial;
            materalis[2] = esteMaterial;

            
            trocando = false;
            capa.materials = materalis;
            
        }
    }


    public void OnCollisionEnter(Collision collision)
    {

        if (collision.transform.tag == "interagir")
        {
            transform.parent = collision.transform;
            // transform.localScale = new Vector3(sx, sy, sz);
        }

        if (collision.gameObject.tag != "sensor" || collision.gameObject.tag != "sensorAntigo")
        {
            soltar = true;
            //sensorrrr.GetComponent<sensor>().soltarObjetoDefinitivo();
            print("colidiuColider");

            GetComponent<Rigidbody>().isKinematic = false;
            GetComponent<BoxCollider>().isTrigger = false;
            gameObject.layer = 0;


        }


    }

    public void OnCollisionExit(Collision collision)
    {

        if (collision.transform.tag == "interagir")
        {
            transform.parent = pai;
            transform.localScale = new Vector3(sx, sy, sz);
        }

    }


    private void definirPosicao()
    {

        px = transform.position.x;
        py = transform.position.y;
        pz = transform.position.z;
        rx = transform.rotation.x;
        ry = transform.rotation.y;
        rz = transform.rotation.z;
        rw = transform.rotation.w;

        posicao = new Vector3(px, py, pz);
        rotacao = new Quaternion(rx, ry, rz, rw);

    }


    


    private void moverObjeto()
    {
        if(booleano != null && gameObject.tag == "objeto" || booleano != null && gameObject.tag == "olhar" 
            || booleano != null && gameObject.tag == "folha" || booleano != null && gameObject.tag == "item" 
            || booleano != null && gameObject.tag == "obejtoJaPego")
        {
            if (Input.GetKey(KeyCode.W))
            {
                transform.Rotate(0, 0, 200 * Time.deltaTime);
            }

            if (Input.GetKey(KeyCode.S))
            {
                transform.Rotate(0, 0, -200 * Time.deltaTime);
            }


            if (Input.GetKey(KeyCode.D))
            {
               
                transform.Rotate(200 * Time.deltaTime, 0, 0);
            }


            if (Input.GetKey(KeyCode.A))
            {
                
                transform.Rotate(-200 * Time.deltaTime, 0, 0);
            }


            if (Input.GetKey(KeyCode.Z))
            {
                transform.Rotate(0, 200 * Time.deltaTime, 0);
            }


            if (Input.GetKey(KeyCode.X))
            {
                transform.Rotate(0, -200 * Time.deltaTime, 0);
            }



        }



    }

    

    private void retorn()
    {
        if(gameObject.tag == "folha" && sensorrrr.GetComponent<visualizar>().visualizando == false || gameObject.tag == "item" && sensorrrr.GetComponent<visualizar>().visualizando == false)
        {
           if(pai != null)
            {
                transform.position = pai.position;
            }
           
        }
       
    }

    private void enviaritem()
    {
        if(sensorrrr.GetComponent<visualizar>().verificacao != null)
        {
            if(sensorrrr.GetComponent<visualizar>().objetos != null)
            {
                if (ids != 0 && cont02 == 0 && gameObject.name == sensorrrr.GetComponent<visualizar>().objetos.name && naoPode == true)
                {
                    if (gameObject.tag == "folha")
                    {
                        if (sensorrrr.GetComponent<visualizar>().visualizando == true)
                        {
                            canvas.GetComponent<coletarPaginas>().descricaoObjeto[canvas.GetComponent<coletarPaginas>().codigoID] = descricao;
                            canvas.GetComponent<coletarPaginas>().codigoID++;
                            cont02++;
                            podeDestroir = true;
                        }
                    }
                }
            }
        }
            
        
           
        
    }


    //sensorrrr.GetComponent<visualizar>().verificacao.name
}
