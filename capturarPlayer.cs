using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class capturarPlayer : MonoBehaviour
{
    int cont, cont02;
    [SerializeField]
    GameObject missaoo02, fugir;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(cont == 1)
        {
            if(cont02 == 0)
            {
                if(gameObject.name == "missao01")
                {
                    cont02 = 1;
                    missaoo02.GetComponent<missao02>().missao01();
                }
                if (gameObject.name == "missao02")
                {
                    cont02 = 1;
                    missaoo02.GetComponent<missao02>().missao03();
                }
                if(gameObject.name == "missao03")
                {
                    missaoo02.GetComponent<missao03>().missao();
                }

                if (gameObject.name == "missao033")
                {
                    cont02 = 1;
                    missaoo02.GetComponent<missao04>().tarefa01();
                }

                if (gameObject.name == "missao022")
                {
                    cont02 = 1;
                    missaoo02.GetComponent<missao04>().tarefa02();
                }

                if (gameObject.name == "missao0223")
                {
                    cont02 = 1;
                    fugir.GetComponent<Animator>().SetBool("deuRuin", true);
                    missaoo02.GetComponent<missao05>().tafera01();
                }

            }
        }
    }


    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            cont = 1;
        }
    }






}
