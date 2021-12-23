using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class tutorial : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{

    public GameObject painel01, painel02, painel03, painel04;

    bool troca;
    public int troca02;

    // Start is called before the first frame update
    void Start()
    {
        troca02 = 0;
        StartCoroutine(automatico());
    }

    // Update is called once per frame
    void Update()
    {
        if(troca02 == 0)
        {
            painel01.SetActive(true);
            painel02.SetActive(false);
            painel03.SetActive(false);
            painel04.SetActive(false);
        }
        if (troca02 == 1)
        {
            painel01.SetActive(false);
            painel02.SetActive(true);
            painel03.SetActive(false);
            painel04.SetActive(false);
        }
        if (troca02 == 2)
        {
            painel01.SetActive(false);
            painel02.SetActive(false);
            painel03.SetActive(true);
            painel04.SetActive(false);
        }
        if (troca02 == 3)
        {
            painel01.SetActive(false);
            painel02.SetActive(false);
            painel03.SetActive(false);
            painel04.SetActive(true);
        }

        if (troca02 == 4)
        {
            troca02 = 0;
        }
        if(troca02 < 0)
        {
            troca02 = 3;
        }


        if (Input.GetKeyDown(KeyCode.Mouse0) && troca == true)
        {
            trocarr();
        }


    }


    public void OnPointerEnter(PointerEventData eventData)
    {
        troca = true;

    }

    public void OnPointerExit(PointerEventData eventData)
    {
        troca = false;

    }

    public void trocarr()
    {
        troca02++;
    }

    public void automaricoo()
    {
        troca02++;
        StartCoroutine(automatico());
    }


    IEnumerator automatico()
    {
        yield return new WaitForSeconds(10f);
        automaricoo();
    }


}
