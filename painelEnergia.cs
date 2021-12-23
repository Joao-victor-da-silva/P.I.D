using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class painelEnergia : MonoBehaviour
{


    [SerializeField]
    GameObject[] botoes;
    [SerializeField]
    GameObject painel, objetivoss;

    float[] girar;

    bool ligar, ligado, ligou, ligou02;
    [SerializeField]
    bool[] funciona;

    [SerializeField]
    GameObject walter;

    // Start is called before the first frame update
    void Start()
    {
        girar = new float[16];
        funciona = new bool[7];
        ligar = false;
        ligado = false;
        ligou = false;
        ligou02 = false;
    }

    // Update is called once per frame
    void Update()
    {

        if(ligar == true)
        {
            if(gameObject.name != "caixaDagua")
            {
                resolvido();
            }
            else
            {
                resolvido02();
            }
           

            if (Input.GetKeyDown(KeyCode.E) && ligado == false && gameObject.tag == "interagir")
            {
                Cursor.visible = true;
                Time.timeScale = 0;
                Cursor.lockState = CursorLockMode.None;
                painel.SetActive(true);
                ligado = true;
                
            }
            else if (Input.GetKeyDown(KeyCode.E) && ligado == true || Input.GetKeyDown(KeyCode.Escape) && ligado == true || Input.GetKeyDown(KeyCode.I) && ligado == true)
            {
                fechar();
            }
        }

        corrigir();

    }

    public void fechar()
    {
        Cursor.visible = false;
        Time.timeScale = 1;
        Cursor.lockState = CursorLockMode.Locked;
        painel.SetActive(false);
        ligado = false;
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "sensor")
        {
            ligar = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "sensor")
        {
            ligar = false;
        }
    }


    public void botao01()
    {
        
        if (girar[0] != 270f)
        {
            girar[0] = girar[0] + 90f;
        }
        else if(girar[0] == 270f)
        {
            girar[0] = 0f;
        }
        
        if (girar[0] == 0)
        {
            botoes[0].transform.rotation = new Quaternion(0,
            0, 0, 1);
        }
        if (girar[0] == 90)
        {
            botoes[0].transform.rotation = new Quaternion(0,
            0, 0.70f, 0.70f);
        }
        if (girar[0] == 180)
        {
            botoes[0].transform.rotation = new Quaternion(0,
            0, 1, 0);
        }
        if (girar[0] == 270)
        {
            botoes[0].transform.rotation = new Quaternion(0,
            0, 0.70f, -0.70f);
        }

        print(girar[0] + " 1");
    }

    public void botao02()
    {

        if (girar[1] != 270f)
        {
            girar[1] = girar[1] + 90f;
        }
        else if (girar[1] == 270f)
        {
            girar[1] = 0f;
        }


        if (girar[1] == 0)
        {
            botoes[1].transform.rotation = new Quaternion(0,
            0, 0, 1);
        }
        if (girar[1] == 90)
        {
            botoes[1].transform.rotation = new Quaternion(0,
            0, 0.70f, 0.70f);
        }
        if (girar[1] == 180)
        {
            botoes[1].transform.rotation = new Quaternion(0,
            0, 1, 0);
        }
        if (girar[1] == 270)
        {
            botoes[1].transform.rotation = new Quaternion(0,
            0, 0.70f, -0.70f);
        }

        print(girar[1] + " 2");
    }

    public void botao03()
    {

        if (girar[2] != 270f)
        {
            girar[2] = girar[2] + 90f;
        }
        else if (girar[2] == 270f)
        {
            girar[2] = 0f;
        }


        if (girar[2] == 0)
        {
            botoes[2].transform.rotation = new Quaternion(0,
            0, 0, 1);
        }
        if (girar[2] == 90)
        {
            botoes[2].transform.rotation = new Quaternion(0,
            0, 0.70f, 0.70f);
        }
        if (girar[2] == 180)
        {
            botoes[2].transform.rotation = new Quaternion(0,
            0, 1, 0);
        }
        if (girar[2] == 270)
        {
            botoes[2].transform.rotation = new Quaternion(0,
            0, 0.70f, -0.70f);
        }

        print(girar[2] + " 3");
    }

    public void botao04()
    {

        if (girar[3] != 270f)
        {
            girar[3] = girar[3] + 90f;
        }
        else if (girar[3] == 270f)
        {
            girar[3] = 0f;
        }


        if (girar[3] == 0)
        {
            botoes[3].transform.rotation = new Quaternion(0,
            0, 0, 1);
        }
        if (girar[3] == 90)
        {
            botoes[3].transform.rotation = new Quaternion(0,
            0, 0.70f, 0.70f);
        }
        if (girar[3] == 180)
        {
            botoes[3].transform.rotation = new Quaternion(0,
            0, 1, 0);
        }
        if (girar[3] == 270)
        {
            botoes[3].transform.rotation = new Quaternion(0,
            0, 0.70f, -0.70f);
        }

        print(girar[3] + " 4");
    }

    public void botao05()
    {

        if (girar[4] != 270f)
        {
            girar[4] = girar[4] + 90f;
        }
        else if (girar[4] == 270f)
        {
            girar[4] = 0f;
        }


        if (girar[4] == 0)
        {
            botoes[4].transform.rotation = new Quaternion(0,
            0, 0, 1);
        }
        if (girar[4] == 90)
        {
            botoes[4].transform.rotation = new Quaternion(0,
            0, 0.70f, 0.70f);
        }
        if (girar[4] == 180)
        {
            botoes[4].transform.rotation = new Quaternion(0,
            0, 1, 0);
        }
        if (girar[4] == 270)
        {
            botoes[4].transform.rotation = new Quaternion(0,
            0, 0.70f, -0.70f);
        }

        print(girar[4] + " 5");
    }

    public void botao06()
    {

        if (girar[5] != 270f)
        {
            girar[5] = girar[5] + 90f;
        }
        else if (girar[5] == 270f)
        {
            girar[5] = 0f;
        }


        if (girar[5] == 0)
        {
            botoes[5].transform.rotation = new Quaternion(0,
            0, 0, 1);
        }
        if (girar[5] == 90)
        {
            botoes[5].transform.rotation = new Quaternion(0,
            0, 0.70f, 0.70f);
        }
        if (girar[5] == 180)
        {
            botoes[5].transform.rotation = new Quaternion(0,
            0, 1, 0);
        }
        if (girar[5] == 270)
        {
            botoes[5].transform.rotation = new Quaternion(0,
            0, 0.70f, -0.70f);
        }

        print(girar[5] + " 6");
    }

    public void botao07()
    {

        if (girar[6] != 270f)
        {
            girar[6] = girar[6] + 90f;
        }
        else if (girar[6] == 270f)
        {
            girar[6] = 0f;
        }


        if (girar[6] == 0)
        {
            botoes[6].transform.rotation = new Quaternion(0,
            0, 0, 1);
        }
        if (girar[6] == 90)
        {
            botoes[6].transform.rotation = new Quaternion(0,
            0, 0.70f, 0.70f);
        }
        if (girar[6] == 180)
        {
            botoes[6].transform.rotation = new Quaternion(0,
            0, 1, 0);
        }
        if (girar[6] == 270)
        {
            botoes[6].transform.rotation = new Quaternion(0,
            0, 0.70f, -0.70f);
        }

        print(girar[6] + " 7");
    }

    public void botao08()
    {

        if (girar[7] != 270f)
        {
            girar[7] = girar[7] + 90f;
        }
        else if (girar[7] == 270f)
        {
            girar[7] = 0f;
        }


        if (girar[7] == 0)
        {
            botoes[7].transform.rotation = new Quaternion(0,
            0, 0, 1);
        }
        if (girar[7] == 90)
        {
            botoes[7].transform.rotation = new Quaternion(0,
            0, 0.70f, 0.70f);
        }
        if (girar[7] == 180)
        {
            botoes[7].transform.rotation = new Quaternion(0,
            0, 1, 0);
        }
        if (girar[7] == 270)
        {
            botoes[7].transform.rotation = new Quaternion(0,
            0, 0.70f, -0.70f);
        }

        print(girar[7] + " 8");
    }

    public void botao09()
    {

        if (girar[8] != 270f)
        {
            girar[8] = girar[8] + 90f;
        }
        else if (girar[8] == 270f)
        {
            girar[8] = 0f;
        }


        if (girar[8] == 0)
        {
            botoes[8].transform.rotation = new Quaternion(0,
            0, 0, 1);
        }
        if (girar[8] == 90)
        {
            botoes[8].transform.rotation = new Quaternion(0,
            0, 0.70f, 0.70f);
        }
        if (girar[8] == 180)
        {
            botoes[8].transform.rotation = new Quaternion(0,
            0, 1, 0);
        }
        if (girar[8] == 270)
        {
            botoes[8].transform.rotation = new Quaternion(0,
            0, 0.70f, -0.70f);
        }

        print(girar[8] + " 9");
    }

    public void botao10()
    {

        if (girar[9] != 270f)
        {
            girar[9] = girar[9] + 90f;
        }
        else if (girar[9] == 270f)
        {
            girar[9] = 0f;
        }


        if (girar[9] == 0)
        {
            botoes[9].transform.rotation = new Quaternion(0,
            0, 0, 1);
        }
        if (girar[9] == 90)
        {
            botoes[9].transform.rotation = new Quaternion(0,
            0, 0.70f, 0.70f);
        }
        if (girar[9] == 180)
        {
            botoes[9].transform.rotation = new Quaternion(0,
            0, 1, 0);
        }
        if (girar[9] == 270)
        {
            botoes[9].transform.rotation = new Quaternion(0,
            0, 0.70f, -0.70f);
        }
        print(girar[9] + " 10");

    }

    public void botao11()
    {

        if (girar[10] != 270f)
        {
            girar[10] = girar[10] + 90f;
        }
        else if (girar[10] == 270f)
        {
            girar[10] = 0f;
        }


        if (girar[10] == 0)
        {
            botoes[10].transform.rotation = new Quaternion(0,
            0, 0, 1);
        }
        if (girar[10] == 90)
        {
            botoes[10].transform.rotation = new Quaternion(0,
            0, 0.70f, 0.70f);
        }
        if (girar[10] == 180)
        {
            botoes[10].transform.rotation = new Quaternion(0,
            0, 1, 0);
        }
        if (girar[10] == 270)
        {
            botoes[10].transform.rotation = new Quaternion(0,
            0, 0.70f, -0.70f);
        }

        print(girar[10] + " 11");
    }

    public void botao12()
    {

        if (girar[11] != 270f)
        {
            girar[11] = girar[11] + 90f;
        }
        else if (girar[11] == 270f)
        {
            girar[11] = 0f;
        }


        if (girar[1] == 0)
        {
            botoes[11].transform.rotation = new Quaternion(0,
            0, 0, 1);
        }
        if (girar[11] == 90)
        {
            botoes[11].transform.rotation = new Quaternion(0,
            0, 0.70f, 0.70f);
        }
        if (girar[11] == 180)
        {
            botoes[11].transform.rotation = new Quaternion(0,
            0, 1, 0);
        }
        if (girar[11] == 270)
        {
            botoes[11].transform.rotation = new Quaternion(0,
            0, 0.70f, -0.70f);
        }

        print(girar[11] + " 12");
    }

    public void botao13()
    {

        if (girar[12] != 270f)
        {
            girar[12] = girar[12] + 90f;
        }
        else if (girar[12] == 270f)
        {
            girar[12] = 0f;
        }


        if (girar[12] == 0)
        {
            botoes[12].transform.rotation = new Quaternion(0,
            0, 0, 1);
        }
        if (girar[12] == 90)
        {
            botoes[12].transform.rotation = new Quaternion(0,
            0, 0.70f, 0.70f);
        }
        if (girar[12] == 180)
        {
            botoes[12].transform.rotation = new Quaternion(0,
            0, 1, 0);
        }
        if (girar[12] == 270)
        {
            botoes[12].transform.rotation = new Quaternion(0,
            0, 0.70f, -0.70f);
        }

        print(girar[12] + " 13");
    }

    public void botao14()
    {

        if (girar[13] != 270f)
        {
            girar[13] = girar[13] + 90f;
        }
        else if (girar[13] == 270f)
        {
            girar[13] = 0f;
        }

        if (girar[13] == 0)
        {
            botoes[13].transform.rotation = new Quaternion(0,
            0, 0, 1);
        }
        if (girar[13] == 90)
        {
            botoes[13].transform.rotation = new Quaternion(0,
            0, 0.70f, 0.70f);
        }
        if (girar[13] == 180)
        {
            botoes[13].transform.rotation = new Quaternion(0,
            0, 1, 0);
        }
        if (girar[13] == 270)
        {
            botoes[13].transform.rotation = new Quaternion(0,
            0, 0.70f, -0.70f);
        }

        print(girar[13] + " 14");
    }

    public void botao15()
    {

        if (girar[14] != 270f)
        {
            girar[14] = girar[14] + 90f;
        }
        else if (girar[14] == 270f)
        {
            girar[14] = 0f;
        }


        if (girar[14] == 0)
        {
            botoes[14].transform.rotation = new Quaternion(0,
            0, 0, 1);
        }
        if (girar[14] == 90)
        {
            botoes[14].transform.rotation = new Quaternion(0,
            0, 0.70f, 0.70f);
        }
        if (girar[14] == 180)
        {
            botoes[14].transform.rotation = new Quaternion(0,
            0, 1, 0);
        }
        if (girar[14] == 270)
        {
            botoes[14].transform.rotation = new Quaternion(0,
            0, 0.70f, -0.70f);
        }

        print(girar[14] + " 15");
    }

    public void botao16()
    {

        if (girar[15] != 270f)
        {
            girar[15] = girar[15] + 90f;
        }
        else if (girar[15] == 270f)
        {
            girar[15] = 0f;
        }


        if (girar[15] == 0)
        {
            botoes[15].transform.rotation = new Quaternion(0,
            0, 0, 1);
        }
        if (girar[15] == 90)
        {
            botoes[15].transform.rotation = new Quaternion(0,
            0, 0.70f, 0.70f);
        }
        if (girar[15] == 180)
        {
            botoes[15].transform.rotation = new Quaternion(0,
            0, 1, 0);
        }
        if (girar[15] == 270)
        {
            botoes[15].transform.rotation = new Quaternion(0,
            0, 0.70f, -0.70f);
        }

        print(girar[15] + " 16");
    }

    //girar[0] == 0 && girar[4] == 90 && girar[8] == 90 && girar[9] == 270 && 
    //girar[3] == 90 && girar[11] == 90 && girar[10] == 270 &&
    //girar[14] == 180 && girar[15] == 90 && girar[12] == 90


    // 0 ok 4 ok 8 ok 12 ok 9 ok  3 ok   11 ok 10 ok 14 ok 15 ok
    // 5 ?? ok   2 ?? ok 7 ?? ok
    // 1 ??

    private void resolvido()
    {
        if (funciona[0] == true && funciona[1] == true && girar[8] == 90 && girar[9] == 270 && 
            girar[3] == 90 && girar[11] == 90 && girar[10] == 270 &&
            girar[14] == 180 && funciona[6] == true && funciona[2] == true && funciona[4] == true
            && funciona[5] == true && funciona[3] == true && girar[1] == 0)
        {
            girar[0]++;
            girar[1]++;
            girar[2]++;
            girar[3]++;
            girar[4]++;
            girar[5]++;
            girar[6]++;
            girar[7]++;
            girar[8]++;
            girar[9]++;
            girar[10]++;
            girar[11]++;
            girar[12]++;
            girar[13]++;
            girar[14]++;
            girar[15]++;

            ligou = true;
        }
    }


    private void resolvido02()
    {
        if (girar[0] == 270 && girar[4] == 90 && girar[8] == 0 && girar[12] == 0 &&
            girar[1] == 0 && girar[5] == 180 && girar[9] == 270 &&
            girar[13] == 180 && girar[2] == 270 && girar[6] == 0 && girar[14] == 180 && 
            girar[3] == 90 && girar[7] == 180 && girar[15]  == 0 && girar[11] == 0 
            || 
            girar[0] == 270 && girar[4] == 90 && girar[8] == 0 && girar[12] == 0 &&
            girar[1] == 0 && girar[5] == 180 && girar[9] == 270 &&
            girar[13] == 0 && girar[2] == 270 && girar[6] == 0 && girar[14] == 180 &&
            girar[3] == 90 && girar[7] == 180 && girar[15] == 0 && girar[11] == 0)
        {
            girar[0]++;
            girar[1]++;
            girar[2]++;
            girar[3]++;
            girar[4]++;
            girar[5]++;
            girar[6]++;
            girar[7]++;
            girar[8]++;
            girar[9]++;
            girar[10]++;
            girar[11]++;
            girar[12]++;
            girar[13]++;
            girar[14]++;
            girar[15]++;

            ligou02 = true;
        }
    }


    public void funfou()
    {
        if(ligou == true)
        {
            gameObject.tag = "Untagged";
            objetivoss.GetComponent<objetivos>().cont3 = 1;
            if (objetivoss.GetComponent<objetivos>().cont3 == 1)
            {
                fechar();
            }
        }

        if (ligou02 == true)
        {
            gameObject.tag = "Untagged";
            objetivoss.GetComponent<objetivos>().cont3 = 1;
            if (objetivoss.GetComponent<objetivos>().cont3 == 1)
            {
                walter.SetActive(false);
                fechar();
            }
        }

    }


    private void corrigir()
    {
        /////

        if (girar[0] == 0)
        {
            funciona[0] = true;
        }
        else if (girar[0] == 180)
        {
            funciona[0] = true;
        }
        if (girar[0] == 90)
        {
            funciona[0] = false;
        }
        else if (girar[0] == 270)
        {
            funciona[0] = false;
        }

        //////

        if (girar[4] == 90)
        {
            funciona[1] = true;
        }
        else if (girar[4] == 270)
        {
            funciona[1] = true;
        }
        if (girar[4] == 0)
        {
            funciona[1] = false;
        }
        else if (girar[4] == 180)
        {
            funciona[1] = false;
        }



        ////


        if (girar[12] == 90)
        {
            funciona[2] = true;
        }
        else if (girar[12] == 270)
        {
            funciona[2] = true;
        }
        if (girar[12] == 0)
        {
            funciona[2] = false;
        }
        else if (girar[12] == 180)
        {
            funciona[2] = false;
        }

        //////
        


        if (girar[5] == 0)
        {
            funciona[3] = true;
        }
        else if (girar[5] == 180)
        {
            funciona[3] = true;
        }
        if (girar[5] == 90)
        {
            funciona[3] = false;
        }
        else if (girar[5] == 270)
        {
            funciona[3] = false;
        }

        /////
        ///

        if (girar[2] == 0)
        {
            funciona[4] = true;
        }
        else if (girar[2] == 180)
        {
            funciona[4] = true;
        }
        if (girar[2] == 90)
        {
            funciona[4] = false;
        }
        else if (girar[2] == 270)
        {
            funciona[4] = false;
        }


        ////
        ///


        if (girar[7] == 0)
        {
            funciona[5] = true;
        }
        else if (girar[7] == 180)
        {
            funciona[5] = true;
        }
        if (girar[7] == 90)
        {
            funciona[5] = false;
        }
        else if (girar[7] == 270)
        {
            funciona[5] = false;
        }


        ///


        if (girar[15] == 90)
        {
            funciona[6] = true;
        }
        else if (girar[15] == 270)
        {
            funciona[6] = true;
        }
        if (girar[15] == 0)
        {
            funciona[6] = false;
        }
        else if (girar[15] == 180)
        {
            funciona[6] = false;
        }

    }

}



    



