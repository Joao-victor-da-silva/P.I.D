using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class valvulas : MonoBehaviour
{
    [SerializeField]
    Transform[] valve;
    [SerializeField]
    GameObject[] merdas;

    AudioSource descarga;

    bool[] pegou;

    int cont, v1,v2,v3,v4,v5, numeroVal;

    [SerializeField]
    Text textoValvulas;

    // Start is called before the first frame update
    void Start()
    {
        descarga = GetComponent<AudioSource>();
        pegou = new bool[4];
        textoValvulas.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        pegar();
    }

    private void pegar()
    {
        if(pegou[0] == true)
        {
            valve[4].transform.position = valve[0].transform.position;
            valve[4].transform.rotation = valve[0].transform.rotation;
            //valve[4].GetComponent<objeto>().enabled = false;
            valve[4].GetComponent<Rigidbody>().isKinematic = true;
            valve[4].GetComponent<BoxCollider>().isTrigger = true;
            valve[0].transform.Rotate(0, 15 * Time.deltaTime, 0);
            valve[4].tag = "Untagged";
            if(v1 == 0)
            {
                v1 = 1;
                numeroVal++;
                textoValvulas.text = numeroVal + "/4";
                textoValvulas.enabled = true;
            }
        }
        if (pegou[1] == true)
        {
            valve[5].transform.position = valve[1].transform.position;
            valve[5].transform.rotation = valve[1].transform.rotation;
            //valve[5].GetComponent<objeto>().enabled = false;
            valve[5].GetComponent<Rigidbody>().isKinematic = true;
            valve[5].GetComponent<BoxCollider>().isTrigger = true;
            valve[1].transform.Rotate(0, 15 * Time.deltaTime, 0);
            valve[5].tag = "Untagged";
            if (v2 == 0)
            {
                v2 = 1;
                numeroVal++;
                textoValvulas.text = numeroVal + "/4";
                textoValvulas.enabled = true;
            }
        }
        if (pegou[2] == true)
        {
            valve[6].transform.position = valve[2].transform.position;
            valve[6].transform.rotation = valve[2].transform.rotation;
            //valve[6].GetComponent<objeto>().enabled = false;
            valve[6].GetComponent<Rigidbody>().isKinematic = true;
            valve[6].GetComponent<BoxCollider>().isTrigger = true;
            valve[2].transform.Rotate(0, 15 * Time.deltaTime, 0);
            valve[6].tag = "Untagged";
            if (v3 == 0)
            {
                v3 = 1;
                numeroVal++;
                textoValvulas.text = numeroVal + "/4";
                textoValvulas.enabled = true;
            }
        }
        if (pegou[3] == true)
        {
            valve[7].transform.position = valve[3].transform.position;
            valve[7].transform.rotation = valve[3].transform.rotation;
            //valve[7].GetComponent<objeto>().enabled = false;
            valve[7].GetComponent<Rigidbody>().isKinematic = true;
            valve[7].GetComponent<BoxCollider>().isTrigger = true;
            valve[3].transform.Rotate(0, 15 * Time.deltaTime, 0);
            valve[7].tag = "Untagged";
            if (v4 == 0)
            {
                v4 = 1;
                numeroVal++;
                textoValvulas.text = numeroVal + "/4";
                textoValvulas.enabled = true;
            }
        }

        if(pegou[0] == true && pegou[1] == true && pegou[2] == true && pegou[3] == true && cont == 0)
        {
            textoValvulas.enabled = false;
            merdas[0].SetActive(false);
            merdas[1].SetActive(false);
            descarga.Play();
            cont = 1;
        }



    }


    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject == valve[4].gameObject)
        {
            pegou[0] = true;
        }
        if (other.gameObject == valve[5].gameObject)
        {
            pegou[1] = true;
        }
        if (other.gameObject == valve[6].gameObject)
        {
            pegou[2] = true;
        }
        if (other.gameObject == valve[7].gameObject)
        {
            pegou[3] = true;
        }
    }

}
