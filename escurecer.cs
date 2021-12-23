using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class escurecer : MonoBehaviour
{

    public bool fim, banho, parado, fim02;
    Animator anim;
    public GameObject chuverito;
    public GameObject chuveiro, inimigoss, player;
    int cont, cont02, cont03, cont04;
    [SerializeField]
    public string cenaAtual, menu;
    [SerializeField]
    bool DEMO;

    // Start is called before the first frame update
    void Start()
    {
        cont02 = 0;
        cont = 0;
        banho = false;
        parado = false;
        fim = false;
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if(player == null)
        {
            player = GameObject.FindGameObjectWithTag("Player");
        }


        if(inimigoss == null && player != null)
        {
            if(player.GetComponent<acabouTempo>().acabou == true)
            {
                inimigoss = GameObject.FindGameObjectWithTag("inimigo");
            }
            
        }

        if(inimigoss != null)
        {
            if(inimigoss.GetComponent<inimigo>().gameOver == true)
            {
                if(cont04 == 0)
                {
                    cont04 = 1;
                    anim.SetBool("gameOver", true);
                }
                if(cont04 == 1)
                {
                    StartCoroutine(fimGameMesmo());
                }
               
            }
        }
        if(fim02 == true)
        {
            SceneManager.LoadScene(cenaAtual);
        }
        

        if(parado == true)
        {
            chuverito.SetActive(true);
            cont03 = 1;
        }
        if(parado == false && cont03 == 1)
        {
          
            chuverito.SetActive(false);
            cont03 = 2;
            
        }


        if(fim == true && cont == 0)
        {
            StartCoroutine(fimGame());
            cont = 1;
        }


        if(banho == false)
        {
            anim.SetBool("tomouBanho", false);
        }

       // anim.SetBool("tomouBanho", banho);

    }

    IEnumerator fimGame()
    {
        yield return new WaitForSeconds(2f);
        if(DEMO == false)
        {
            SceneManager.LoadScene(menu);
        }
        else if(DEMO == true)
        {
            SceneManager.LoadScene("creditoDemo");
        }
        

    }


    IEnumerator fimGameMesmo()
    {
        yield return new WaitForSeconds(0.2f);
        anim.SetBool("gameOver", false);
    }

}
