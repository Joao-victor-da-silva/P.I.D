using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.UI;

public class missao02 : MonoBehaviour
{

    
    [SerializeField]
    GameObject canvas, audios;

    [SerializeField]
    GameObject sensorr, campainha;

    [SerializeField]
    PlayableDirector oi;

    public int janelas, camp;

    int cont, cont02;

    [SerializeField]
    Text texto;

    // Start is called before the first frame update
    void Start()
    {
        sensorr = GameObject.Find("sensor");
        campainha.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {

        texto.text = (GameMultiLang.GetTraduction("janelas:") + janelas + "/21");

        borraCaraiio();
        tocarCamainha();
        missao002();
        missao04();
        /*if(canvas.GetComponent<objetivos>().cont1 == 1 && audios.activeSelf == true)
        {
            audios.SetActive(false);
        }
        */
    }

    private void tocarCamainha()
    {
        if(canvas.GetComponent<objetivos>().cont1 != 0 && camp == 0)
        {
            campainha.SetActive(false);
            camp = 1;
        }
    }

    public void missao01()
    {

        canvas.GetComponent<objetivos>().cont1 = 1;

    }

    public void missao002()
    {

       if(janelas == 21 && cont02 == 0)
        {
            cont02 = 1;
            //janelas++;
            canvas.GetComponent<objetivos>().cont2 = 1;
        }


    }

    public void missao03()
    {
        canvas.GetComponent<objetivos>().cont3 = 1;
    }

    private void missao04()
    {
        if(sensorr.GetComponent<visualizar>().tomou06 == true)
        {
            sensorr.GetComponent<visualizar>().tomou06 = false;
            canvas.GetComponent<objetivos>().cont4 = 1;
        }
    }


    private void borraCaraiio()
    {
        if(canvas.GetComponent<objetivos>().cont1 != 0 && cont == 0)
        {
            cont = 1;
            oi.Play();
        }
        
    }




}
