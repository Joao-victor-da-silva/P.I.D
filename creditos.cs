using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class creditos : MonoBehaviour
{

    public bool nova;
    public string cena;
    [SerializeField]
    bool DEMO;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(nova == true || Input.GetKeyDown(KeyCode.Space))
        {
            if(DEMO == false)
            {
                SceneManager.LoadScene(cena);
            }
            else if(DEMO == true)
            {
                SceneManager.LoadScene("menuDemo");
            }
        }
    }
}
