using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class alavanca : MonoBehaviour
{
    [SerializeField]
    Animator anim;
    bool ligado;
    public bool ativado;
    [SerializeField]
    moverEstante mover;
    AudioSource audioos;

    // Start is called before the first frame update
    void Start()
    {
        ativado = false;
        audioos = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        anim.SetBool("ligado", ativado);
        if (ligado == true && Input.GetKeyDown(KeyCode.E) && mover.parar == true)
        {
            if(ativado == false)
            {
                audioos.Play();
            }
            
            ativado = true;
        }
    }


    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "sensor")
        {
            ligado = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if(other.tag== "sensor")
        {
            ligado = false;
        }
    }

}
