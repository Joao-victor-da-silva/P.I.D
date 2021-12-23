using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityStandardAssets.Characters.FirstPerson;

public class acabouTempo : MonoBehaviour
{
    public bool acabou, voltou;
    int cont, cont02, int03;
    int  minutoAntigo;

    [SerializeField]
    int minutoss, conta;

    [SerializeField]
    GameObject time, inimigo, ponto, ponto02;
    [SerializeField]
    float tempinho;
    [SerializeField]
    string comodo;
    [SerializeField]
    Transform[] pontos;
    
   public GameObject inimigos, inimigoVei;

    [SerializeField]
    AudioSource somRespirando;
    [SerializeField]
    AudioClip som;


    float tempoVolume;
    bool mudou;


    [SerializeField]
    Color red;

    [SerializeField]
    GameObject[] comodoss;

    


    // Start is called before the first frame update
    void Start()
    {
        comodoss = new GameObject[11];
        comodoss[0] = GameObject.Find("sala");
        comodoss[1] = GameObject.Find("quarto");
        comodoss[2] = GameObject.Find("cosinha");
        comodoss[3] = GameObject.Find("lavanderia");
        comodoss[4] = GameObject.Find("banheiro");
        comodoss[5] = GameObject.Find("corredor");
        comodoss[6] = GameObject.Find("escritorio");
        comodoss[7] = GameObject.Find("biblioteca");
        comodoss[8] = GameObject.Find("banheiro02");
        comodoss[9] = GameObject.Find("porao");
        comodoss[10] = GameObject.Find("sotao");
        minutoss = 15;
        conta = 0;
        mudou = false;
        acabou = false;
        voltou = false;
        time.GetComponent<Text>().text = "" + minutoss + " : " + conta;
        desativarComodos();
    }

    // Update is called once per frame
    void Update()
    {
        respiracao();
        sanidade();
        testando();
        minutos();
        muda();
        if (cont02 == 0)
        {
            cont02 = 1;
            StartCoroutine(contagem());
        }
        //fimTempo();
        if (acabou == true && cont == 0)
        {
            StartCoroutine(tempo());
            cont = 1;
        }



    }

    private IEnumerator tempo()
    {

        yield return new WaitForSeconds(2f);
        acabou = false;
    }


    private void fimTempo()
    {

        tempinho = (tempinho += Time.deltaTime);
        time.GetComponent<Text>().text = tempinho.ToString("F0");

    }



    private IEnumerator contagem()
    {
         
        yield return new WaitForSeconds(1f);
        if(voltou == false)
        {
            if (conta != 0)
            {
                conta--;
            }
           
        }
        
        time.GetComponent<Text>().text = "" + minutoss + " : " + conta;
        if(voltou == false && int03 == 0)
        {
            StartCoroutine(contagem());
        }
            
        

    }

    private void testando()
    {
        if(minutoss == 0 && conta == 0 && int03 == 0)
        {

            ativarComodos();

            if (int03 == 0 && ponto != null)
            {
                int03 = 1;                
                acabou = true;
                Instantiate(inimigo, ponto.transform.position, ponto.transform.rotation);
                inimigos = GameObject.FindGameObjectWithTag("inimigo");
                inimigoVei = GameObject.Find("samantaveia(Clone)");
                GetComponent<FirstPersonController>().m_RunSpeed = 0.5f;
                GetComponent<FirstPersonController>().m_WalkSpeed = 0.5f;
                ponto02 = ponto.gameObject;
            }
           
        }
    }

    private void desativarComodos()
    {
        if (comodoss[0] != null)
        {
            comodoss[0].SetActive(false);
        }
        if (comodoss[1] != null)
        {
            comodoss[1].SetActive(false);
        }
        if (comodoss[2] != null)
        {
            comodoss[2].SetActive(false);
        }
        if (comodoss[3] != null)
        {
            comodoss[3].SetActive(false);
        }
        if (comodoss[4] != null)
        {
            comodoss[4].SetActive(false);
        }
        if (comodoss[5] != null)
        {
            comodoss[5].SetActive(false);
        }
        if (comodoss[6] != null)
        {
            comodoss[6].SetActive(false);
        }
        if (comodoss[7] != null)
        {
            comodoss[7].SetActive(false);
        }
        if (comodoss[8] != null)
        {
            comodoss[8].SetActive(false);
        }
        if (comodoss[9] != null)
        {
            comodoss[9].SetActive(false);
        }
        if (comodoss[10] != null)
        {
            comodoss[10].SetActive(false);
        }
    }

