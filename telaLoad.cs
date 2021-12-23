using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class telaLoad : MonoBehaviour
{
    AsyncOperation carregamento;

    public GameObject texto01, texto02;

    public string cenaACarregar;
   
    
    private bool mostrarCarregamento = false;
    [SerializeField]
    private int progresso = 0;

    bool trocar;


    void Start()
    {
        trocar = false;
        StartCoroutine(CenaDeCarregamento(cenaACarregar));
        //testes(cenaACarregar);
    }

    void Update()
    {

       if(progresso == 89)
        {
            texto01.SetActive(false);
            texto02.SetActive(true);
        }

        if (Input.GetKeyDown(KeyCode.Space) && progresso == 89)
        {
            carregamento.allowSceneActivation = true;
        }
       
    }

    IEnumerator CenaDeCarregamento(string cena)
    {
        mostrarCarregamento = true;
            
        carregamento = SceneManager.LoadSceneAsync(cena);
        carregamento.allowSceneActivation = false;



        while (!carregamento.isDone)
        {
            progresso = (int)(carregamento.progress * 100);

            yield return null;
        }
    }


    private void testes(string cena)
    {

        mostrarCarregamento = true;

        carregamento = SceneManager.LoadSceneAsync(cena);
        carregamento.allowSceneActivation = false;

        progresso = (int)(carregamento.progress * 100);


    }






















        /*
        public string carregarCena;
        public float tempofixo = 5f;
        public enum tipoCarregar { carregamento,tempofixo};
        public tipoCarregar tipoCarregamento;
        public Image barraCarregamento;
        public Text textoCarregamento;
        private int progresso = 0;
        private string textoOriginal;


        // Start is called before the first frame update
        void Start()
        {
            if(SceneManager.GetActiveScene().name == "load")
            {


            switch (tipoCarregamento)
            {
                case tipoCarregar.carregamento:
                    StartCoroutine(CenaDeCarregamento(carregarCena));
                    break;
                case tipoCarregar.tempofixo:
                    StartCoroutine(TempoFixo(carregarCena));
                    break;
            }
            if(textoCarregamento != null)
            {
                textoOriginal = textoCarregamento.text;
            }
            if (barraCarregamento != null)
            {
                barraCarregamento.type = Image.Type.Filled;
                barraCarregamento.fillMethod = Image.FillMethod.Horizontal;
                barraCarregamento.fillOrigin = (int)Image.OriginHorizontal.Left;
            }
            }
        }
        IEnumerator CenaDeCarregamento(string cena)
        {
            if (SceneManager.GetActiveScene().name == "load")
            {
                AsyncOperation carregamento = SceneManager.LoadSceneAsync(cena);
                while (!carregamento.isDone)
                {
                    progresso = (int)(carregamento.progress * 100.0f);
                    yield return null;
                }
            }
        }
        IEnumerator TempoFixo(string cena)
        {
            if (SceneManager.GetActiveScene().name == "load")
            {
                yield return new WaitForSeconds(tempofixo);
                SceneManager.LoadScene(cena);
            }
        }

        // Update is called once per frame
        void Update()
        {
            if (SceneManager.GetActiveScene().name == "load")
            {

                switch (tipoCarregamento)
                {
                    case tipoCarregar.carregamento:
                        break;
                    case tipoCarregar.tempofixo:
                        progresso = (int)(Mathf.Clamp((Time.time / tempofixo), 0.0f, 1.0f) * 100.0f);
                        break;
                }
                if (textoCarregamento != null)
                {
                    textoCarregamento.text = textoOriginal + " " + progresso + "%";
                }
                if (barraCarregamento != null)
                {
                    barraCarregamento.fillAmount = (progresso / 100.0f);
                }
            }
        }
        */
    }
