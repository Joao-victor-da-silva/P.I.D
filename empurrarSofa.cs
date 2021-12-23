using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class empurrarSofa : MonoBehaviour
{

    bool ativo;

    [SerializeField]
    BoxCollider corrigirbug;

    [SerializeField]
    GameObject barragem, porta01;

    // Start is called before the first frame update
    void Start()
    {
        if(corrigirbug != null)
        {
            corrigirbug.enabled = false;
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.E) && ativo == true)
        {
            
            

            if (gameObject.name == "sofa")
            {
                sofa01();
            }
            if (gameObject.name == "Sofa")
            {
                sofa02();
            }
            
        }
    }

    private void sofa02()
    {
        if (transform.position.z < 7.53f)
        {

            transform.Translate(0.4f * Time.deltaTime, 0, 0);

        }
        if(transform.position.z >= 7.53f)
        {
            barragem.GetComponent<missao05>().positivo01 = true;
            print("deucerto");
        }
        if(transform.position.z < 7.53f && transform.position.z > 6f)
        {
            if (corrigirbug != null)
            {
                corrigirbug.enabled = true;
            }
        }

    }


    private void sofa01()
    {
        if (transform.position.z < 6.88f)
        {
            transform.Translate(0, -0.4f * Time.deltaTime, 0);

        }

        if (transform.position.z >= 6.88f)
        {
            barragem.GetComponent<missao05>().positivo02 = true;
            print("deucerto");
            porta01.GetComponent<Animator>().SetBool("invadiu", true);
        }

    }



    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "sensor")
        {
            ativo = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if(other.tag == "sensor")
        {
            ativo = false;
        }
    }

}
