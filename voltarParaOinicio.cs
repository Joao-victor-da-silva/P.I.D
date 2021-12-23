using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class voltarParaOinicio : MonoBehaviour
{
    
    void Start()
    {
        StartCoroutine(fim());
    }

    
    IEnumerator fim()
    {
        yield return new WaitForSeconds(10);
        SceneManager.LoadScene("menu");
    }

}
