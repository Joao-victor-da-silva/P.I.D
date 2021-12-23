using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class livro : MonoBehaviour
{

    int pag, verificar;

    [SerializeField]
    Text texto;

    [SerializeField]
    GameObject livros, textos, chave, player;

    [SerializeField]
    MeshRenderer livross;

    [SerializeField]
    objeto objetos;

    // Start is called before the first frame update
    void Start()
    {
        textos.SetActive(false);
        pag = 1;
    }

    // Update is called once per frame
    void Update()
    {
        texto.text = "" + pag;
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            sair();
        }
    }


    public  void soma()
    {
        if(pag < 100)
        {
            pag++;
        }

        if (verificar != pag)
        {
            textos.SetActive(false);
        }

    }

    public void diminuir()
    {
        if(pag > 1)
        {
            pag--;
        }

        if (verificar != pag)
        {
            textos.SetActive(false);
        }

    }


    private void OnTriggerStay(Collider other)
    {
        if(other.tag == "sensor")
        {
            if(Input.GetKeyDown(KeyCode.E))
            {
                livros.SetActive(true);
                Time.timeScale = 0;
                Cursor.visible = true;
                Cursor.lockState = CursorLockMode.None;
            }
        }
    }


    public void sair()
    {
        livros.SetActive(false);
        Time.timeScale = 1;
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }

    public void confirmar()
    {
        if (pag == 59)
        {
            //livross.enabled = true;
            //objetos.enabled = true;
            livros.SetActive(false);
            chave.transform.position = transform.position;
            player.GetComponent<sensor>().colidiu = false;
            Time.timeScale = 1;
            Cursor.visible = false;
            Cursor.lockState = CursorLockMode.Locked;
            player.GetComponent<sensor>().colidiu = false;
            if (player.GetComponent<sensor>().colidiu == false)
            {
                Destroy(this.gameObject);
            }
            
        }
        else
        {
            contar();
        }
    }


    private void contar()
    {
        verificar = pag;
        if(verificar == pag)
        {
            textos.SetActive(true);
        }
    }


}
