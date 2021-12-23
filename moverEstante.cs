using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moverEstante : MonoBehaviour
{

    bool liberado;
    public bool parar, parado;
    AudioSource estantemovimento;

    // Start is called before the first frame update
    void Start()
    {
        liberado = false;
        parar = false;
        estantemovimento = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if(liberado == true && Input.GetKey(KeyCode.E) && transform.position.x > -8f)
        {
            
            transform.Translate(0, 0.5f * Time.deltaTime, 0);
            if(parado == true)
            {
                parado = false;
                estantemovimento.Play();
            }

        }


        if(liberado == false || Input.GetKeyUp(KeyCode.E))
        {
            estantemovimento.Stop();
            parado = true;
        }

        if(transform.position.x <= -8f)
        {
            parar = true;
        }
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "sensor")
        {
            liberado = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if(other.tag == "sensor")
        {
            liberado = false;
        }
    }




}
// z -6.25
// x -9.60