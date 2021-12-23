using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class porta : MonoBehaviour
{

    Animator anim;
    public bool chave, aberta, invertendo, virou, destravou;
    public GameObject player, chavees, entrada, sensorrr;
    public string tipoChave;
    //public Transform entrada;
    public Transform massanetaa, pai;
   

    

    //audio

    public bool massanetaaa, abrindo, fechando, cont4;
    public AudioClip massaneta, portaAbrindo, bateu;
    int cont, cont2, cont3;

    [SerializeField]
    float distancia;

    // Start is called before the first frame update
    void Start()
    {
        cont4 = false;
        massanetaaa = false;
        massanetaa = transform.Find("Cylinder");
        entrada =  transform.Find("masaneta").gameObject;
        chavees = GameObject.Find(tipoChave);
        if(chavees != null)
        {
            pai = chavees.transform;
        }
        sensorrr = GameObject.Find("sensor");
        player = GameObject.Find("FPSController");
        anim = GetComponent<Animator>();
        destravou = false;
        abrindo = false;
        fechando = false;
        cont = 0;
        cont3 = 0;
        massanetaa.GetComponent<AudioSource>().clip = null;
    }

    // Update is called once per frame
    void Update()
    {

        if (chavees != null)
        {
            distancia = Vector3.Distance(transform.position, chavees.transform.position);
            if (distancia < 1.6f)
            {
                if (chave == false)
                {

                    destravou = true;
                    chavees.tag = "Untagged";

                }
            }
        }

        
        portaa();
        anim.SetBool("fudeu", player.GetComponent<acabouTempo>().acabou);
        anim.SetBool("sanidade", player.GetComponent<acabouTempo>().voltou);



        if (destravou == true)
        {
            if(sensorrr.GetComponent<visualizar>().visualizando == true)
            {
                chavees.transform.parent = pai;
            }
            if(sensorrr.GetComponent<visualizar>().visualizando == false)
            {
                chavees.transform.position = entrada.transform.position;
                chavees.transform.rotation = entrada.transform.rotation;
                chavees.GetComponent<BoxCollider>().isTrigger = true;
                chavees.GetComponent<Rigidbody>().isKinematic = true;
                chave = true;
                chavees.transform.parent = entrada.transform;
            }
            
        }

        


        if (virou == true)
        {
            if (transform.position.z > player.transform.position.z)
            {
                invertendo = false;
            }
            else if (transform.position.z < player.transform.position.z)
            {
                invertendo = true;
            }

        }

        if (virou == false)
        {

            if (transform.position.x > player.transform.position.x)
            {
                invertendo = false;
            }
            else if (transform.position.x < player.transform.position.x)
            {
                invertendo = true;
            }

        }

            anim.SetBool("inverter", invertendo);

        

    }


    private void OnTriggerEnter(Collider other)
    {
        if(chave == false)
        {
            if (other.name == tipoChave)
            {
                destravou = true;
                chavees.tag = "Untagged";
            }
        }
        


        if(other.tag == "sensor" && sensorrr.GetComponent<sensor>().testo.gameObject == gameObject && cont4 == true)
        {
            if(Input.GetKeyDown(KeyCode.E) || Input.GetKeyDown(KeyCode.Mouse0))
            {
                anim.SetBool("chave", chave);
                
                if (aberta == false)
                {
                    anim.SetTrigger("abriu");
                }
               if(aberta == true)
                {
                    anim.SetTrigger("fechou");
                }
            }
        }
    }
    private void OnTriggerStay(Collider other)
    {

        if (chave == false)
        {
            if (other.name == tipoChave)
            {
                destravou = true;
                chavees.tag = "Untagged";
            }
        }


        if (other.tag == "sensor" && sensorrr.GetComponent<sensor>().testo.gameObject == gameObject && cont4 == true)
        {
            if (Input.GetKeyDown(KeyCode.E) || Input.GetKeyDown(KeyCode.Mouse0))
            {
                anim.SetBool("chave", chave);
                
                if (aberta == false)
                {
                    anim.SetTrigger("abriu");
                }
                if (aberta == true)
                {
                    anim.SetTrigger("fechou");
                }
            }
        }
    }

    private void OnCollisionEnter(Collision collision)
    {

        if (chave == false)
        {
            if (collision.gameObject.name == tipoChave)
            {
                destravou = true;
                chavees.tag = "Untagged";
            }
        }



        if (collision.gameObject.tag == "sensor" && sensorrr.GetComponent<sensor>().testo.gameObject == gameObject && cont4 == true)
        {
            if (Input.GetKeyDown(KeyCode.E) || Input.GetKeyDown(KeyCode.Mouse0))
            {
                anim.SetBool("chave", chave);

                if (aberta == false)
                {
                    anim.SetTrigger("abriu");
                }
                if (aberta == true)
                {
                    anim.SetTrigger("fechou");
                }
            }
        }
    }
    private void OnCollisionStay(Collision collision)
    {


        if (chave == false)
        {
            if (collision.gameObject.name == tipoChave)
            {
                destravou = true;
                chavees.tag = "Untagged";
            }
        }


        if (collision.gameObject.tag == "sensor" && sensorrr.GetComponent<sensor>().testo.gameObject == gameObject && cont4 == true)
        {
            if (Input.GetKeyDown(KeyCode.E) || Input.GetKeyDown(KeyCode.Mouse0))
            {
                anim.SetBool("chave", chave);

                if (aberta == false)
                {
                    anim.SetTrigger("abriu");
                }
                if (aberta == true)
                {
                    anim.SetTrigger("fechou");
                }
            }
        }
    }



    private void portaa()
    {

        // massaneta

        if(massanetaaa == true)
        {
         
            massanetaa.GetComponent<AudioSource>().clip = massaneta;
            if(cont == 0)
            {
                massanetaa.GetComponent<AudioSource>().Play();
                cont++;
            }
            
        }

        if (player.GetComponent<acabouTempo>().acabou == true && player.GetComponent<acabouTempo>().voltou == false)
        {
            massanetaa.GetComponent<AudioSource>().loop = true;
            massanetaa.GetComponent<AudioSource>().Play();

        }
        if(player.GetComponent<acabouTempo>().voltou == true)
        {
            massanetaa.GetComponent<AudioSource>().loop = false;
        }


        else if(massanetaaa == false && cont == 1 && player.GetComponent<acabouTempo>().acabou == false)
        {
            massanetaa.GetComponent<AudioSource>().clip = null;
            cont = 0;
        }


        // porta abrindo

        if (abrindo == true)
        {
            massanetaa.GetComponent<AudioSource>().clip = portaAbrindo;
            if (cont2 == 0)
            {
                massanetaa.GetComponent<AudioSource>().Play(1);
                cont2++;
            }

        }
        else if (abrindo == false && cont2 == 1)
        {
            massanetaa.GetComponent<AudioSource>().clip = null;
            cont2 = 0;
        }


        //porta destrancada

        if (fechando == true)
        {
            massanetaa.GetComponent<AudioSource>().clip = bateu;
            if (cont3 == 0)
            {
                massanetaa.GetComponent<AudioSource>().Play(1);
                cont3++;
            }

        }
        else if (fechando == false && cont3 == 1)
        {
            massanetaa.GetComponent<AudioSource>().clip = null;
            cont3 = 0;
        }




    }




}
