using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class menuCapitulo : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{

    bool descricao;
    public GameObject descri, tiruli, imagem;
    public string titula, descru;
    int cont;
    [SerializeField]
    Sprite titulo;
    [SerializeField]
    data datas;
    Color liberada;
    Button meuBotao;
    ColorBlock agoraVai;
    [SerializeField]
    string novaDescricao;
    [SerializeField]
    Sprite imageCapitulo, fotografiaNatural;

    [SerializeField]
    string key, kay02;

    // Start is called before the first frame update
    void Start()
    {
        
        meuBotao = GetComponent<Button>();
        agoraVai = meuBotao.colors;
        agoraVai.normalColor = new Color(255f, 255f, 255f, 255f);
        datas = GameObject.Find("DATA").GetComponent<data>();
        cont = 0;


        if(gameObject.name == "segunda")
        {
            descru = GameMultiLang.GetTraduction(key);
        }
        novaDescricao = GameMultiLang.GetTraduction(key);
        titula = GameMultiLang.GetTraduction(kay02);
    }

    // Update is called once per frame
    void Update()
    {
        liberar();
        if (descricao == true && cont == 0)
        {
            imagem.SetActive(true);
            tiruli.GetComponent<Text>().text = titula;
            descri.GetComponent<Text>().text = descru;
            if(titulo!= null)
            {
                imagem.GetComponent<Image>().sprite = titulo;
            }
            cont = 1;
        }
        else if(descricao == false && cont == 1)
        {
            tiruli.GetComponent<Text>().text = null;
           descri.GetComponent<Text>().text = null;
            imagem.GetComponent<Image>().sprite = fotografiaNatural;
            imagem.SetActive(false);
            cont = 0;
        }
    }


    public void OnPointerEnter(PointerEventData eventData)
    {
        descricao = true;

    }

    public void OnPointerExit(PointerEventData eventData)
    {
        descricao = false;

    }

    private void liberar()
    {
        if(gameObject.name == "tersa")
        {
            if(datas.capitulo02 == true)
            {
                meuBotao.colors = agoraVai;
                descru = novaDescricao;
                titulo = imageCapitulo;
            }
        }


        if (gameObject.name == "quarta")
        {
            if (datas.capitulo03 == true)
            {
                meuBotao.colors = agoraVai;
                descru = novaDescricao;
                titulo = imageCapitulo;
            }
        }

        if (gameObject.name == "quinta")
        {
            if (datas.capitulo04 == true)
            {
                meuBotao.colors = agoraVai;
                descru = novaDescricao;
                titulo = imageCapitulo;
            }
        }

        if (gameObject.name == "sexta")
        {
            if (datas.capitulo05 == true)
            {
                meuBotao.colors = agoraVai;
                descru = novaDescricao;
                titulo = imageCapitulo;
            }
        }

    }


}
