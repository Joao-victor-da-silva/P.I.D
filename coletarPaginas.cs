using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Steamworks;

public class coletarPaginas : MonoBehaviour
{

    [SerializeField]
    GameObject texto, textoDescricao, contagem, agenda, numero, escurinho;
    public string[] descricao;
    public int codigo;
    public int codigoID;
    public string[] descricaoObjeto;
    [SerializeField]
    AudioClip song;
    AudioSource meuSong;
    [SerializeField]
    bool DEMO;


    // Start is called before the first frame update
    void Start()
    {
        escurinho = GameObject.Find("escurecer");
        codigoID = 0;
        numero.GetComponent<Text>().text = "" + codigo;
        meuSong = agenda.GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        print("paginas: " + codigoID);
        if(codigo == 0 && codigoID != 0)
        {
            numero.GetComponent<Text>().text = "" + (codigo + 1);
        }
        else if(codigo > 0)
        {
            numero.GetComponent<Text>().text = "" + (codigo + 1);
        }
        contagem.GetComponent<Text>().text = codigoID + " / 10";
        if (descricaoObjeto[codigoID] != null)
        {
            descricao[codigoID] = descricaoObjeto[codigoID];
            descricao[codigo] = descricaoObjeto[codigo];
        }
        textoDescricao.GetComponent<Text>().text = descricao[codigo];

        if (agenda.activeSelf == false)
        {
            texto.SetActive(false);
        }

        if (DEMO == false)
        {
            if (codigoID == 10 && escurinho.GetComponent<escurecer>().cenaAtual == "semana01")
            {
                SteamUserStats.SetAchievement("NEW_ACHIEVEMENT_1_7");
                SteamUserStats.StoreStats();
            }
            if (codigoID == 10 && escurinho.GetComponent<escurecer>().cenaAtual == "semana02")
            {
                SteamUserStats.SetAchievement("NEW_ACHIEVEMENT_1_8");
                SteamUserStats.StoreStats();
            }
            if (codigoID == 10 && escurinho.GetComponent<escurecer>().cenaAtual == "semana03")
            {
                SteamUserStats.SetAchievement("NEW_ACHIEVEMENT_1_9");
                SteamUserStats.StoreStats();
            }
            if (codigoID == 10 && escurinho.GetComponent<escurecer>().cenaAtual == "semana04")
            {
                SteamUserStats.SetAchievement("NEW_ACHIEVEMENT_1_10");
                SteamUserStats.StoreStats();
            }
            if (codigoID == 10 && escurinho.GetComponent<escurecer>().cenaAtual == "semana05")
            {
                SteamUserStats.SetAchievement("NEW_ACHIEVEMENT_1_11");
                SteamUserStats.StoreStats();
            }
        }
        


    }

    public void mudarpagina()
    {
        if (codigo < (codigoID - 1))
        {
            codigo++;
            meuSong.clip = song;
            meuSong.Play();
        }
            

    }

    public void voltarPagina()
    {
        if(codigo > 0)
        {
            codigo--;
            meuSong.clip = song;
            meuSong.Play();
        }
        

    }


    public void abrir()
    {
        if(texto.activeSelf == false)
        {
            texto.SetActive(true);
        }
        else if(texto.activeSelf == true)
        {
            texto.SetActive(false);
        }
    }

}
