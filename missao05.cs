using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class missao05 : MonoBehaviour
{

    [SerializeField]
    GameObject tarefas, visu;

    int cont, cont2;

    public bool positivo01, positivo02;

    public bool[] deu;

    void Start()
    {
        deu = new bool[6];
    }

    // Update is called once per frame
    void Update()
    {
        if (positivo01 == true && positivo02 == true && cont == 0)
        {
            tafera03();
            cont = 1;
        }

        if(visu.GetComponent<visualizar>().tomou08 && cont2 == 0)
        {
            cont2 = 1;
            tafera02();
        }


        if(tarefas.GetComponent<objetivos>().cont1 == 1)
        {
            deu[0] = true;
        }
        if (tarefas.GetComponent<objetivos>().cont2 == 1)
        {
            deu[1] = true;
        }
        if (tarefas.GetComponent<objetivos>().cont3 == 1)
        {
            deu[2] = true;
        }
        if (tarefas.GetComponent<objetivos>().cont07 == 1)
        {
            deu[3] = true;
        }
        if (tarefas.GetComponent<objetivos>().cont08 == 1)
        {
            deu[4] = true;
        }
        if (tarefas.GetComponent<objetivos>().cont09 == 1)
        {
            deu[5] = true;
        }


    }

    public void tafera01()
    {
        tarefas.GetComponent<objetivos>().cont1 = 1;
    }

    public void tafera03()
    {
        tarefas.GetComponent<objetivos>().cont3 = 1;
    }

    public void tafera02()
    {
        tarefas.GetComponent<objetivos>().cont2 = 1;
    }

    public void tarefa04()
    {
        tarefas.GetComponent<objetivos>().cont4 = 1;
    }

    public void tarefa05()
    {
        tarefas.GetComponent<objetivos>().cont5 = 1;
    }


}
