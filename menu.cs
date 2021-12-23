using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class menu : MonoBehaviour
{
    public Text[] textoerror;

    // declarando variaveis
    public GameObject menuInicial, menuPrincipal, menuOpcoes, menuCreditos, menuJogar, botao, label;
    public Dropdown resolucao, qualidade;
    public Slider audios;
    int parar = 0, cont;
    [SerializeField]
    data datas;
    [SerializeField]
    GameObject datass, nossaData, ponto, datasss;
    [SerializeField]
    GameObject abertura;


    [SerializeField]
    Sprite[] pids;
    [SerializeField]
    Image pid;
    [SerializeField]
    bool DEMO;

    private void Start()

    {
        textoerror[0].text = PlayerPrefs.GetString("errorBalancoCamera");
        textoerror[1].text = PlayerPrefs.GetString("errorCorrigirColicaoFixedUpdate");
        textoerror[2].text = PlayerPrefs.GetString("errorCorrigirColicao");


        qualidade.options[0].text = GameMultiLang.GetTraduction("Muito Baixo");
        qualidade.options[1].text = GameMultiLang.GetTraduction("Baixo");
        qualidade.options[2].text = GameMultiLang.GetTraduction("Medio");
        qualidade.options[3].text = GameMultiLang.GetTraduction("Alto");
        qualidade.options[4].text = GameMultiLang.GetTraduction("Muito Alto");
        qualidade.options[5].text = GameMultiLang.GetTraduction("Ultra");




        StartCoroutine(iniciar());
        datass = GameObject.Find("DATA");
        if(datass == null)
        {
            Instantiate(nossaData, ponto.transform);
            
        }
        
        if (Screen.fullScreen == true)
        {
            botao.GetComponent<Toggle>().isOn = true;
        }
        if (Screen.fullScreen == false)
        {
            botao.GetComponent<Toggle>().isOn = false;
        }

        
        

        Cursor.lockState = CursorLockMode.None;
        puxarResolucao();
        //resolucao.value = Screen.resolutions.Length;


        /////
        
        ///////



       // Screen.SetResolution(Screen.currentResolution.width,Screen.currentResolution.height, Screen.fullScreen);

        
        //resolucao.value = Screen.resolutions.Rank;
        audios.value = AudioListener.volume;
        Time.timeScale = 1;
        //qualidade.value = 5;
        qualidade.value = QualitySettings.GetQualityLevel();
        Cursor.visible = true;
        // teclaCheia();
        // Grafico();
        // qualidadeInicial();
        // volume();
        datasss = GameObject.Find("DATA(Clone)");
        if(datasss!= null)
        {
            datasss.name = "DATA";
        }
       
        datas = GameObject.Find("DATA").GetComponent<data>();
        datas.GetComponent<data>().DEMO = DEMO;
        if (datas.novaCena == true)
        {
            menuInicial.SetActive(false);
            menuJogar.SetActive(true);
            textoerror[0].gameObject.SetActive(false);
            textoerror[1].gameObject.SetActive(false);
            textoerror[2].gameObject.SetActive(false);
        }

        

    }

    private void Update()
    {

        trocarPid();


        label.GetComponent<Text>().text = "" + Screen.currentResolution;
        // print(Screen.currentResolution);

        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
        if (Input.anyKey && parar == 0 && menuInicial.activeSelf == true)
        {
            parar = 1;
            menuPrincipal.SetActive(true);
            menuInicial.SetActive(false);
            textoerror[0].gameObject.SetActive(false);
            textoerror[1].gameObject.SetActive(false);
            textoerror[2].gameObject.SetActive(false);
        }
    }

    public void opcoes()
    {
        menuPrincipal.SetActive(false);
        menuOpcoes.SetActive(true);
    }
    public void SairOpcoes()
    {
        menuPrincipal.SetActive(true);
        menuOpcoes.SetActive(false);
    }
    public void creditos()
    {
        menuPrincipal.SetActive(false);
        menuCreditos.SetActive(true);
    }
    public void sairCreditos()
    {
        menuPrincipal.SetActive(true);
        menuCreditos.SetActive(false);
    }
    public void jogar()
    {
        menuPrincipal.SetActive(false);
        menuJogar.SetActive(true);
    }
    public void sairJogar()
    {
        menuPrincipal.SetActive(true);
        menuJogar.SetActive(false);
    }
    public void sair()
    {
        Application.Quit();
    }


    //Configuração do menu opitions


    public void teclaCheia()
    {

        

        if (botao.GetComponent<Toggle>().isOn == false)
        {
            Screen.fullScreen = false;
        }
        if (botao.GetComponent<Toggle>().isOn == true) 
        {
            Screen.fullScreen = true;
        }
       

    }
    public void puxarResolucao()
    {
        Resolution[] todasResolucoes = Screen.resolutions;
        resolucao.options.Clear();
        for (int y = 0; y < todasResolucoes.Length; y++)
            resolucao.options.Add(new Dropdown.OptionData()
            {
                text = todasResolucoes[y].width + "x" + todasResolucoes[y].height + " @ " + todasResolucoes[y].refreshRate + "Hz"
            });


       
        
        //print(todasResolucoes);
    }

    public void setarResolucao()
    {
        Resolution[] todasResolucoes = Screen.resolutions;
        resolucao.options.Clear();
        for (int y = 0; y < todasResolucoes.Length; y++)
            resolucao.options.Add(new Dropdown.OptionData()
            {
                text = todasResolucoes[y].width + "x" + todasResolucoes[y].height + " @ " + todasResolucoes[y].refreshRate + "Hz"
            });
        Screen.SetResolution(todasResolucoes[resolucao.value].width, todasResolucoes[resolucao.value].height, Screen.fullScreen);
    }

    public void Resolucao()
    {

    }
    public void Grafico()
    {

        QualitySettings.SetQualityLevel(qualidade.value);

    }
    public void antialiasing()
    {

        

    }
    public void vSync()
    {



    }
    public void volume()
    {
       
        AudioListener.volume = audios.value;

    }
    private void qualidadeInicial()
    {
        qualidade.value = QualitySettings.GetQualityLevel();
       
    }


    //configurando menu jogar

    public void comecarJogo()
    {
        if(DEMO == false)
        {
            SceneManager.LoadScene("load");
        }
        else if(DEMO == true)
        {
            SceneManager.LoadScene("loadDemo");
        } 
        
    }
    public void sema02()
    {
        if(datas.capitulo02 == true)
        {
            SceneManager.LoadScene("load02");
        }
        
    }
    public void sema03()
    {
        if (datas.capitulo03 == true)
        {
            SceneManager.LoadScene("load03");
        }

    }

    public void sema04()
    {
        if (datas.capitulo04 == true)
        {
            SceneManager.LoadScene("load04");
        }

    }

    public void sema05()
    {
        if (datas.capitulo05 == true)
        {
            SceneManager.LoadScene("load05");
        }

    }


    private IEnumerator iniciar()
    {
        yield return new WaitForSeconds(2f);
        Destroy(abertura);
    }


    private void trocarPid()
    {
        if(datas.GetComponent<data>().capitulo02 == false && datas.GetComponent<data>().capitulo03 == false &&
            datas.GetComponent<data>().capitulo04 == false && datas.GetComponent<data>().capitulo05 == false && datas.GetComponent<data>().capitulo06 == false)
        {
            pid.sprite = pids[0];
        }

        if (datas.GetComponent<data>().capitulo02 == true && datas.GetComponent<data>().capitulo03 == false &&
    datas.GetComponent<data>().capitulo04 == false && datas.GetComponent<data>().capitulo05 == false && datas.GetComponent<data>().capitulo06 == false)
        {
            pid.sprite = pids[1];
        }

        if (datas.GetComponent<data>().capitulo02 == true && datas.GetComponent<data>().capitulo03 == true &&
    datas.GetComponent<data>().capitulo04 == false && datas.GetComponent<data>().capitulo05 == false && datas.GetComponent<data>().capitulo06 == false)
        {
            pid.sprite = pids[2];
        }
    if(datas.GetComponent<data>().capitulo02 == true && datas.GetComponent<data>().capitulo03 == true &&
            datas.GetComponent<data>().capitulo04 == true && datas.GetComponent<data>().capitulo05 == false && datas.GetComponent<data>().capitulo06 == false)
        {
            pid.sprite = pids[3];
        }

        if (datas.GetComponent<data>().capitulo02 == true && datas.GetComponent<data>().capitulo03 == true &&
datas.GetComponent<data>().capitulo04 == true && datas.GetComponent<data>().capitulo05 == true && datas.GetComponent<data>().capitulo06 == false)
        {
            pid.sprite = pids[4];
        }
        if(datas.GetComponent<data>().capitulo06 == true)
        {
            pid.sprite = pids[5];
        }
    }

}
