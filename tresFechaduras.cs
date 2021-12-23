using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tresFechaduras : MonoBehaviour
{

    [SerializeField]
    GameObject[] chaves;

    porta porteira;

    bool[] ligado;

    // Start is called before the first frame update
    void Start()
    {
        ligado = new bool[6];
        porteira = GetComponent<porta>();
    }

    // Update is called once per frame
    void Update()
    {
        if(ligado[0] == true)
        {
            chaves[3].transform.position = chaves[0].transform.position;
            chaves[3].transform.rotation = chaves[0].transform.rotation;
            chaves[3].GetComponent<BoxCollider>().isTrigger = true;
            chaves[3].GetComponent<Rigidbody>().isKinematic = true;
            chaves[3].transform.parent = chaves[0].transform;
        }
        if (ligado[1] == true)
        {
            chaves[4].transform.position = chaves[1].transform.position;
            chaves[4].transform.rotation = chaves[1].transform.rotation;
            chaves[4].GetComponent<BoxCollider>().isTrigger = true;
            chaves[4].GetComponent<Rigidbody>().isKinematic = true;
            chaves[4].transform.parent = chaves[1].transform;
        }
        if (ligado[2] == true)
        {
            chaves[5].transform.position = chaves[2].transform.position;
            chaves[5].transform.rotation = chaves[2].transform.rotation;
            chaves[5].GetComponent<BoxCollider>().isTrigger = true;
            chaves[5].GetComponent<Rigidbody>().isKinematic = true;
            chaves[5].transform.parent = chaves[2].transform;
        }

        if(ligado[0] == true && ligado[1] == true && ligado[2] == true)
        {
            porteira.chave = true;
        }

    }



    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject == chaves[3])
        {
            ligado[0] = true;
        }
        if (other.gameObject == chaves[4])
        {
            ligado[1] = true;
        }
        if (other.gameObject == chaves[5])
        {
            ligado[2] = true;
        }
    }




}
