using System;
using UnityEngine;
using System.Collections;
using UnityStandardAssets.Characters.FirstPerson;
public class balancoCamera : MonoBehaviour
{

    float limite;
    [SerializeField]
    CharacterController controller;
    [SerializeField]
    bool parado, correr, cansado, recuperar, cansadu, podeCorrer, agaichar, naoPodeaGaichar, naoAndar;

    GameObject player;
    AudioSource som;

    Animator anim;

    [SerializeField]
    int cont;

    [SerializeField]
    int tempo, estamina;

    [SerializeField]
    GameObject levantado, agachado, cameraa;
    
    void Start()
    {
        levantado = GameObject.Find("levantado");
        agachado = GameObject.Find("agachando");
        cameraa = GameObject.Find("FirstPersonCharacter");

        cont = 0;
        estamina = 8;
        cansado = false;
        cansadu = false;
        tempo = estamina;
        som = GetComponent<AudioSource>();
        correr = false;
        anim = GetComponent<Animator>();
        player = controller.gameObject;
    }
    void Update()
    {
        try
        {
            if (Input.GetKey(KeyCode.LeftControl) && naoPodeaGaichar == false)
            {
                agaichar = true;

                if (player.GetComponent<acabouTempo>().inimigoVei == null)
                {
                    player.GetComponent<FirstPersonController>().m_RunSpeed = 0.5f;
                    player.GetComponent<FirstPersonController>().m_WalkSpeed = 0.5f;
                }
                else if (player.GetComponent<acabouTempo>().inimigoVei != null)
                {
                    player.GetComponent<FirstPersonController>().m_RunSpeed = 0.5f;
                    player.GetComponent<FirstPersonController>().m_WalkSpeed = 0.5f;
                }


            }
            else if (Input.GetKeyUp(KeyCode.LeftControl) && naoPodeaGaichar == false)
            {
                agaichar = false;

                if (player.GetComponent<acabouTempo>().inimigoVei == null && cansadu == false)
                {
                    player.GetComponent<FirstPersonController>().m_RunSpeed = 4;
                    player.GetComponent<FirstPersonController>().m_WalkSpeed = 3;
                }
                else if (player.GetComponent<acabouTempo>().inimigoVei != null)
                {
                    player.GetComponent<FirstPersonController>().m_RunSpeed = 0.5f;
                    player.GetComponent<FirstPersonController>().m_WalkSpeed = 0.5f;
                }
            }


            if (agaichar == true)
            {
                cameraa.transform.position = Vector3.Lerp(cameraa.transform.position, agachado.transform.position, Time.deltaTime * 2);
                player.GetComponent<FirstPersonController>().semSom = true;
            }
            else if (agaichar == false)
            {
                cameraa.transform.position = Vector3.Lerp(cameraa.transform.position, levantado.transform.position, Time.deltaTime * 2);
                player.GetComponent<FirstPersonController>().semSom = false;
            }

            anim.SetBool("parado", parado);
            anim.SetBool("correr", correr);

            // || controller.velocity.magnitude <= limite
            if (controller.velocity.magnitude <= limite)
            {
                parado = true;
            }
            else if (controller.velocity.magnitude > limite && correr == false && naoAndar == false)
            {
                parado = false;
            }


            if (Input.GetKey(KeyCode.LeftShift) && parado == false && tempo != 0 && player.GetComponent<acabouTempo>().inimigoVei == null && podeCorrer == false && agaichar == false)
            {
                correr = true;
                if (cansado == false)
                {
                    StartCoroutine(descartarEnergia());
                }

            }
            if (Input.GetKeyUp(KeyCode.LeftShift) || cansadu == true)
            {
                correr = false;
            }

            if (correr == false)
            {
                if (recuperar == true && cansadu == false && cont == 0)
                {
                    cont = 1;
                    StartCoroutine(recuperarEnergia());
                    print("chegouAqui");

                }

            }
            //tempo == estamina && 
            if (correr == false)
            {
                recuperar = true;
            }
        }
        catch (Exception e)
        {
            print(e.ToString());
            PlayerPrefs.SetString("errorBalancoCamera", e.ToString());
        }

    }


    private IEnumerator oii()
    {
        som.Play();
        if(player.GetComponent<acabouTempo>().inimigoVei == null)
        {
            player.GetComponent<FirstPersonController>().m_RunSpeed = 2;
            player.GetComponent<FirstPersonController>().m_WalkSpeed = 2;
        }
        else if(player.GetComponent<acabouTempo>().inimigoVei != null)
        {
            player.GetComponent<FirstPersonController>().m_RunSpeed = 0.5f;
            player.GetComponent<FirstPersonController>().m_WalkSpeed = 0.5f;
        }

        yield return new WaitForSeconds(5f);
        tempo = estamina;
        cansado = false;
        cansadu = false;
        if (player.GetComponent<acabouTempo>().inimigoVei == null)
        {
            player.GetComponent<FirstPersonController>().m_RunSpeed = 4;
            player.GetComponent<FirstPersonController>().m_WalkSpeed = 3;
        }
        else if(player.GetComponent<acabouTempo>().inimigoVei != null)
        {
            player.GetComponent<FirstPersonController>().m_RunSpeed = 0.5f;
            player.GetComponent<FirstPersonController>().m_WalkSpeed = 0.5f;
        }
        
        som.Stop();
    }

    private IEnumerator descartarEnergia()
    {
        cansado = true;
        if (tempo != 0)
        {
            tempo--;
        }
        yield return new WaitForSeconds(1f);
        cansado = false;
        
        if(tempo != 0 && Input.GetKey(KeyCode.LeftShift))
        {
            StartCoroutine(descartarEnergia());
        }
        if(tempo == 0 && cansadu == false)
        {
            cansadu = true;
            StartCoroutine(oii());
        }
        
    }
    private IEnumerator recuperarEnergia()
    {
        recuperar = false;

        yield return new WaitForSeconds(2f);
        cont = 0;
        print("chegouAqui02");
        if (tempo < estamina && tempo != 0 && correr == false)
        {
            
            tempo++;
        }
/*
        if (tempo < estamina && tempo != 0 && correr == false)
        {

            StartCoroutine(recuperarEnergia());
            
        }
  */      
    }


    }