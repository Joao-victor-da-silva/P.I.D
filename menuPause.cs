using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityStandardAssets.Characters.FirstPerson;
using UnityEngine.PostProcessing;

public class menuPause : MonoBehaviour
{

    public GameObject painel01, painel02, player, agenda, cameraa, botao, visualizando;
    public bool pausado, liberarMouse, inventarios;

    FirstPersonController jogador;

    public Dropdown resolucao, qualidade;
    public Slider audios;
    int parar = 0, cont;

    public GameObject diarioI;
    [SerializeField]
    Transform tutorial01, tutorial02, tutorial03;

    // agenda
    
    public GameObject segunda, terca, quarta, quinta, sexta, sabado, domingo;
    public GameObject segunda01, terca02, quarta03, quinta04, sexta05, sabado06, domingo07;

    public GameObject menuI;

    [SerializeField]
    GameObject semana01, semana02, semana03, semana04, semana05;

    //////////////////
    [SerializeField]
    GameObject[] segundas, tercas, quartas, quintas, sextas, sabados, domingos;
    
    [SerializeField]
    GameObject grafico01, grafico02, grafico03, grafico04, grafico05;

    [SerializeField]
    PostProcessingBehaviour ultra;

    AudioSource pegouDiario;


    /// /////////


    public AudioClip folha, diarios;

    int conta, cont03;

    public bool podePausar = true;


    /// 

    [SerializeField]
    data voltarCENA;

    [SerializeField]
    GameObject datas;

    [SerializeField]
    GameObject painelInventarios;
    // Start is called before the first frame update
    void Start()
    {


        qualidade.options[0].text = GameMultiLang.GetTraduction("Muito Baixo");
        qualidade.options[1].text = GameMultiLang.GetTraduction("Baixo");
        qualidade.options[2].text = GameMultiLang.GetTraduction("Medio");
        qualidade.options[3].text = GameMultiLang.GetTraduction("Alto");
        qualidade.options[4].text = GameMultiLang.GetTraduction("Muito Alto");
        qualidade.options[5].text = GameMultiLang.GetTraduction("Ultra");



        datas = GameObject.Find("DATA");
        if(datas != null)
        {
            voltarCENA = GameObject.Find("DATA").GetComponent<data>();
        }
       if(datas != null)
        {
            voltarCENA.voltarcena();
        }
        
        pegouDiario = agenda.GetComponent<AudioSource>();
        //tutorial01 = diarioI.transform.Find("Ptutorial01");
        //tutorial02 = diarioI.transform.Find("Ptutorial02");
        //tutorial03 = diarioI.transform.Find("Ptutorial03");
        fecharInventario();

        if (Screen.fullScreen == true)
        {
            botao.GetComponent<Toggle>().isOn = true;
        }
        if (Screen.fullScreen == false)
        {
            botao.GetComponent<Toggle>().isOn = false;
        }



        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
       

        

        //puxarResolucao();
       
        audios.value = AudioListener.volume;
        qualidade.value = QualitySettings.GetQualityLevel();
        mudarqualidade();
        //resolucao.value = Screen.resolutions.Rank;








        pausado = false;
        inventarios = false;
        menuI.SetActive(false);
        jogador = player.GetComponent<FirstPersonController>();

    }

    // Update is called once per frame
    void Update()
    {
        controleDiario();
        ptutoriais();

            //jogador.m_MouseLook.lockCursor = liberarMouse;

        diario();
       apertarI();
        if(painel02.activeSelf == true)
        {
            mudarqualidade();
        }
       /*
        if(painel01.activeSelf == true)
        {
            cameraa.GetComponent<AudioListener>().enabled = false;
        }
        else if(painel01.activeSelf == false)
        {
            cameraa.GetComponent<AudioListener>().enabled = true;
        }
        */
        if (Input.GetKeyDown(KeyCode.Escape))
        {

            if(agenda.activeSelf == true)
            {
                fecharInventario();
            }

            if (pausado == false && agenda.activeSelf == false && podePausar == true && visualizando.GetComponent<visualizar>().visualizando == false && painel02.activeSelf == false)
            {
                Cursor.lockState = CursorLockMode.None;
                Time.timeScale = 0;
                painel01.SetActive(true);
                pausado = true;
                liberarMouse = false;
                painel02.SetActive(false);
                Cursor.visible = true;
                
            }
            else
            {
                Cursor.lockState = CursorLockMode.Locked;
                Time.timeScale = 1;
                painel01.SetActive(false);
                painel02.SetActive(false);
                pausado = false;
                liberarMouse = true;
                Cursor.visible = false;
                agenda.SetActive(false);
                
            }


        }






    }


