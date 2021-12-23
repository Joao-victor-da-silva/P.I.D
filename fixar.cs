using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fixar : MonoBehaviour
{

    public GameObject fixando, sensorr;
    Transform pai;

    // Start is called before the first frame update
    void Start()
    {
        pai = transform.parent;
        sensorr = GameObject.Find("sensor");
    }

    // Update is called once per frame
    void Update()
    {
        if(sensorr.GetComponent<visualizar>().visualizando == true)
        {
            transform.parent = pai;
        }
        if (sensorr.GetComponent<visualizar>().visualizando == false)
        {
            transform.position = fixando.transform.position;
            transform.rotation = fixando.transform.rotation;
            transform.parent = fixando.transform;
        }
    }
}
