using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class corrigirColicao : MonoBehaviour
{
    [SerializeField]
    GameObject alvo, alvo01, alvo02, alvo03;

    [SerializeField]
    bool mudar;

    public float DistanciaDoLaser = 2.33f;

    RaycastHit hit;
    float agoravai;

    [SerializeField]
    Transform sensorAlvo;

    GameObject minecraft;

    void Start()
    {
        DistanciaDoLaser = 2.33f;
        alvo = GameObject.Find("sensor02");
        sensorAlvo = transform.Find("sensor");
    }
    void Update()
    {
        try
        {
            if (sensorAlvo.gameObject.GetComponent<sensor>().pegou == true)
            {
                DistanciaDoLaser = 1.28f;
            }
            else if (sensorAlvo.gameObject.GetComponent<sensor>().pegou == false)
            {
                DistanciaDoLaser = 2.33f;
            }


            //alvo03 = new Vector3(alvo.transform.position.x, alvo.transform.position.y , alvo.transform.position.z + 0.5f);

            //hit.distance <= 1.28f

            if (hit.distance <= 1.28f)
            {
                alvo01.transform.position = Vector3.Lerp(alvo01.transform.position, alvo03.transform.position, Time.deltaTime * 10);
                print("não fiquixo");
            }
            else if (hit.distance > 1.28f)
            {
                alvo01.transform.position = Vector3.Lerp(alvo01.transform.position, alvo02.transform.position, Time.deltaTime * 10);
                print("fiquixo");
            }
        }
        catch(Exception e)
        {
            //print("errror " + e);
            PlayerPrefs.SetString("errorCorrigirColicao", e.ToString());
        }
        


    }

    void FixedUpdate()
    {
        try
        {

            // Desloca o bit do índice da camada (8) para obter uma máscara de bit
            int layerMask = 1 << 11;

            // Isso lançaria raios apenas contra os colisores na camada 8.
            // Mas, em vez disso, queremos colidir com tudo, exceto a camada 8. O operador ~ faz isso, ele inverte uma máscara de bits.
            layerMask = ~layerMask;

            Vector3 PontoFinalDoLaser = transform.position + transform.forward * DistanciaDoLaser;

            if (hit.distance <= DistanciaDoLaser)
            {
                agoravai = hit.distance;
            }
            else if (hit.distance > DistanciaDoLaser)
            {
                agoravai = DistanciaDoLaser;
            }
            // O raio intercepta qualquer objeto, exceto a camada do player
            if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit, Mathf.Infinity, layerMask))
            {
                Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * agoravai, Color.yellow);
                Debug.Log("Acertou");
                float distancia = Vector3.Distance(transform.position, hit.point);
                if (hit.distance <= DistanciaDoLaser)
                {
                    alvo.transform.position = transform.position + transform.forward * distancia;
                }
                else if (hit.distance > DistanciaDoLaser)
                {
                    alvo.transform.position = PontoFinalDoLaser;
                }


            }
            else
            {
                Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * DistanciaDoLaser, Color.white);
                Debug.Log("Não acertou ");
                alvo.transform.position = PontoFinalDoLaser;
            }


           
        }

        catch (Exception e)
        {
            PlayerPrefs.SetString("errorCorrigirColicaoFixedUpdate", e.ToString());
        }

    }
}
