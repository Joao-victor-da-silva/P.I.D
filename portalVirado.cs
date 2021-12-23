using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class portalVirado : MonoBehaviour
{

    porta portao;

    public bool virando;


    // Start is called before the first frame update
    void Start()
    {
        portao = transform.Find("porta").GetComponent<porta>();
    }

    // Update is called once per frame
    void Update()
    {


        if (transform.rotation.y == 0)
        {

            virando = true;

        }
        else if(transform.rotation.y > 0)
        {

            virando = false;


        }


        portao.virou = virando;


        }
}
