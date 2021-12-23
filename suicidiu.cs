using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Timeline;
using UnityEngine.Playables;
using UnityStandardAssets.Characters.FirstPerson;
using UnityEngine.SceneManagement;
using Steamworks;


public class suicidiu : MonoBehaviour
{
    [SerializeField]
    GameObject player, ponto, missoesss;
    int foogo;
    [SerializeField]
    ParticleSystem[] explocao;

    PlayableDirector oFim;


    [SerializeField]
    AudioSource[] somFase;
    //TimelinePlayable oFim;
    //TimelineClip
    //TimelinePlayable
    //PlayableTrack


    bool interagir, oFrandeFim;
    int cont;

    // Start is called before the first frame update
    void Start()
    {
        oFim = GetComponent<PlayableDirector>();
        oFrandeFim = false;
        interagir = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (missoesss.GetComponent<missao05>().deu[0] == true &&
            missoesss.GetComponent<missao05>().deu[1] == true &&
            missoesss.GetComponent<missao05>().deu[2] == true &&
            missoesss.GetComponent<missao05>().deu[3] == true &&
            missoesss.GetComponent<missao05>().deu[4] == true &&
            missoesss.GetComponent<missao05>().deu[5] == true)

        {
            if (interagir == true && Input.GetKeyDown(KeyCode.E))
            {
                oFrandeFim = true;

            }
        }


        if (oFrandeFim == true)
        {
            
            player.transform.position = ponto.transform.position;
            player.transform.rotation = ponto.transform.rotation;
            player.GetComponent<FirstPersonController>().pausarCamera = true;
            if (cont == 0)
            {
                cont = 1;
                missoesss.GetComponent<missao05>().tarefa04();
                StartCoroutine(morreu());
                oFim.Play();
                explocao[foogo].Play();
                StartCoroutine(fogos());
                StartCoroutine(trocaCena());
                audioAPAGADO();
                SteamUserStats.SetAchievement("NEW_ACHIEVEMENT_1_4");
                SteamUserStats.StoreStats();
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "sensor")
        {
            interagir = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "sensor")
        {
            interagir = false;
        }
    }


    IEnumerator morreu()
    {
        yield return new WaitForSeconds(24f);
        missoesss.GetComponent<missao05>().tarefa05();
    }

    IEnumerator fogos()
    {
        foogo++;
        explocao[foogo].Play();
        yield return new WaitForSeconds(3f);

        if (foogo < 4)
        {
            StartCoroutine(fogos());
        }

    }

    IEnumerator trocaCena()
    {
        yield return new WaitForSeconds(28f);
        SceneManager.LoadScene("semana06");
    }



    private void audioAPAGADO()
    {

        somFase[0].Stop();
        somFase[1].Stop();
        somFase[2].Stop();
        somFase[3].Stop();
        somFase[4].Stop();
        somFase[5].Stop();
        somFase[6].Stop();
        somFase[7].Stop();
        somFase[8].Stop();
        somFase[9].Stop();
        somFase[10].Stop();
        somFase[11].Stop();
        somFase[12].Stop();
        somFase[13].Stop();
        somFase[14].Stop();
        somFase[15].Stop();
        somFase[16].Stop();
        somFase[17].Stop();
        somFase[18].Stop();
        somFase[19].Stop();
        somFase[20].Stop();
        somFase[21].Stop();
        somFase[22].Stop();
        somFase[23].Stop();
        somFase[24].Stop();
        somFase[25].Stop();
        somFase[26].Stop();
        somFase[27].Stop();
        somFase[28].Stop();
        somFase[29].Stop();



    }

}