    private void controleDiario()
    {

        if (semana01 != null)
        {

            if (semana01.activeSelf == true)
            {
                segunda = segundas[0];
                terca = tercas[0];
                quarta = quartas[0];
                quinta = quintas[0];
                sexta = sextas[0];
                sabado = sabados[0];
                domingo = domingos[0];
            }

        }

        if (semana02 != null)
        {

            if (semana02.activeSelf == true)
            {
                segunda = segundas[1];
                terca = tercas[1];
                quarta = quartas[1];
                quinta = quintas[1];
                sexta = sextas[1];
                sabado = sabados[1];
                domingo = domingos[1];
            }

        }
        if (semana03 != null)
        {

            if (semana03.activeSelf == true)
            {
                segunda = segundas[2];
                terca = tercas[2];
                quarta = quartas[2];
                quinta = quintas[2];
                sexta = sextas[2];
                sabado = sabados[2];
                domingo = domingos[2];
            }

        }

        if(semana04 != null)
        {
            if (semana04.activeSelf == true)
            {
                segunda = segundas[3];
                terca = tercas[3];
                quarta = quartas[3];
                quinta = quintas[3];
                sexta = sextas[3];
                sabado = sabados[3];
                domingo = domingos[3];
            }
        }

        if (semana05 != null)
        {
            if (semana05.activeSelf == true)
            {
                segunda = segundas[4];
                terca = tercas[4];
                quarta = quartas[4];
                quinta = quintas[4];
                sexta = sextas[4];
                sabado = sabados[4];
                domingo = domingos[4];
            }
        }

    }


    private void apertarI()
    {
        if(painel01.activeSelf == true || painel02.activeSelf == true)
        {
            menuI.SetActive(false);
        }
        else if( painel01.activeSelf == false && painel02.activeSelf == false)
        {
            menuI.SetActive(true);
        }
       
    }


