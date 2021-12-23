using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.SceneManagement;
using Steamworks;

public class oGrandeFim : MonoBehaviour
{
    [SerializeField]
    GameObject oi, porta, porta02, datas;
    PlayableDirector fim;
    int cont;
    PlayableDirector fim02;
    [SerializeField]
    AudioSource vaiDarBom, billy;

    // Start is called before the first frame update
    void Start()
    {
        datas = GameObject.Find("DATA");
        vaiDarBom = GetComponent<AudioSource>();
        vaiDarBom.Play();
        fim = oi.GetComponent<PlayableDirector>();
        fim02 = porta02.GetComponent<PlayableDirector>();
    }

    // Update is called once per frame
    void Update()
    {
        if(porta.GetComponent<porta>().aberta == true && cont == 0)
        {
            cont = 1;
           
            fim.Play();
            StartCoroutine(oii());
            datas.GetComponent<data>().capitulo06 = true;
            SteamUserStats.SetAchievement("NEW_ACHIEVEMENT_1_5");
            SteamUserStats.StoreStats();

        }
        else if(porta02.GetComponent<porta>().aberta == true && cont == 0)
        {
            cont = 1;
            
            fim02.Play();
            StartCoroutine(falou());
            datas.GetComponent<data>().capitulo06 = true;
            SteamUserStats.SetAchievement("NEW_ACHIEVEMENT_1_6");
            SteamUserStats.StoreStats();
        }
    }


    IEnumerator oii()
    {
        billy.Stop();
        vaiDarBom.Stop();
        yield return new WaitForSeconds(18.5f);
        SceneManager.LoadScene("creditos");
    }
    IEnumerator falou()
    {
        billy.Stop();
        vaiDarBom.Stop();
        yield return new WaitForSeconds(24.5f);
        SceneManager.LoadScene("creditos");
    }
}
