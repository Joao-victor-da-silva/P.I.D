using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class samantaVirando : MonoBehaviour
{
    int cont;
    [SerializeField]
    GameObject samanta;
    porta chave; 

    // Start is called before the first frame update
    void Start()
    {
        chave = GetComponent<porta>();
    }

    // Update is called once per frame
    void Update()
    {
        if(chave.chave == true && cont == 0 && chave.massanetaaa == true)
        {
            cont = 1;
            samanta.SetActive(true);
        }
    }
}
