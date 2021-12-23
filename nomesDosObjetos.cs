using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class nomesDosObjetos : MonoBehaviour
{

    public string nomeObjeto, traducaoObjeto;

    // Start is called before the first frame update
    void Start()
    {
        nomeObjeto = GameMultiLang.GetTraduction(traducaoObjeto);
    }

    
}
