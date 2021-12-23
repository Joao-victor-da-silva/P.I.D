using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class missao04 : MonoBehaviour
{

    [SerializeField]
    GameObject objetivos, visualizandoo;
    int cont;

    // Start is called before the first frame update
    void Start()
    {
        cont = 0;
    }

    // Update is called once per frame
    void Update()
    {
        tarefa03();
    }


    public void tarefa01()
    {
        objetivos.GetComponent<objetivos>().cont1 = 1;
    }

    public void tarefa02()
    {
        objetivos.GetComponent<objetivos>().cont2 = 1;
    }

    public void tarefa03()
    {
        if(visualizandoo.GetComponent<visualizar>().objetos != null)
        {
            if (visualizandoo.GetComponent<visualizar>().objetos.name == "documento"
           && visualizandoo.GetComponent<visualizar>().visualizando == true && cont == 0)
            {
                objetivos.GetComponent<objetivos>().cont4 = 1;
                cont = 1;
            }
        }
       
      
        
    }



}
