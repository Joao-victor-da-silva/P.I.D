using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class notificar : MonoBehaviour
{
    [SerializeField]
    escurecer escul;

    [SerializeField]
    Text[] tarefas;

    int cont, cont02;

    
    objetivos obj;

    // Start is called before the first frame update
    void Start()
    {
        obj = GetComponent<objetivos>();
    }

    // Update is called once per frame
    void Update()
    {
        if (escul.cenaAtual == "semana02" && cont == 0)
        {
            

            if (obj.cont1 != 0)
            {
                cont = 1;
                StartCoroutine(trocando());
                print("deuCraaai");
                tarefas[0].enabled = true;
                tarefas[1].enabled = true;
                tarefas[2].enabled = true;
            }
        }

        if (escul.cenaAtual == "semana05" && cont == 0)
        {

            if (obj.cont2 != 0)
            {
                cont = 1;
                StartCoroutine(trocando());
                print("deuCraaai");
                tarefas[0].enabled = true;
                tarefas[1].enabled = true;
            
            }


        }

        if (escul.cenaAtual == "semana04" && cont == 0 || escul.cenaAtual == "semana04" && cont02 == 0)
        {

            if (obj.cont1 != 0 && cont == 0)
            {
                cont = 1;
                StartCoroutine(trocando());
                print("deuCraaai");
                tarefas[0].enabled = true;

            }

            if (obj.cont2 != 0 && cont02 == 0)
            {
                cont02 = 1;
                StartCoroutine(trocando());
                print("deuCraaai");
                tarefas[1].enabled = true;

            }


        }



        if (escul.cenaAtual == "semana03" && cont == 0 || escul.cenaAtual == "semana03" && cont02 == 0)
        {

            if (obj.cont1 != 0 && cont == 0)
            {
                cont = 1;
                StartCoroutine(trocando());
                print("deuCraaai");
                tarefas[0].enabled = true;
                tarefas[2].enabled = true;

            }

            if (obj.cont3 != 0 && cont02 == 0)
            {
                cont02 = 1;
                StartCoroutine(trocando());
                print("deuCraaai");
                tarefas[1].enabled = true;

            }


        }

    }


    IEnumerator trocando()
    {
        yield return new WaitForSeconds(3f);
        obj.notificacaoMestres.GetComponent<notificacaoMestre>().notificar = true;
    }

}
