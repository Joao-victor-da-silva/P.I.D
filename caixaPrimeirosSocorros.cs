using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class caixaPrimeirosSocorros : MonoBehaviour
{

    public GameObject painel ,n1,n2,n3,n4, menuPusar;
    Animator anim;
    bool trocar ,quebra;
    int num1, num2, num3, num4, ano1, ano2, ano3, ano4, cont;
    string numb1, numb2, numb3, numb4;


    [SerializeField]
    string oii;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        quebra = false;
        painel.SetActive(false);
        trocar = false;
        cont = 0;
    }

    // Update is called once per frame
    void Update()
    {

        anim.SetBool("troca", trocar);
        if(trocar == true)
        {
            gameObject.tag = "Untagged";
        }


        if (quebra == true && cont == 0)
        {
            menuPusar.GetComponent<menuPause>().podePausar = false;
            painel.SetActive(true);
            Cursor.lockState = CursorLockMode.None;
            Time.timeScale = 0;
            Cursor.visible = true;
            cont = 1;
        }
        if(quebra == false && cont == 1 || Input.GetKeyDown(KeyCode.Escape) && cont == 1)
        {
            painel.SetActive(false);
            Cursor.lockState = CursorLockMode.Locked;
            Time.timeScale = 1;
            Cursor.visible = false;
            cont = 0;
            StartCoroutine(menuPusar.GetComponent<menuPause>().parara());
        }

        if (num1 == 1 && num2 == 8 && num3 == 0 && num4 == 5 && oii == "semana01" || num1 == 0 && num2 == 5 && num3 == 1 && num4 == 8 && oii == "semana01")
        {
            trocar = true;
            quebra = false;
        }

        if (num1 == 2 && num2 == 0 && num3 == 2 && num4 == 0 && oii == "semana02" && gameObject.name != "errado")
        {
            trocar = true;
            quebra = false;
        }

        if (num1 == 1 && num2 == 8 && num3 == 3 && num4 == 6 && oii == "semana02" && gameObject.name == "errado")
        {
            trocar = true;
            quebra = false;
        }

        if (num1 == 1 && num2 == 9 && num3 == 9 && num4 == 0 && oii == "semana03")
        {
            trocar = true;
            quebra = false;
        }

        if (num1 == 2 && num2 == 0 && num3 == 0 && num4 == 0 && oii == "semana04")
        {
            trocar = true;
            quebra = false;
        }

        if (num1 == 2 && num2 == 0 && num3 == 2 && num4 == 1 && oii == "semana05")
        {
            trocar = true;
            quebra = false;
        }



        numb1 = n1.GetComponent<Text>().text;
        numb2 = n2.GetComponent<Text>().text;
        numb3 = n3.GetComponent<Text>().text;
        numb4 = n4.GetComponent<Text>().text;

        ano1 = int.Parse(numb1);
        ano2 = int.Parse(numb2);
        ano3 = int.Parse(numb3);
        ano4 = int.Parse(numb4);
    }



    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "sensor" && Input.GetKeyDown(KeyCode.E) && trocar == false || other.tag == "sensorAntigo" && Input.GetKeyDown(KeyCode.E) && trocar == false)
        {

            if (quebra == false && trocar == false)
            {
                quebra = true;
            }
            else
            {
                quebra = false;
            }

        }
    }


    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "sensor")
        {
            quebra = false;
        }
    }


    private void OnTriggerStay(Collider other)
    {
        if(other.tag == "sensor" && Input.GetKeyDown(KeyCode.E) && trocar == false || other.tag == "sensorAntigo" && Input.GetKeyDown(KeyCode.E) && trocar == false)
        {

            if(quebra == false)
            {
                quebra = true;
            }
            else
            {
                quebra = false;
            }

        }
    }

    public void cancelar()
    {
        quebra = false;
    }


    public void pegarNumero()
    {

        
        num1 = int.Parse(numb1);

       
        num2 = int.Parse(numb2);

        
        num3 = int.Parse(numb3);

        
        num4 = int.Parse(numb4);
    }

    public void soma01()
    {
        if(ano1 < 9)
        {
            n1.GetComponent<Text>().text = "" + (ano1 + 1);
        }
        
        
    }

    public void soma02()
    {
        if (ano2 < 9)
        {
            n2.GetComponent<Text>().text = "" + (ano2 + 1);
        }
    }

    public void soma03()
    {
        if (ano3 < 9)
        {
            n3.GetComponent<Text>().text = "" + (ano3 + 1);
        }
    }

    public void soma04()
    {
        if (ano4 < 9)
        {
            n4.GetComponent<Text>().text = "" + (ano4 + 1);
        }
    }

    public void sub01()
    {
        if (ano1 > 0)
        {
            n1.GetComponent<Text>().text = "" + (ano1 - 1);
        }
    }

    public void sub02()
    {
        if (ano2 > 0)
        {
            n2.GetComponent<Text>().text = "" + (ano2 - 1);
        }
    }

    public void sub03()
    {
        if (ano3 > 0)
        {
            n3.GetComponent<Text>().text = "" + (ano3 - 1);
        }
    }

    public void sub04()
    {
        if (ano4 > 0)
        {
            n4.GetComponent<Text>().text = "" + (ano4 - 1);
        }
    }
}
