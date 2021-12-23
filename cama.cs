using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Steamworks;

public class cama : MonoBehaviour
{

    public GameObject escurecendoo, objetivinho;
    bool troca, troca02;
    public GameObject chuverinho;
    int cont;
    [SerializeField]
    data datas;
    GameObject datass;
    int cont03;
    [SerializeField]
    bool DEMO;
    // Start is called before the first frame update
    void Start()
    {
        troca02 = false;
        datass = GameObject.Find("DATA");
        if (datass != null)
        {
            datas = GameObject.Find("DATA").GetComponent<data>();
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        if(cont03 == 0 && escurecendoo.GetComponent<escurecer>().cenaAtual == "semana02")
        {
            cont03 = 1;
            datas.Pegar();
        }
        if (cont03 == 0 && escurecendoo.GetComponent<escurecer>().cenaAtual == "semana03")
        {
            cont03 = 1;
            datas.Pegar();
            datas.Pegar02();
        }

        if (cont03 == 0 && escurecendoo.GetComponent<escurecer>().cenaAtual == "semana04")
        {
            cont03 = 1;
            datas.Pegar();
            datas.Pegar02();
            datas.Pegar03();
        }


        if (cont03 == 0 && escurecendoo.GetComponent<escurecer>().cenaAtual == "semana05")
        {
            cont03 = 1;
            datas.Pegar();
            datas.Pegar02();
            datas.Pegar03();
            datas.Pegar04();
        }

        if (objetivinho.GetComponent<objetivos>().podedormir == true && escurecendoo.GetComponent<escurecer>().cenaAtual != "semana05")
        {

           


            if (Input.GetKeyDown(KeyCode.E) && troca == true && cont == 0)
            {
                cont = 1;
                chuverinho.SetActive(true);
                objetivinho.GetComponent<objetivos>().cont5 = 1;
                escurecendoo.GetComponent<Animator>().SetBool("acabou", true);
                GetComponent<AudioSource>().Play();
                troca02 = true;
                if(escurecendoo.GetComponent<escurecer>().cenaAtual == "semana01")
                {
                    if(DEMO == false)
                    {
                        datas.capitulo02 = true;
                        datas.guardar();
                        SteamUserStats.SetAchievement("NEW_ACHIEVEMENT_1_0");
                        SteamUserStats.StoreStats();
                        print("foi????");
                    }
                    
                }
                if (escurecendoo.GetComponent<escurecer>().cenaAtual == "semana02")
                {
                    datas.capitulo03 = true;
                    datas.guardar02();
                    SteamUserStats.SetAchievement("NEW_ACHIEVEMENT_1_1");
                    SteamUserStats.StoreStats();
                }
                if (escurecendoo.GetComponent<escurecer>().cenaAtual == "semana03")
                {
                    datas.capitulo04 = true;
                    datas.guardar03();
                    SteamUserStats.SetAchievement("NEW_ACHIEVEMENT_1_2");
                    SteamUserStats.StoreStats();
                }
                if (escurecendoo.GetComponent<escurecer>().cenaAtual == "semana04")
                {
                    datas.capitulo05 = true;
                    datas.guardar04();
                    SteamUserStats.SetAchievement("NEW_ACHIEVEMENT_1_3");
                    SteamUserStats.StoreStats();
                }


            }
           
        }


    }


    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "sensor")
        {
            troca = true;
        }
       
    }


    private void OnTriggerExit(Collider other)
    {
        if(other.tag == "sensor")
        {
            troca = false;
        }
       
    }


}
