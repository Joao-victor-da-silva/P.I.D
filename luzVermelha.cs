using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class luzVermelha : MonoBehaviour
{

    Color red, normal;

    Transform luzinha;

    Light luzinhaa;

    GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("FPSController");
        luzinha = transform.Find("Point Light");

        red.g = 0;
        red.b = 0;
        red.a = 255;
        red.r = 255;

        luzinhaa = luzinha.GetComponent<Light>();

        normal.a = luzinhaa.color.a;
        normal.r = luzinhaa.color.r;
        normal.g = luzinhaa.color.g;
        normal.b = luzinhaa.color.b;

    }

    // Update is called once per frame
    void Update()
    {
        vermelho();
    }


    private void vermelho()
    {
        if (player.GetComponent<acabouTempo>().acabou == true && player.GetComponent<acabouTempo>().voltou == false)
        {
            luzinhaa.color = red;
            //luzinha.range = 4;
            luzinhaa.intensity = 0.01f;
        }

        if (player.GetComponent<acabouTempo>().voltou == true)
        {
            luzinhaa.color = normal;
            //luzinha.range = 10;
            luzinhaa.intensity = 1f;
        }


    }


}
