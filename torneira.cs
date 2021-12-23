using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class torneira : MonoBehaviour
{
    [SerializeField]
    Transform agua;
    ParticleSystem aguaLigada;
    bool usar;
    ParticleSystem.EmissionModule em;
    int cont;

    // Start is called before the first frame update
    void Start()
    {
        agua = transform.Find("agua");
        aguaLigada = agua.GetComponent<ParticleSystem>();
       
    }

    // Update is called once per frame
    void Update()
    {
        
        if(usar == true && Input.GetKeyDown(KeyCode.E) && cont == 0)
        {
            aguaLigada.Play();
            // em.enabled = true;
            GetComponent<AudioSource>().Play();
            cont = 1;
        }
        else if(usar == true && Input.GetKeyDown(KeyCode.E) && cont == 1)
        {
            aguaLigada.Stop();
            // em.enabled = false;
            GetComponent<AudioSource>().Stop();
            cont = 0;
        }

    }


    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "sensor")
        {
            usar = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if( other.tag == "sensor")
        {
            usar = false;
        }
    }

}