    private void ativarComodos()
    {
        if (comodoss[0] != null)
        {
            comodoss[0].SetActive(true);
        }
        if (comodoss[1] != null)
        {
            comodoss[1].SetActive(true);
        }
        if (comodoss[2] != null)
        {
            comodoss[2].SetActive(true);
        }
        if (comodoss[3] != null)
        {
            comodoss[3].SetActive(true);
        }
        if (comodoss[4] != null)
        {
            comodoss[4].SetActive(true);
        }
        if (comodoss[5] != null)
        {
            comodoss[5].SetActive(true);
        }
        if (comodoss[6] != null)
        {
            comodoss[6].SetActive(true);
        }
        if (comodoss[7] != null)
        {
            comodoss[7].SetActive(true);
        }
        if (comodoss[8] != null)
        {
            comodoss[8].SetActive(true);
        }
        if (comodoss[9] != null)
        {
            comodoss[9].SetActive(true);
        }
        if (comodoss[10] != null)
        {
            comodoss[10].SetActive(true);
        }
    }

    /*
    private void minutos()
    {
        if (conta == 59)
        {
            conta = -1;
            minutoss++;
        }
    }
    */

    private void minutos()
    {
        if (conta == 0)
        {
            if(minutoss != 0 && minutoss > 0)
            {
                conta = 59;
            }
           if(minutoss != 0)
            {
                minutoss--;
            }
            if (minutoss <= 4)
            {
                minutoAntigo++;
            }
        }
    }



    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "comodos")
        {
            if(other.name == "sala")
            {
                comodo = "sala";
            }
            if (other.name == "quarto")
            {
                comodo = "quarto";
            }
            if (other.name == "cosinha")
            {
                comodo = "cosinha";
            }
            if (other.name == "lavanderia")
            {
                comodo = "lavanderia";
            }
            if (other.name == "banheiro")
            {
                comodo = "banheiro";
            }
            if (other.name == "corredor")
            {
                comodo = "corredor";
            }
            if (other.name == "escritorio")
            {
                comodo = "escritorio";
            }
            if (other.name == "biblioteca")
            {
                comodo = "biblioteca";
            }
            if (other.name == "banheiro02")
            {
                comodo = "banheiro02";
            }
            if (other.name == "porao")
            {
                comodo = "porao";
            }
            if (other.name == "sotao")
            {
                comodo = "sotao";
            }

        }

        
    }
    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "comodos")
        {
            if (other.name == "sala")
            {
                comodo = "sala";
            }
            if (other.name == "quarto")
            {
                comodo = "quarto";
            }
            if (other.name == "cosinha")
            {
                comodo = "cosinha";
            }
            if (other.name == "lavanderia")
            {
                comodo = "lavanderia";
            }
            if (other.name == "banheiro")
            {
                comodo = "banheiro";
            }
            if (other.name == "corredor")
            {
                comodo = "corredor";
            }
            if (other.name == "escritorio")
            {
                comodo = "escritorio";
            }
            if (other.name == "biblioteca")
            {
                comodo = "biblioteca";
            }
            if (other.name == "banheiro02")
            {
                comodo = "banheiro02";
            }
            if (other.name == "porao")
            {
                comodo = "porao";
            }
            if (other.name == "sotao")
            {
                comodo = "sotao";
            }

        }

    }

 
    private void muda()
    {
        if(comodo == "quarto")
        {
            ponto = pontos[0].gameObject;
            if (int03 == 1)
            {
                if (ponto02.name != ponto.name)
                {
                    inimigos.transform.position = pontos[0].position;
                    ponto02 = ponto;
                    print("oi");
                }
            }
        }
        if(comodo == "sala")
        {
            ponto = pontos[1].gameObject;
            if (int03 == 1)
            {
                if (ponto02.name != ponto.name)
                {
                    inimigos.transform.position = pontos[1].position;
                    ponto02 = ponto;
                    print("oi1");
                }
            }
        }
        if (comodo == "cosinha")
        {
            ponto = pontos[2].gameObject;
            if (int03 == 1)
            {
                if (ponto02.name != ponto.name)
                {
                    inimigos.transform.position = pontos[2].position;
                    ponto02 = ponto;
                    print("oi2");
                }
            }
        }
        if (comodo == "lavanderia")
        {
            ponto = pontos[3].gameObject;
            if (int03 == 1)
            {
                if (ponto02.name != ponto.name)
                {
                    inimigos.transform.position = pontos[3].position;
                    ponto02 = ponto;
                    print("oi3");
                }
            }
        }
        if (comodo == "banheiro")
        {
            ponto = pontos[4].gameObject;
            if (int03 == 1)
            {
                if (ponto02.name != ponto.name)
                {
                    inimigos.transform.position = pontos[4].position;
                    ponto02 = ponto;
                    print("oi4");
                }
            }
        }
        if (comodo == "corredor")
        {
            ponto = pontos[5].gameObject;
            if (int03 == 1)
            {
                if (ponto02.name != ponto.name)
                {
                    inimigos.transform.position = pontos[5].position;
                    ponto02 = ponto;
                    print("oi5");
                }
            }
        }
        if (comodo == "escritorio")
        {
            ponto = pontos[6].gameObject;
            if (int03 == 1)
            {
                if (ponto02.name != ponto.name)
                {
                    inimigos.transform.position = pontos[6].position;
                    ponto02 = ponto;
                    print("oi6");
                }
            }
        }
        if (comodo == "biblioteca")
        {
            ponto = pontos[7].gameObject;
            if (int03 == 1)
            {
                if (ponto02.name != ponto.name)
                {
                    inimigos.transform.position = pontos[7].position;
                    ponto02 = ponto;
                    print("oi7");
                }
            }
        }
        if (comodo == "banheiro02")
        {
            ponto = pontos[8].gameObject;
            if (int03 == 1)
            {
                if (ponto02.name != ponto.name)
                {
                    inimigos.transform.position = pontos[8].position;
                    ponto02 = ponto;
                    print("oi8");
                }
            }
        }
        if (comodo == "porao")
        {
            ponto = pontos[9].gameObject;
            if (int03 == 1)
            {
                if (ponto02.name != ponto.name)
                {
                    inimigos.transform.position = pontos[9].position;
                    ponto02 = ponto;
                    print("oi9");
                }
            }
        }
        if (comodo == "sotao")
        {
            ponto = pontos[10].gameObject;
            if (int03 == 1)
            {
                if (ponto02.name != ponto.name)
                {
                    inimigos.transform.position = pontos[10].position;
                    ponto02 = ponto;
                    print("oi9");
                }
            }
        }


    }


    private void sanidade()
    {
        if(voltou == true)
        {
            acabou = false;
            somRespirando.Stop();
            time.SetActive(false);
            if (inimigos != null)
            {
                Destroy(inimigos);
                Destroy(inimigoVei);
                GetComponent<FirstPersonController>().m_RunSpeed = 4f;
                GetComponent<FirstPersonController>().m_WalkSpeed = 3f;
                somRespirando.Stop();
                desativarComodos();
            }
            
        }
    }


    private void respiracao()
    {

       
       
        
        if(minutoss <= 4)
        {
            
            tempoVolume = (float)minutoAntigo / 5f;
            time.GetComponent<Text>().color = red;
          
        }
        somRespirando.clip = som;
        somRespirando.volume = tempoVolume;
        if (mudou == false)
        {
            mudou = true;
            somRespirando.Play();
        }

    }


}
