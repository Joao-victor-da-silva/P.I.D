using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class escotilha : MonoBehaviour
{
    [SerializeField]
    alavanca a1, a2;

    Animator anim;
    public bool abrir, fechar;


    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if(abrir != true)
        {
            if(a1 != null && a2 != null)
            {
                if (a1.ativado == true && a2.ativado == true)
                {
                    abrir = true;
                    fechar = false;
                }
            }
            
        }
        


        anim.SetBool("aberta", abrir);

        anim.SetBool("fechado", fechar);



    }
}
