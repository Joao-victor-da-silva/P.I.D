using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class brinquedo : MonoBehaviour
{
    [SerializeField]
    Transform[] cubos, pontos;
    bool[] colocado;
    bool pousol, liberado;
    [SerializeField]
    GameObject painel;

    int[] letras;

    [SerializeField]
    Text[] texto;


    [SerializeField]
    Animator caveta;

    [SerializeField]
    Text textoBrinquedo;
    int l1, l2, l3, l4, l5, quantidade;

    [SerializeField]
    Color verde;

    int cont;
    // Start is called before the first frame update
    void Start()
    {
        textoBrinquedo.enabled = false;
        letras = new int[5];
        letras[0] = 1;
        letras[1] = 1;
        letras[2] = 1;
        letras[3] = 1;
        letras[4] = 1;
        cubos = new Transform[5];
        pontos = new Transform[5];
        colocado = new bool[5];
        cubos[0] = transform.Find("Cubo Letra 01");
        cubos[1] = transform.Find("Cubo Letra 02");
        cubos[2] = transform.Find("Cubo Letra 03");
        cubos[3] = transform.Find("Cubo Letra 04");
        cubos[4] = transform.Find("Cubo Letra 05");
        pontos[0] = transform.Find("Cubo Letra 01 (1)");
        pontos[1] = transform.Find("Cubo Letra 02 (1)");
        pontos[2] = transform.Find("Cubo Letra 03 (1)");
        pontos[3] = transform.Find("Cubo Letra 04 (1)");
        pontos[4] = transform.Find("Cubo Letra 05 (1)");

    }

    // Update is called once per frame
    void Update()
    {
        colocar();
        quebraCabeca();
        regiistraraLetra();
    }

    private void colocar()
    {
        if(colocado[0] == true)
        {
            cubos[0].transform.position = pontos[0].transform.position;
            cubos[0].transform.rotation = pontos[0].transform.rotation;
            cubos[0].GetComponent<objeto>().enabled = false;
            cubos[0].GetComponent<BoxCollider>().enabled = false;
            cubos[0].GetComponent<Rigidbody>().isKinematic = true;
            cubos[0].tag = "Untagged";
            if (l1 == 0)
            {
                l1 = 1;
                textoBrinquedo.enabled = true;
                quantidade++;
                textoBrinquedo.text = quantidade + "/5";
            }
        }
        if (colocado[1] == true)
        {
            cubos[1].transform.position = pontos[1].transform.position;
            cubos[1].transform.rotation = pontos[1].transform.rotation;
            cubos[1].GetComponent<objeto>().enabled = false;
            cubos[1].GetComponent<BoxCollider>().enabled = false;
            cubos[1].GetComponent<Rigidbody>().isKinematic = true;
            cubos[1].tag = "Untagged";
            if (l2 == 0)
            {
                l2 = 1;
                textoBrinquedo.enabled = true;
                quantidade++;
                textoBrinquedo.text = quantidade + "/5";
            }
        }
        if (colocado[2] == true)
        {
            cubos[2].transform.position = pontos[2].transform.position;
            cubos[2].transform.rotation = pontos[2].transform.rotation;
            cubos[2].GetComponent<objeto>().enabled = false;
            cubos[2].GetComponent<BoxCollider>().enabled = false;
            cubos[2].GetComponent<Rigidbody>().isKinematic = true;
            cubos[2].tag = "Untagged";
            if (l3 == 0)
            {
                l3 = 1;
                textoBrinquedo.enabled = true;
                quantidade++;
                textoBrinquedo.text = quantidade + "/5";
            }
        }
        if (colocado[3] == true)
        {
            cubos[3].transform.position = pontos[3].transform.position;
            cubos[3].transform.rotation = pontos[3].transform.rotation;
            cubos[3].GetComponent<objeto>().enabled = false;
            cubos[3].GetComponent<BoxCollider>().enabled = false;
            cubos[3].GetComponent<Rigidbody>().isKinematic = true;
            cubos[3].tag = "Untagged";
            if (l4 == 0)
            {
                l4 = 1;
                textoBrinquedo.enabled = true;
                quantidade++;
                textoBrinquedo.text = quantidade + "/5";
            }
        }
        if (colocado[4] == true)
        {
            cubos[4].transform.position = pontos[4].transform.position;
            cubos[4].transform.rotation = pontos[4].transform.rotation;
            cubos[4].GetComponent<objeto>().enabled = false;
            cubos[4].GetComponent<BoxCollider>().enabled = false;
            cubos[4].GetComponent<Rigidbody>().isKinematic = true;
            cubos[4].tag = "Untagged";
            if (l5 == 0)
            {
                l5 = 1;
                textoBrinquedo.enabled = true;
                quantidade++;
                textoBrinquedo.text = quantidade + "/5";
            }
        }

    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject == cubos[0].gameObject)
        {
            colocado[0] = true;
        }
        if (other.gameObject == cubos[1].gameObject)
        {
            colocado[1] = true;
        }
        if (other.gameObject == cubos[2].gameObject)
        {
            colocado[2] = true;
        }
        if (other.gameObject == cubos[3].gameObject)
        {
            colocado[3] = true;
        }
        if (other.gameObject == cubos[4].gameObject)
        {
            colocado[4] = true;
        }



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

    private void quebraCabeca()
    {
        if(colocado[0] == true && colocado[1] == true && colocado[2] == true && colocado[3] == true && colocado[4] == true)
        {
            pousol = true;
            textoBrinquedo.color = verde;
        }

        if(pousol == true && liberado == true && cont == 0)
        {

            gameObject.tag = "interagir";

            if (Input.GetKeyDown(KeyCode.Escape))
            {
                sair();
            }


            if (Input.GetKeyDown(KeyCode.E))
            {
                if(painel.activeSelf == false)
                {
                    painel.SetActive(true);
                    Cursor.visible = true;
                    Cursor.lockState = CursorLockMode.None;
                    Time.timeScale = 0;
                }
                else if(painel.activeSelf == true )
                {
                    sair();
                }
               

            }

        }


    }


    public void sair()
    {
        painel.SetActive(false);
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
        Time.timeScale = 1;
    }


    public void letraSoma01()
    {
        if(letras[0] < 26)
        {
            letras[0]++;
        }
        
    }

    public void letraDiminuir01()
    {
        if (letras[0] > 0)
        {
            letras[0]--;
        }
    }

    public void letraSoma02()
    {
        if (letras[1] < 26)
        {
            letras[1]++;
        }

    }

    public void letraDiminuir02()
    {
        if (letras[1] > 0)
        {
            letras[1]--;
        }
    }

    public void letraSoma03()
    {
        if (letras[2] < 26)
        {
            letras[2]++;
        }

    }

    public void letraDiminuir03()
    {
        if (letras[2] > 0)
        {
            letras[2]--;
        }
    }

    public void letraSoma04()
    {
        if (letras[3] < 26)
        {
            letras[3]++;
        }

    }

    public void letraDiminuir04()
    {
        if (letras[3] > 0)
        {
            letras[3]--;
        }
    }

    public void letraSoma05()
    {
        if (letras[4] < 26)
        {
            letras[4]++;
        }

    }

    public void letraDiminuir05()
    {
        if (letras[4] > 0)
        {
            letras[4]--;
        }
    }


    private void regiistraraLetra()
    {
       if(letras[0] == 1)
        {
            texto[0].text = "A";
        }
        if (letras[0] == 2)
        {
            texto[0].text = "B";
        }
        if (letras[0] == 3)
        {
            texto[0].text = "C";
        }
        if (letras[0] == 4)
        {
            texto[0].text = "D";
        }
        if (letras[0] == 5)
        {
            texto[0].text = "E";
        }
        if (letras[0] == 6)
        {
            texto[0].text = "F";
        }
        if (letras[0] == 7)
        {
            texto[0].text = "G";
        }
        if (letras[0] == 8)
        {
            texto[0].text = "H";
        }
        if (letras[0] == 9)
        {
            texto[0].text = "I";
        }
        if (letras[0] == 10)
        {
            texto[0].text = "J";
        }
        if (letras[0] == 11)
        {
            texto[0].text = "K";
        }
        if (letras[0] == 12)
        {
            texto[0].text = "L";
        }
        if (letras[0] == 13)
        {
            texto[0].text = "M";
        }
        if (letras[0] == 14)
        {
            texto[0].text = "N";
        }
        if (letras[0] == 15)
        {
            texto[0].text = "O";
        }
        if (letras[0] == 16)
        {
            texto[0].text = "P";
        }
        if (letras[0] == 17)
        {
            texto[0].text = "Q";
        }
        if (letras[0] == 18)
        {
            texto[0].text = "R";
        }
        if (letras[0] == 19)
        {
            texto[0].text = "S";
        }
        if (letras[0] == 20)
        {
            texto[0].text = "T";
        }
        if (letras[0] == 21)
        {
            texto[0].text = "U";
        }
        if (letras[0] == 22)
        {
            texto[0].text = "W";
        }
        if (letras[0] == 23)
        {
            texto[0].text = "X";
        }
        if (letras[0] == 24)
        {
            texto[0].text = "Y";
        }
        if (letras[0] == 25)
        {
            texto[0].text = "Z";
        }












        if (letras[1] == 1)
        {
            texto[1].text = "A";
        }
        if (letras[1] == 2)
        {
            texto[1].text = "B";
        }
        if (letras[1] == 3)
        {
            texto[1].text = "C";
        }
        if (letras[1] == 4)
        {
            texto[1].text = "D";
        }
        if (letras[1] == 5)
        {
            texto[1].text = "E";
        }
        if (letras[1] == 6)
        {
            texto[1].text = "F";
        }
        if (letras[1] == 7)
        {
            texto[1].text = "G";
        }
        if (letras[1] == 8)
        {
            texto[1].text = "H";
        }
        if (letras[1] == 9)
        {
            texto[1].text = "I";
        }
        if (letras[1] == 10)
        {
            texto[1].text = "J";
        }
        if (letras[1] == 11)
        {
            texto[1].text = "K";
        }
        if (letras[1] == 12)
        {
            texto[1].text = "L";
        }
        if (letras[1] == 13)
        {
            texto[1].text = "M";
        }
        if (letras[1] == 14)
        {
            texto[1].text = "N";
        }
        if (letras[1] == 15)
        {
            texto[1].text = "O";
        }
        if (letras[1] == 16)
        {
            texto[1].text = "P";
        }
        if (letras[1] == 17)
        {
            texto[1].text = "Q";
        }
        if (letras[1] == 18)
        {
            texto[1].text = "R";
        }
        if (letras[1] == 19)
        {
            texto[1].text = "S";
        }
        if (letras[1] == 20)
        {
            texto[1].text = "T";
        }
        if (letras[1] == 21)
        {
            texto[1].text = "U";
        }
        if (letras[1] == 22)
        {
            texto[1].text = "W";
        }
        if (letras[1] == 23)
        {
            texto[1].text = "X";
        }
        if (letras[1] == 24)
        {
            texto[1].text = "Y";
        }
        if (letras[1] == 25)
        {
            texto[1].text = "Z";
        }







        if (letras[2] == 1)
        {
            texto[2].text = "A";
        }
        if (letras[2] == 2)
        {
            texto[2].text = "B";
        }
        if (letras[2] == 3)
        {
            texto[2].text = "C";
        }
        if (letras[2] == 4)
        {
            texto[2].text = "D";
        }
        if (letras[2] == 5)
        {
            texto[2].text = "E";
        }
        if (letras[2] == 6)
        {
            texto[2].text = "F";
        }
        if (letras[2] == 7)
        {
            texto[2].text = "G";
        }
        if (letras[2] == 8)
        {
            texto[2].text = "H";
        }
        if (letras[2] == 9)
        {
            texto[2].text = "I";
        }
        if (letras[2] == 10)
        {
            texto[2].text = "J";
        }
        if (letras[2] == 11)
        {
            texto[2].text = "K";
        }
        if (letras[2] == 12)
        {
            texto[2].text = "L";
        }
        if (letras[2] == 13)
        {
            texto[2].text = "M";
        }
        if (letras[2] == 14)
        {
            texto[2].text = "N";
        }
        if (letras[2] == 15)
        {
            texto[2].text = "O";
        }
        if (letras[2] == 16)
        {
            texto[2].text = "P";
        }
        if (letras[2] == 17)
        {
            texto[2].text = "Q";
        }
        if (letras[2] == 18)
        {
            texto[2].text = "R";
        }
        if (letras[2] == 19)
        {
            texto[2].text = "S";
        }
        if (letras[2] == 20)
        {
            texto[2].text = "T";
        }
        if (letras[2] == 21)
        {
            texto[2].text = "U";
        }
        if (letras[2] == 22)
        {
            texto[2].text = "W";
        }
        if (letras[2] == 23)
        {
            texto[2].text = "X";
        }
        if (letras[2] == 24)
        {
            texto[2].text = "Y";
        }
        if (letras[2] == 25)
        {
            texto[2].text = "Z";
        }






        if (letras[3] == 1)
        {
            texto[3].text = "A";
        }
        if (letras[3] == 2)
        {
            texto[3].text = "B";
        }
        if (letras[3] == 3)
        {
            texto[3].text = "C";
        }
        if (letras[3] == 4)
        {
            texto[3].text = "D";
        }
        if (letras[3] == 5)
        {
            texto[3].text = "E";
        }
        if (letras[3] == 6)
        {
            texto[3].text = "F";
        }
        if (letras[3] == 7)
        {
            texto[3].text = "G";
        }
        if (letras[3] == 8)
        {
            texto[3].text = "H";
        }
        if (letras[3] == 9)
        {
            texto[3].text = "I";
        }
        if (letras[3] == 10)
        {
            texto[3].text = "J";
        }
        if (letras[3] == 11)
        {
            texto[3].text = "K";
        }
        if (letras[3] == 12)
        {
            texto[3].text = "L";
        }
        if (letras[3] == 13)
        {
            texto[3].text = "M";
        }
        if (letras[3] == 14)
        {
            texto[3].text = "N";
        }
        if (letras[3] == 15)
        {
            texto[3].text = "O";
        }
        if (letras[3] == 16)
        {
            texto[3].text = "P";
        }
        if (letras[3] == 17)
        {
            texto[3].text = "Q";
        }
        if (letras[3] == 18)
        {
            texto[3].text = "R";
        }
        if (letras[3] == 19)
        {
            texto[3].text = "S";
        }
        if (letras[3] == 20)
        {
            texto[3].text = "T";
        }
        if (letras[3] == 21)
        {
            texto[3].text = "U";
        }
        if (letras[3] == 22)
        {
            texto[3].text = "W";
        }
        if (letras[3] == 23)
        {
            texto[3].text = "X";
        }
        if (letras[3] == 24)
        {
            texto[3].text = "Y";
        }
        if (letras[3] == 25)
        {
            texto[3].text = "Z";
        }
















        if (letras[4] == 1)
        {
            texto[4].text = "A";
        }
        if (letras[4] == 2)
        {
            texto[4].text = "B";
        }
        if (letras[4] == 3)
        {
            texto[4].text = "C";
        }
        if (letras[4] == 4)
        {
            texto[4].text = "D";
        }
        if (letras[4] == 5)
        {
            texto[4].text = "E";
        }
        if (letras[4] == 6)
        {
            texto[4].text = "F";
        }
        if (letras[4] == 7)
        {
            texto[4].text = "G";
        }
        if (letras[4] == 8)
        {
            texto[4].text = "H";
        }
        if (letras[4] == 9)
        {
            texto[4].text = "I";
        }
        if (letras[4] == 10)
        {
            texto[4].text = "J";
        }
        if (letras[4] == 11)
        {
            texto[4].text = "K";
        }
        if (letras[4] == 12)
        {
            texto[4].text = "L";
        }
        if (letras[4] == 13)
        {
            texto[4].text = "M";
        }
        if (letras[4] == 14)
        {
            texto[4].text = "N";
        }
        if (letras[4] == 15)
        {
            texto[4].text = "O";
        }
        if (letras[4] == 16)
        {
            texto[4].text = "P";
        }
        if (letras[4] == 17)
        {
            texto[4].text = "Q";
        }
        if (letras[4] == 18)
        {
            texto[4].text = "R";
        }
        if (letras[4] == 19)
        {
            texto[4].text = "S";
        }
        if (letras[4] == 20)
        {
            texto[4].text = "T";
        }
        if (letras[4] == 21)
        {
            texto[4].text = "U";
        }
        if (letras[0] == 22)
        {
            texto[4].text = "W";
        }
        if (letras[4] == 23)
        {
            texto[4].text = "X";
        }
        if (letras[4] == 24)
        {
            texto[4].text = "Y";
        }
        if (letras[4] == 25)
        {
            texto[4].text = "Z";
        }
    }





    public void abrir()
    {
        if(texto[0].text == "B" && texto[1].text == "I" && texto[2].text == "L" && texto[3].text == "L" && texto[4].text == "Y")
        {
            textoBrinquedo.enabled = false;
            cont = 1;
            caveta.SetBool("abrir", true);
            gameObject.tag = "Untagged";
            sair();
        }
    }



}
