using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class inventarioDescricao : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{

    public string titulo, descricao;
    public GameObject cursorr, titulos, descricaous, imagems;
    bool tirulo;
    int cont,cont02;
    public int id;
    public Sprite doOBjeto;

    [SerializeField]
    string oi;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if (cont02 == 0 && GetComponent<Text>().text != null)
        {
            cont02 = 1;
            oi = GetComponent<Text>().text;
            if(oi != null)
            {
                GetComponent<Text>().text = GameMultiLang.GetTraduction(oi);
            }
            
        }
        

        
        
    }


    public void OnPointerEnter(PointerEventData eventData)
    {

        tirulo = true;

        if (id != 0)
        {
            if (tirulo == true)
            {
                cont = 0;
                cursorr.SetActive(true);
                titulos.GetComponent<Text>().text = titulo;
                descricaous.GetComponent<Text>().text = descricao;
                if (doOBjeto != null)
                {
                    imagems.GetComponent<Image>().sprite = doOBjeto;
                }

            }
            else if (tirulo == false)
            {
                if (cont == 0)
                {
                    cursorr.SetActive(false);
                    titulos.GetComponent<Text>().text = null;
                    descricaous.GetComponent<Text>().text = null;
                    imagems.GetComponent<Image>().sprite = null;
                    cont = 1;
                }
            }
        }

    }

    public void OnPointerExit(PointerEventData eventData)
    {

        tirulo = false;

        if (id != 0)
        {
            if (tirulo == true)
            {
                cont = 0;
                cursorr.SetActive(true);
                titulos.GetComponent<Text>().text = titulo;
                descricaous.GetComponent<Text>().text = descricao;
                if (doOBjeto != null)
                {
                    imagems.GetComponent<Image>().sprite = doOBjeto;
                }

            }
            else if (tirulo == false)
            {
                if (cont == 0)
                {
                    cursorr.SetActive(false);
                    titulos.GetComponent<Text>().text = null;
                    descricaous.GetComponent<Text>().text = null;
                    imagems.GetComponent<Image>().sprite = null;
                    cont = 1;
                }
            }
        }
    }

}
