using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class interrupitor : MonoBehaviour
{

    Animator anim;
    public bool ligar, desligar;
    public GameObject luz;
    Light luzinha;
    [SerializeField]
    GameObject player, canvinhas;
    Color red, normal;

    [SerializeField]
    bool apagao;
    // Start is called before the first frame update
    void Start()
    {
        canvinhas = GameObject.Find("Canvas");
        red.g = 0;
        red.b = 0;
        red.a = 255;
        red.r = 255;
        anim = GetComponent<Animator>();
        luzinha = luz.GetComponent<Light>();
        normal.a = luzinha.color.a;
        normal.r = luzinha.color.r;
        normal.g = luzinha.color.g;
        normal.b = luzinha.color.b;
        ligar = false;
        desligar = true;
        
    }

    // Update is called once per frame
    void Update()
    {
        if(player == null)
        {
            player = GameObject.FindGameObjectWithTag("Player");
        }
        anim.SetBool("ligar", ligar);
        anim.SetBool("desligar", desligar);
        vermelho();

        if (canvinhas.GetComponent<objetivos>().apagao == true)
        {
            apagao = true;
        }

       if(apagao == true)
        {
            luzinha.intensity = 0;
            desligar = false;
        } 

    }



    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "sensor" && Input.GetKeyDown(KeyCode.E))
        {

            if (ligar == true)
            {
                luzinha.intensity = 1;
                desligar = true;
                ligar = false;
            }
            else if (ligar == false && apagao == false)
            {
                luzinha.intensity = 0;
                desligar = false;
                ligar = true;
            }


        }
        
            
        
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "sensor" && Input.GetKeyDown(KeyCode.E))
        {

            if (ligar == true)
            {
                luzinha.intensity = 1;
                desligar = true;
                ligar = false;
            }
            else if (ligar == false)
            {
                luzinha.intensity = 0;
                desligar = false;
                ligar = true;
            }


        }
    }

    private void vermelho()
    {
        if(player.GetComponent<acabouTempo>().acabou == true && player.GetComponent<acabouTempo>().voltou == false)
        {
            luzinha.color = red;
            //luzinha.range = 4;
            luzinha.intensity = 0.01f;
        }

        if (player.GetComponent<acabouTempo>().voltou == true )
        {
            luzinha.color = normal;
            //luzinha.range = 10;
            luzinha.intensity = 1f;
        }


    }


   

}
