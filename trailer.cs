using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class trailer : MonoBehaviour
{

    public bool ativado;

    public Image[] imagem;
    public Text[] textos;
    int numero, numero02, cont, cont02;  

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.K) && ativado == false)
        {
            ativado = true;
        }
        else if(Input.GetKeyDown(KeyCode.K) && ativado == true)
        {
            ativado = false;
        }

        if(ativado == true && cont == 0)
        {
            
            cont02 = 0;
            //numero = 0;
            //numero02 = 0;
            if (imagem[numero] != null)
            {
                    imagem[numero].enabled = false;
                    numero++;
                    print(imagem[numero].gameObject.name + " imagem");
            }
            else if(imagem[numero] == null)
            {
                numero = 0;
            }
            if (textos[numero02] != null)
            {
                    textos[numero02].enabled = false;
                    numero02++;
                print(textos[numero02].gameObject.name + " textos");
            }
            else if(textos[numero02] == null)
            {
                numero02 = 0;
            }
            if(textos[numero02] == null && imagem[numero] == null)
            {
                cont = 1;
            }
           
        }
        if(ativado == false && cont02 == 0)
        {
            
            cont = 0;
            //numero = 0;
            //numero02 = 0;
            if (imagem[numero] != null)
            {
                imagem[numero].enabled = true;
                numero++;
                print(imagem[numero].gameObject.name + " imagem");
            }
            else if (imagem[numero] == null)
            {
                numero = 0;
            }
            if (textos[numero02] != null)
            {
                textos[numero02].enabled = true;
                numero02++;
                print(textos[numero02].gameObject.name + " textos");
            }
            else if (textos[numero02] == null)
            {
                numero02 = 0;
            }
            if(textos[numero02] == null && imagem[numero] == null)
            {
                cont02 = 1;
            }
        }

    }
}
