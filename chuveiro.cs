using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chuveiro : MonoBehaviour
{

    public GameObject missao ,missao02;
    [SerializeField]
    bool usar, usar02;
    [SerializeField]
    int cont, cont02;
    [SerializeField]
    Transform aguaChiveiro;

    // Start is called before the first frame update
    void Start()
    {

        aguaChiveiro = transform.Find("aguaChuva");
        missao02 = GameObject.Find("Canvas");

    }

    // Update is called once per frame
    void Update()
    {
        
        if(missao02 != null && cont == 0 && missao != null)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                missao02.GetComponent<objetivos>().cont4 = 1;
                StartCoroutine(banho());
                cont = 1;
            }
        }

        if(usar == true && missao != null)
        {
            if (Input.GetKeyDown(KeyCode.E) && cont02 == 0)
            {
                cont02 = 1;
               aguaChiveiro.GetComponent<ParticleSystem>().Play();
                GetComponent<AudioSource>().Play();
            }
            else if (Input.GetKeyDown(KeyCode.E) && cont02 == 1)
            {
                cont02 = 0;
                aguaChiveiro.GetComponent<ParticleSystem>().Stop();
                GetComponent<AudioSource>().Stop();
            }
            
        }


    }


    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "sensor")
        {
            missao = other.gameObject;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if(other.tag == "sensor")
        {
            missao = null;
        }
    }



    private IEnumerator banho()
    {
        aguaChiveiro.GetComponent<ParticleSystem>().Play();
        GetComponent<AudioSource>().Play();
        yield return new WaitForSeconds(5f);
        aguaChiveiro.GetComponent<ParticleSystem>().Stop();
        GetComponent<AudioSource>().Stop();
        usar = true;
    }

}