    public void continuar()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Time.timeScale = 1;
        painel01.SetActive(false);
        pausado = false;
        liberarMouse = true;
        Cursor.visible = false;
        StartCoroutine(parara());

    }

    public void sair()
    {
        SceneManager.LoadScene("menu");
    }

    public void menu()
    {
        painel01.SetActive(false);
        painel02.SetActive(true);
    }

    public void SairOpcoes()
    {
        painel01.SetActive(true);
        painel02.SetActive(false);
    }


    public void teclaCheia()
    {
        /* if (Screen.fullScreen == true)
         {
             Screen.fullScreen = false;
         }
         if (Screen.fullScreen == false)
         {
             Screen.fullScreen = true;
         }*/

        if (botao.GetComponent<Toggle>().isOn == false)
        {
            Screen.fullScreen = false;
        }
        if (botao.GetComponent<Toggle>().isOn == true)
        {
            Screen.fullScreen = true;
        }


    }
   /* public void puxarResolucao()
    {
        Resolution[] todasResolucoes = Screen.resolutions;
        resolucao.options.Clear();
        for (int y = 0; y < todasResolucoes.Length; y++)
            resolucao.options.Add(new Dropdown.OptionData()
            {
                text = todasResolucoes[y].width + "x" + todasResolucoes[y].height
            });
        Screen.SetResolution(todasResolucoes[resolucao.value].width, todasResolucoes[resolucao.value].height, Screen.fullScreen);
        resolucao.value = 30;
    }*/

    public void Grafico()
    {

        QualitySettings.SetQualityLevel(qualidade.value);

    }

    

    public void volume()
    {

        AudioListener.volume = audios.value;

    }




    // agenda



    public void segundaa()
    {
        conta = 0;
        cameraa.GetComponent<AudioSource>().clip = folha;
        if(conta == 0)
        {
            cameraa.GetComponent<AudioSource>().Play();
            conta = 1;
        }

        segunda.SetActive(true);
        terca.SetActive(false);
        quarta.SetActive(false);
        quinta.SetActive(false);
        sexta.SetActive(false);
        sabado.SetActive(false);
        domingo.SetActive(false);
        
    }

    public void tercaa()
    {
        conta = 0;
        cameraa.GetComponent<AudioSource>().clip = folha;
        if (conta == 0)
        {
            cameraa.GetComponent<AudioSource>().Play();
            conta = 1;
        }


        segunda.SetActive(false);
        terca.SetActive(true);
        quarta.SetActive(false);
        quinta.SetActive(false);
        sexta.SetActive(false);
        sabado.SetActive(false);
        domingo.SetActive(false);
    }

    public void quartaa()
    {
        conta = 0;
        cameraa.GetComponent<AudioSource>().clip = folha;
        if (conta == 0)
        {
            cameraa.GetComponent<AudioSource>().Play();
            conta = 1;
        }



        segunda.SetActive(false);
        terca.SetActive(false);
        quarta.SetActive(true);
        quinta.SetActive(false);
        sexta.SetActive(false);
        sabado.SetActive(false);
        domingo.SetActive(false);
    }

    public void quintaa()
    {
        conta = 0;
        cameraa.GetComponent<AudioSource>().clip = folha;
        if (conta == 0)
        {
            cameraa.GetComponent<AudioSource>().Play();
            conta = 1;
        }

        segunda.SetActive(false);
        terca.SetActive(false);
        quarta.SetActive(false);
        quinta.SetActive(true);
        sexta.SetActive(false);
        sabado.SetActive(false);
        domingo.SetActive(false);
    }

    public void sextaa()
    {
        conta = 0;
        cameraa.GetComponent<AudioSource>().clip = folha;
        if (conta == 0)
        {
            cameraa.GetComponent<AudioSource>().Play();
            conta = 1;
        }



        segunda.SetActive(false);
        terca.SetActive(false);
        quarta.SetActive(false);
        quinta.SetActive(false);
        sexta.SetActive(true);
        sabado.SetActive(false);
        domingo.SetActive(false);
    }

    public void sabadoo()
    {
        conta = 0;
        cameraa.GetComponent<AudioSource>().clip = folha;
        if (conta == 0)
        {
            cameraa.GetComponent<AudioSource>().Play();
            conta = 1;
        }


        segunda.SetActive(false);
        terca.SetActive(false);
        quarta.SetActive(false);
        quinta.SetActive(false);
        sexta.SetActive(false);
        sabado.SetActive(true);
        domingo.SetActive(false);
    }

    public void domingoo()
    {
        conta = 0;
        cameraa.GetComponent<AudioSource>().clip = folha;
        if (conta == 0)
        {
            cameraa.GetComponent<AudioSource>().Play();
            conta = 1;
        }


        segunda.SetActive(false);
        terca.SetActive(false);
        quarta.SetActive(false);
        quinta.SetActive(false);
        sexta.SetActive(false);
        sabado.SetActive(false);
        domingo.SetActive(true);
    }

    public void agendaa()
    {
        painel01.SetActive(false);
        agenda.SetActive(true);
    }

    public void sairAgenda()
    {
        painel01.SetActive(true);
        agenda.SetActive(false);
    }


    private void diario()
    {
        if (Input.GetKeyDown(KeyCode.I) && pausado == false)
        {
            if(inventarios == false)
            {
                agenda.SetActive(true);
                pegouDiario.clip = diarios;
                pegouDiario.Play();
                Cursor.lockState = CursorLockMode.None;
                Time.timeScale = 0;
                //pausado = true;
                liberarMouse = false;
                Cursor.visible = true;
                inventarios = true;
                podePausar = false;
                //painelInventarios.SetActive(true);
            }
            else
            {
                
                agenda.SetActive(false);
                Cursor.lockState = CursorLockMode.Locked;
                Time.timeScale = 1;
                //pausado = false;
                liberarMouse = true;
                Cursor.visible = false;
                inventarios = false;
                painelInventarios.SetActive(false);
                fecharInventario();
            }

        }


        
    }


    public void fecharInventario()
    {

            agenda.SetActive(false);
            Cursor.lockState = CursorLockMode.Locked;
            Time.timeScale = 1;
            Cursor.visible = false;
            StartCoroutine(parara());
    }


    public IEnumerator parara()
    {
        yield return new WaitForSeconds(0.2f);
        podePausar = true;
    }


    private void mudarqualidade()
    {
        if(qualidade.value == 0)
        {
            grafico01.SetActive(true);
            grafico02.SetActive(false);
            grafico03.SetActive(false);
            grafico04.SetActive(false);
            grafico05.SetActive(false);
            ultra.enabled = false;
        }
        else if(qualidade.value == 1)
        {
            grafico01.SetActive(false);
            grafico02.SetActive(true);
            grafico03.SetActive(false);
            grafico04.SetActive(false);
            grafico05.SetActive(false);
            ultra.enabled = false;
        }
        else if (qualidade.value == 2)
        {
            grafico01.SetActive(false);
            grafico02.SetActive(false);
            grafico03.SetActive(true);
            grafico04.SetActive(false);
            grafico05.SetActive(false);
            ultra.enabled = false;
        }
        else if (qualidade.value == 3)
        {
            grafico01.SetActive(false);
            grafico02.SetActive(false);
            grafico03.SetActive(false);
            grafico04.SetActive(true);
            grafico05.SetActive(false);
            ultra.enabled = false;
        }
        else if (qualidade.value == 4)
        {
            grafico01.SetActive(false);
            grafico02.SetActive(false);
            grafico03.SetActive(false);
            grafico04.SetActive(false);
            grafico05.SetActive(true);
            ultra.enabled = false;
        }
        else if (qualidade.value == 5)
        {
            grafico01.SetActive(false);
            grafico02.SetActive(false);
            grafico03.SetActive(false);
            grafico04.SetActive(false);
            grafico05.SetActive(false);
            ultra.enabled = true;
        }
    }


    private void ptutoriais()
    {
        if (visualizando.GetComponent<visualizar>().visualizando == true && agenda.activeSelf == false)
        {
            tutorial01.gameObject.SetActive(false);
            tutorial02.gameObject.SetActive(true);
            tutorial03.gameObject.SetActive(false);
        }
        if (visualizando.GetComponent<visualizar>().visualizando == false && agenda.activeSelf == false)
        {
            tutorial01.gameObject.SetActive(true);
            tutorial02.gameObject.SetActive(false);
            tutorial03.gameObject.SetActive(false);
        }
        if (agenda.activeSelf == true)
        {
            tutorial01.gameObject.SetActive(false);
            tutorial02.gameObject.SetActive(false);
            tutorial03.gameObject.SetActive(true);
        }

    }


    /*
    public void segundaa01()
    {
        conta = 0;
        cameraa.GetComponent<AudioSource>().clip = folha;
        if (conta == 0)
        {
            cameraa.GetComponent<AudioSource>().Play();
            conta = 1;
        }

        segunda01.SetActive(true);
        terca02.SetActive(false);
        quarta03.SetActive(false);
        quinta04.SetActive(false);
        sexta05.SetActive(false);
        sabado06.SetActive(false);
        domingo07.SetActive(false);

    }

    public void tercaa02()
    {
        conta = 0;
        cameraa.GetComponent<AudioSource>().clip = folha;
        if (conta == 0)
        {
            cameraa.GetComponent<AudioSource>().Play();
            conta = 1;
        }


        segunda01.SetActive(false);
        terca02.SetActive(true);
        quarta03.SetActive(false);
        quinta04.SetActive(false);
        sexta05.SetActive(false);
        sabado06.SetActive(false);
        domingo07.SetActive(false);
    }

    public void quartaa03()
    {
        conta = 0;
        cameraa.GetComponent<AudioSource>().clip = folha;
        if (conta == 0)
        {
            cameraa.GetComponent<AudioSource>().Play();
            conta = 1;
        }



        segunda01.SetActive(false);
        terca02.SetActive(false);
        quarta03.SetActive(true);
        quinta04.SetActive(false);
        sexta05.SetActive(false);
        sabado06.SetActive(false);
        domingo07.SetActive(false);
    }

    public void quintaa04()
    {
        conta = 0;
        cameraa.GetComponent<AudioSource>().clip = folha;
        if (conta == 0)
        {
            cameraa.GetComponent<AudioSource>().Play();
            conta = 1;
        }

        segunda01.SetActive(false);
        terca02.SetActive(false);
        quarta03.SetActive(false);
        quinta04.SetActive(true);
        sexta05.SetActive(false);
        sabado06.SetActive(false);
        domingo07.SetActive(false);
    }

    public void sextaa05()
    {
        conta = 0;
        cameraa.GetComponent<AudioSource>().clip = folha;
        if (conta == 0)
        {
            cameraa.GetComponent<AudioSource>().Play();
            conta = 1;
        }



        segunda01.SetActive(false);
        terca02.SetActive(false);
        quarta03.SetActive(false);
        quinta04.SetActive(false);
        sexta05.SetActive(true);
        sabado06.SetActive(false);
        domingo07.SetActive(false);
    }

    public void sabadoo06()
    {
        conta = 0;
        cameraa.GetComponent<AudioSource>().clip = folha;
        if (conta == 0)
        {
            cameraa.GetComponent<AudioSource>().Play();
            conta = 1;
        }


        segunda01.SetActive(false);
        terca02.SetActive(false);
        quarta03.SetActive(false);
        quinta04.SetActive(false);
        sexta05.SetActive(false);
        sabado06.SetActive(true);
        domingo07.SetActive(false);
    }

    public void domingoo07()
    {
        conta = 0;
        cameraa.GetComponent<AudioSource>().clip = folha;
        if (conta == 0)
        {
            cameraa.GetComponent<AudioSource>().Play();
            conta = 1;
        }


        segunda01.SetActive(false);
        terca02.SetActive(false);
        quarta03.SetActive(false);
        quinta04.SetActive(false);
        sexta05.SetActive(false);
        sabado06.SetActive(false);
        domingo07.SetActive(true);
    }

    */
    public void mudarDiarios()
    {
        if (domingo.activeSelf == true)
        {


            if (semana01.activeSelf == true  )
            {

                conta = 0;
                cameraa.GetComponent<AudioSource>().clip = folha;
                if (conta == 0)
                {
                    cameraa.GetComponent<AudioSource>().Play();
                    conta = 1;
                }


                semana01.SetActive(false);
                semana02.SetActive(true);
            }
            
        }
        else
        {

            if (segunda.activeSelf == true)
            {
                tercaa();
            }
            else if (terca.activeSelf == true)
            {
                quartaa();
            }
            else if (quarta.activeSelf == true)
            {
                quintaa();
            }
            else if (quinta.activeSelf == true)
            {
                sextaa();
            }
            else if (sexta.activeSelf == true)
            {
                sabadoo();
            }
            else if (sabado.activeSelf == true)
            {
                domingoo();
            }

            
        }
    }


    public void mudarDiarios00()
    {
            if (segunda.activeSelf == true)
            {

            conta = 0;
            cameraa.GetComponent<AudioSource>().clip = folha;
            if (conta == 0)
            {
                cameraa.GetComponent<AudioSource>().Play();
                conta = 1;
            }

            if (semana01.activeSelf == false)
                {

                    semana01.SetActive(true);
                    semana02.SetActive(false);

                }
            }
        else
        {
            if (terca.activeSelf == true)
            {
                segundaa();
            }
            else if (quarta.activeSelf == true)
            {
                tercaa();
            }
            else if (quinta.activeSelf == true)
            {
                quartaa();
            }
            else if (sexta.activeSelf == true)
            {
                quintaa();
            }
            else if (sabado.activeSelf == true)
            {
                sextaa();
            }
            else if (domingo.activeSelf == true)
            {
                sabadoo();
            }
        }
    }

    public void mudarDiarios02()
    {
        if (domingo.activeSelf == true)
        {

            conta = 0;
            cameraa.GetComponent<AudioSource>().clip = folha;
            if (conta == 0)
            {
                cameraa.GetComponent<AudioSource>().Play();
                conta = 1;
            }

            if (semana01.activeSelf == true)
            {

                semana02.SetActive(true);
                semana01.SetActive(false);
                semana03.SetActive(false);



            }
            else if (semana02.activeSelf == true)
            {

                semana03.SetActive(true);
                semana02.SetActive(false);
                semana01.SetActive(false);

            }
        }
        else
        {
            if (segunda.activeSelf == true)
            {
                tercaa();
            }
            else if (terca.activeSelf == true)
            {
                quartaa();
            }
            else if (quarta.activeSelf == true)
            {
                quintaa();
            }
            else if (quinta.activeSelf == true)
            {
                sextaa();
            }
            else if (sexta.activeSelf == true)
            {
                sabadoo();
            }
            else if (sabado.activeSelf == true)
            {
                domingoo();
            }
        }




    }

    public void mudarDiarios03()
    {

        if (segunda.activeSelf == true)
        {

            conta = 0;
            cameraa.GetComponent<AudioSource>().clip = folha;
            if (conta == 0)
            {
                cameraa.GetComponent<AudioSource>().Play();
                conta = 1;
            }



            if (semana03.activeSelf == true)
            {
                semana03.SetActive(false);
                semana02.SetActive(true);
                semana01.SetActive(false);



            }
            else if (semana02.activeSelf == true)
            {
                semana03.SetActive(false);
                semana02.SetActive(false);
                semana01.SetActive(true);


            }
        }
        else
        {
            if (terca.activeSelf == true)
            {
                segundaa();
            }
            else if (quarta.activeSelf == true)
            {
                tercaa();
            }
            else if (quinta.activeSelf == true)
            {
                quartaa();
            }
            else if (sexta.activeSelf == true)
            {
                quintaa();
            }
            else if (sabado.activeSelf == true)
            {
                sextaa();
            }
            else if (domingo.activeSelf == true)
            {
                sabadoo();
            }
        }
    }





    /// <summary>
    /// ///////
    /// </summary>

    public void mudarDiarios04()
    {

        if (segunda.activeSelf == true)
        {

            conta = 0;
            cameraa.GetComponent<AudioSource>().clip = folha;
            if (conta == 0)
            {
                cameraa.GetComponent<AudioSource>().Play();
                conta = 1;
            }

            if (semana04.activeSelf == true)
            {
                semana04.SetActive(false);
                semana03.SetActive(true);
                semana02.SetActive(false);
                semana01.SetActive(false);



            }
            else if (semana03.activeSelf == true)
            {
                semana04.SetActive(false);
                semana03.SetActive(false);
                semana02.SetActive(true);
                semana01.SetActive(false);


            }

            else if (semana02.activeSelf == true)
            {
                semana04.SetActive(false);
                semana03.SetActive(false);
                semana02.SetActive(false);
                semana01.SetActive(true);


            }

        }
        else
        {
            if (terca.activeSelf == true)
            {
                segundaa();
            }
            else if (quarta.activeSelf == true)
            {
                tercaa();
            }
            else if (quinta.activeSelf == true)
            {
                quartaa();
            }
            else if (sexta.activeSelf == true)
            {
                quintaa();
            }
            else if (sabado.activeSelf == true)
            {
                sextaa();
            }
            else if (domingo.activeSelf == true)
            {
                sabadoo();
            }
        }
    }

    public void mudarDiarios05()
    {

        if (domingo.activeSelf == true)
        {

            conta = 0;
            cameraa.GetComponent<AudioSource>().clip = folha;
            if (conta == 0)
            {
                cameraa.GetComponent<AudioSource>().Play();
                conta = 1;
            }

            if (semana01.activeSelf == true)
            {
                semana04.SetActive(false);
                semana03.SetActive(false);
                semana02.SetActive(true);
                semana01.SetActive(false);



            }
            else if (semana02.activeSelf == true)
            {
                semana04.SetActive(false);
                semana03.SetActive(true);
                semana02.SetActive(false);
                semana01.SetActive(false);

            }

            else if (semana03.activeSelf == true)
            {
                semana04.SetActive(true);
                semana03.SetActive(false);
                semana02.SetActive(false);
                semana01.SetActive(false);



            }
        }
        else
        {


            if (segunda.activeSelf == true)
            {
                tercaa();
            }
            else if (terca.activeSelf == true)
            {
                quartaa();
            }
            else if (quarta.activeSelf == true)
            {
                quintaa();
            }
            else if (quinta.activeSelf == true)
            {
                sextaa();
            }
            else if (sexta.activeSelf == true)
            {
                sabadoo();
            }
            else if (sabado.activeSelf == true)
            {
                domingoo();
            }
        }
    }


    public void mudarDiarios06()
    {
        if(domingo.activeSelf == true)
        {

            conta = 0;
            cameraa.GetComponent<AudioSource>().clip = folha;
            if (conta == 0)
            {
                cameraa.GetComponent<AudioSource>().Play();
                conta = 1;
            }

            if (semana01.activeSelf == true)
            {
            semana04.SetActive(false);
            semana03.SetActive(false);
            semana02.SetActive(true);
            semana01.SetActive(false);
            semana05.SetActive(false);



            }
            else if (semana02.activeSelf == true)
            {
            semana04.SetActive(false);
            semana03.SetActive(true);
            semana02.SetActive(false);
            semana01.SetActive(false);
            semana05.SetActive(false);

        }

            else if (semana03.activeSelf == true)
            {
            semana04.SetActive(true);
            semana03.SetActive(false);
            semana02.SetActive(false);
            semana01.SetActive(false);
            semana05.SetActive(false);



            }

            else if (semana04.activeSelf == true)
            {
            semana04.SetActive(false);
            semana03.SetActive(false);
            semana02.SetActive(false);
            semana01.SetActive(false);
            semana05.SetActive(true);



            }
        }
        else
        {

            if(segunda.activeSelf == true)
            {
                tercaa();
            }else if(terca.activeSelf == true)
            {
                quartaa();
            }
            else if(quarta.activeSelf == true)
            {
                quintaa();
            }
            else if(quinta.activeSelf == true)
            {
                sextaa();
            }
            else if(sexta.activeSelf == true)
            {
                sabadoo();
            }
            else if(sabado.activeSelf == true)
            {
                domingoo();
            }
            


        }
    }


    public void mudarDiarios07()
    {
        if (segunda.activeSelf == true)
        {

            conta = 0;
            cameraa.GetComponent<AudioSource>().clip = folha;
            if (conta == 0)
            {
                cameraa.GetComponent<AudioSource>().Play();
                conta = 1;
            }


            if (semana05.activeSelf == true)
            {
                semana04.SetActive(true);
                semana03.SetActive(false);
                semana02.SetActive(false);
                semana01.SetActive(false);
                semana05.SetActive(false);



            }
            else if (semana04.activeSelf == true)
            {
                semana04.SetActive(false);
                semana03.SetActive(true);
                semana02.SetActive(false);
                semana01.SetActive(false);
                semana05.SetActive(false);

            }

            else if (semana03.activeSelf == true)
            {
                semana04.SetActive(false);
                semana03.SetActive(false);
                semana02.SetActive(true);
                semana01.SetActive(false);
                semana05.SetActive(false);



            }

            else if (semana02.activeSelf == true)
            {
                semana04.SetActive(false);
                semana03.SetActive(false);
                semana02.SetActive(false);
                semana01.SetActive(true);
                semana05.SetActive(false);



            }
        }
        else
        {

            
            if (terca.activeSelf == true)
            {
                segundaa();
            }
            else if (quarta.activeSelf == true)
            {
                tercaa();
            }
            else if (quinta.activeSelf == true)
            {
                quartaa();
            }
            else if (sexta.activeSelf == true)
            {
                quintaa();
            }
            else if (sabado.activeSelf == true)
            {
                sextaa();
            }
            else if(domingo.activeSelf == true)
            {
                sabadoo();
            }


        }

        


    }


}
