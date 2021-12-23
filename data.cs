using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class data : MonoBehaviour
{
    [SerializeField]
    public Text[] diario, diario02, diario03, diario04;
    // Start is called before the first frame update
    public bool novaCena, capitulo02, capitulo03, capitulo04, capitulo05, capitulo06;
    int cont;
    int capilutlo02, capilutlo03, capilutlo04, capilutlo05, capilutlo06;

    [SerializeField]
    public bool DEMO;

    void Start()
    {
        diario = new Text[24];
        diario02 = new Text[24];
        diario03 = new Text[24];
        diario04 = new Text[24];
        if (DEMO == false)
        {
            capilutlo02 = PlayerPrefs.GetInt("segundoCapitulo");
            capilutlo03 = PlayerPrefs.GetInt("terceiroCapitulo");
            capilutlo04 = PlayerPrefs.GetInt("quartoCapitulo");
            capilutlo05 = PlayerPrefs.GetInt("quintoCapitulo");
            capilutlo06 = PlayerPrefs.GetInt("final");
        }
        
        if (capilutlo02 == 1)
        {
            capitulo02 = true;
        }
        if (capilutlo03 == 1)
        {
            capitulo03 = true;
        }
        if (capilutlo04 == 1)
        {
            capitulo04 = true;
        }
        if(capilutlo05 == 1)
        {
            capitulo05 = true;
        }
        if (capilutlo06 == 1)
        {
            capitulo06 = true;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(cont == 0)
        {
            cont = 1;
            DontDestroyOnLoad(transform.root.gameObject);
            print("iae?");
        }
        if (capitulo02 == true && capilutlo02 == 0)
        {
            capilutlo02 = 1;
            PlayerPrefs.SetInt("segundoCapitulo", capilutlo02);
        }
        if(capitulo03 == true && capilutlo03 == 0)
        {
            capilutlo03 = 1;
            PlayerPrefs.SetInt("terceiroCapitulo", capilutlo03);
        }
        if (capitulo04 == true && capilutlo04 == 0)
        {
            capilutlo04 = 1;
            PlayerPrefs.SetInt("quartoCapitulo", capilutlo04);
        }
        if(capitulo05 == true && capilutlo05 == 0)
        {
            capilutlo05 = 1;
            PlayerPrefs.SetInt("quintoCapitulo", capilutlo05);
        }
        if (capitulo06 == true && capilutlo06 == 0)
        {
            capilutlo06 = 1;
            PlayerPrefs.SetInt("final", capilutlo06);
        }





    }





    //
    public void guardar()
    {
        PlayerPrefs.SetString("linha01D1", diario[0].text);
        PlayerPrefs.SetString("linha02D1", diario[1].text);
        PlayerPrefs.SetString("linha03D1", diario[2].text);
        PlayerPrefs.SetString("linha04D1", diario[3].text);
        PlayerPrefs.SetString("linha05D1", diario[4].text);
        PlayerPrefs.SetString("linha06D1", diario[5].text);
        PlayerPrefs.SetString("linha07D1", diario[6].text);
        PlayerPrefs.SetString("linha08D1", diario[7].text);
        PlayerPrefs.SetString("linha09D1", diario[8].text);
        PlayerPrefs.SetString("linha10D1", diario[9].text);
        PlayerPrefs.SetString("linha11D1", diario[10].text);
        PlayerPrefs.SetString("linha12D1", diario[11].text);
        PlayerPrefs.SetString("linha13D1", diario[12].text);
        PlayerPrefs.SetString("linha14D1", diario[13].text);
        PlayerPrefs.SetString("linha15D1", diario[14].text);
        PlayerPrefs.SetString("linha16D1", diario[15].text);
        PlayerPrefs.SetString("linha17D1", diario[16].text);
        PlayerPrefs.SetString("linha18D1", diario[17].text);
        PlayerPrefs.SetString("linha19D1", diario[18].text);
        PlayerPrefs.SetString("linha20D1", diario[19].text);
        PlayerPrefs.SetString("linha21D1", diario[20].text);
        PlayerPrefs.SetString("linha22D1", diario[21].text);
        PlayerPrefs.SetString("linha23D1", diario[22].text);
        PlayerPrefs.SetString("linha24D1", diario[23].text);
        PlayerPrefs.Save();
    }


    public void Pegar()
    {
        diario[0].text = PlayerPrefs.GetString("linha01D1");
        diario[1].text = PlayerPrefs.GetString("linha02D1");
        diario[2].text = PlayerPrefs.GetString("linha03D1");
        diario[3].text = PlayerPrefs.GetString("linha04D1");
        diario[4].text = PlayerPrefs.GetString("linha05D1");
        diario[5].text = PlayerPrefs.GetString("linha06D1");
        diario[6].text = PlayerPrefs.GetString("linha07D1");
        diario[7].text = PlayerPrefs.GetString("linha08D1");
        diario[8].text = PlayerPrefs.GetString("linha09D1");
        diario[9].text = PlayerPrefs.GetString("linha10D1");
        diario[10].text = PlayerPrefs.GetString("linha11D1");
        diario[11].text = PlayerPrefs.GetString("linha12D1");
        diario[12].text = PlayerPrefs.GetString("linha13D1");
        diario[13].text = PlayerPrefs.GetString("linha14D1");
        diario[14].text = PlayerPrefs.GetString("linha15D1");
        diario[15].text = PlayerPrefs.GetString("linha16D1");
        diario[16].text = PlayerPrefs.GetString("linha17D1");
        diario[17].text = PlayerPrefs.GetString("linha18D1");
        diario[18].text = PlayerPrefs.GetString("linha19D1");
        diario[19].text = PlayerPrefs.GetString("linha20D1");
        diario[20].text = PlayerPrefs.GetString("linha21D1");
        diario[21].text = PlayerPrefs.GetString("linha22D1");
        diario[22].text = PlayerPrefs.GetString("linha23D1");
        diario[23].text = PlayerPrefs.GetString("linha24D1");
    }

    public void guardar02()
    {
        PlayerPrefs.SetString("linha01D2", diario02[0].text);
        PlayerPrefs.SetString("linha02D2", diario02[1].text);
        PlayerPrefs.SetString("linha03D2", diario02[2].text);
        PlayerPrefs.SetString("linha04D2", diario02[3].text);
        PlayerPrefs.SetString("linha05D2", diario02[4].text);
        PlayerPrefs.SetString("linha06D2", diario02[5].text);
        PlayerPrefs.SetString("linha07D2", diario02[6].text);
        PlayerPrefs.SetString("linha08D2", diario02[7].text);
        PlayerPrefs.SetString("linha09D2", diario02[8].text);
        PlayerPrefs.SetString("linha10D2", diario02[9].text);
        PlayerPrefs.SetString("linha11D2", diario02[10].text);
        PlayerPrefs.SetString("linha12D2", diario02[11].text);
        PlayerPrefs.SetString("linha13D2", diario02[12].text);
        PlayerPrefs.SetString("linha14D2", diario02[13].text);
        PlayerPrefs.SetString("linha15D2", diario02[14].text);
        PlayerPrefs.SetString("linha16D2", diario02[15].text);
        PlayerPrefs.SetString("linha17D2", diario02[16].text);
        PlayerPrefs.SetString("linha18D2", diario02[17].text);
        PlayerPrefs.SetString("linha19D2", diario02[18].text);
        PlayerPrefs.SetString("linha20D2", diario02[19].text);
        PlayerPrefs.SetString("linha21D2", diario02[20].text);
        PlayerPrefs.SetString("linha22D2", diario02[21].text);
        PlayerPrefs.SetString("linha23D2", diario02[22].text);
        PlayerPrefs.SetString("linha24D2", diario02[23].text);
        PlayerPrefs.Save();
    }


    public void Pegar02()
    {
        diario02[0].text = PlayerPrefs.GetString("linha01D2");
        diario02[1].text = PlayerPrefs.GetString("linha02D2");
        diario02[2].text = PlayerPrefs.GetString("linha03D2");
        diario02[3].text = PlayerPrefs.GetString("linha04D2");
        diario02[4].text = PlayerPrefs.GetString("linha05D2");
        diario02[5].text = PlayerPrefs.GetString("linha06D2");
        diario02[6].text = PlayerPrefs.GetString("linha07D2");
        diario02[7].text = PlayerPrefs.GetString("linha08D2");
        diario02[8].text = PlayerPrefs.GetString("linha09D2");
        diario02[9].text = PlayerPrefs.GetString("linha10D2");
        diario02[10].text = PlayerPrefs.GetString("linha11D2");
        diario02[11].text = PlayerPrefs.GetString("linha12D2");
        diario02[12].text = PlayerPrefs.GetString("linha13D2");
        diario02[13].text = PlayerPrefs.GetString("linha14D2");
        diario02[14].text = PlayerPrefs.GetString("linha15D2");
        diario02[15].text = PlayerPrefs.GetString("linha16D2");
        diario02[16].text = PlayerPrefs.GetString("linha17D2");
        diario02[17].text = PlayerPrefs.GetString("linha18D2");
        diario02[18].text = PlayerPrefs.GetString("linha19D2");
        diario02[19].text = PlayerPrefs.GetString("linha20D2");
        diario02[20].text = PlayerPrefs.GetString("linha21D2");
        diario02[21].text = PlayerPrefs.GetString("linha22D2");
        diario02[22].text = PlayerPrefs.GetString("linha23D2");
        diario02[23].text = PlayerPrefs.GetString("linha24D2");
    }


    public void guardar03()
    {
        PlayerPrefs.SetString("linha01D3", diario03[0].text);
        PlayerPrefs.SetString("linha02D3", diario03[1].text);
        PlayerPrefs.SetString("linha03D3", diario03[2].text);
        PlayerPrefs.SetString("linha04D3", diario03[3].text);
        PlayerPrefs.SetString("linha05D3", diario03[4].text);
        PlayerPrefs.SetString("linha06D3", diario03[5].text);
        PlayerPrefs.SetString("linha07D3", diario03[6].text);
        PlayerPrefs.SetString("linha08D3", diario03[7].text);
        PlayerPrefs.SetString("linha09D3", diario03[8].text);
        PlayerPrefs.SetString("linha10D3", diario03[9].text);
        PlayerPrefs.SetString("linha11D3", diario03[10].text);
        PlayerPrefs.SetString("linha12D3", diario03[11].text);
        PlayerPrefs.SetString("linha13D3", diario03[12].text);
        PlayerPrefs.SetString("linha14D3", diario03[13].text);
        PlayerPrefs.SetString("linha15D3", diario03[14].text);
        PlayerPrefs.SetString("linha16D3", diario03[15].text);
        PlayerPrefs.SetString("linha17D3", diario03[16].text);
        PlayerPrefs.SetString("linha18D3", diario03[17].text);
        PlayerPrefs.SetString("linha19D3", diario03[18].text);
        PlayerPrefs.SetString("linha20D3", diario03[19].text);
        PlayerPrefs.SetString("linha21D3", diario03[20].text);
        PlayerPrefs.SetString("linha22D3", diario03[21].text);
        PlayerPrefs.SetString("linha23D3", diario03[22].text);
        PlayerPrefs.SetString("linha24D3", diario03[23].text);
        PlayerPrefs.Save();
    }


    public void Pegar03()
    {
        diario03[0].text = PlayerPrefs.GetString("linha01D3");
        diario03[1].text = PlayerPrefs.GetString("linha02D3");
        diario03[2].text = PlayerPrefs.GetString("linha03D3");
        diario03[3].text = PlayerPrefs.GetString("linha04D3");
        diario03[4].text = PlayerPrefs.GetString("linha05D3");
        diario03[5].text = PlayerPrefs.GetString("linha06D3");
        diario03[6].text = PlayerPrefs.GetString("linha07D3");
        diario03[7].text = PlayerPrefs.GetString("linha08D3");
        diario03[8].text = PlayerPrefs.GetString("linha09D3");
        diario03[9].text = PlayerPrefs.GetString("linha10D3");
        diario03[10].text = PlayerPrefs.GetString("linha11D3");
        diario03[11].text = PlayerPrefs.GetString("linha12D3");
        diario03[12].text = PlayerPrefs.GetString("linha13D3");
        diario03[13].text = PlayerPrefs.GetString("linha14D3");
        diario03[14].text = PlayerPrefs.GetString("linha15D3");
        diario03[15].text = PlayerPrefs.GetString("linha16D3");
        diario03[16].text = PlayerPrefs.GetString("linha17D3");
        diario03[17].text = PlayerPrefs.GetString("linha18D3");
        diario03[18].text = PlayerPrefs.GetString("linha19D3");
        diario03[19].text = PlayerPrefs.GetString("linha20D3");
        diario03[20].text = PlayerPrefs.GetString("linha21D3");
        diario03[21].text = PlayerPrefs.GetString("linha22D3");
        diario03[22].text = PlayerPrefs.GetString("linha23D3");
        diario03[23].text = PlayerPrefs.GetString("linha24D3");
    }


    public void guardar04()
    {
        PlayerPrefs.SetString("linha01D4", diario04[0].text);
        PlayerPrefs.SetString("linha02D4", diario04[1].text);
        PlayerPrefs.SetString("linha03D4", diario04[2].text);
        PlayerPrefs.SetString("linha04D4", diario04[3].text);
        PlayerPrefs.SetString("linha05D4", diario04[4].text);
        PlayerPrefs.SetString("linha06D4", diario04[5].text);
        PlayerPrefs.SetString("linha07D4", diario04[6].text);
        PlayerPrefs.SetString("linha08D4", diario04[7].text);
        PlayerPrefs.SetString("linha09D4", diario04[8].text);
        PlayerPrefs.SetString("linha10D4", diario04[9].text);
        PlayerPrefs.SetString("linha11D4", diario04[10].text);
        PlayerPrefs.SetString("linha12D4", diario04[11].text);
        PlayerPrefs.SetString("linha13D4", diario04[12].text);
        PlayerPrefs.SetString("linha14D4", diario04[13].text);
        PlayerPrefs.SetString("linha15D4", diario04[14].text);
        PlayerPrefs.SetString("linha16D4", diario04[15].text);
        PlayerPrefs.SetString("linha17D4", diario04[16].text);
        PlayerPrefs.SetString("linha18D4", diario04[17].text);
        PlayerPrefs.SetString("linha19D4", diario04[18].text);
        PlayerPrefs.SetString("linha20D4", diario04[19].text);
        PlayerPrefs.SetString("linha21D4", diario04[20].text);
        PlayerPrefs.SetString("linha22D4", diario04[21].text);
        PlayerPrefs.SetString("linha23D4", diario04[22].text);
        PlayerPrefs.SetString("linha24D4", diario04[23].text);
        PlayerPrefs.Save();
    }


    public void Pegar04()
    {
        diario04[0].text = PlayerPrefs.GetString("linha01D4");
        diario04[1].text = PlayerPrefs.GetString("linha02D4");
        diario04[2].text = PlayerPrefs.GetString("linha03D4");
        diario04[3].text = PlayerPrefs.GetString("linha04D4");
        diario04[4].text = PlayerPrefs.GetString("linha05D4");
        diario04[5].text = PlayerPrefs.GetString("linha06D4");
        diario04[6].text = PlayerPrefs.GetString("linha07D4");
        diario04[7].text = PlayerPrefs.GetString("linha08D4");
        diario04[8].text = PlayerPrefs.GetString("linha09D4");
        diario04[9].text = PlayerPrefs.GetString("linha10D4");
        diario04[10].text = PlayerPrefs.GetString("linha11D4");
        diario04[11].text = PlayerPrefs.GetString("linha12D4");
        diario04[12].text = PlayerPrefs.GetString("linha13D4");
        diario04[13].text = PlayerPrefs.GetString("linha14D4");
        diario04[14].text = PlayerPrefs.GetString("linha15D4");
        diario04[15].text = PlayerPrefs.GetString("linha16D4");
        diario04[16].text = PlayerPrefs.GetString("linha17D4");
        diario04[17].text = PlayerPrefs.GetString("linha18D4");
        diario04[18].text = PlayerPrefs.GetString("linha19D4");
        diario04[19].text = PlayerPrefs.GetString("linha20D4");
        diario04[20].text = PlayerPrefs.GetString("linha21D4");
        diario04[21].text = PlayerPrefs.GetString("linha22D4");
        diario04[22].text = PlayerPrefs.GetString("linha23D4");
        diario04[23].text = PlayerPrefs.GetString("linha24D4");
    }


    public void voltarcena()
    {
        novaCena = true;
    }
    public void liberarCapitulo02()
    {
        capitulo02 = true;
    }

    public void liberarCapitulo03()
    {
        capitulo03 = true;
    }

    public void liberarCapitulo04()
    {
        capitulo04 = true;
    }


}
