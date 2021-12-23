using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class tutorialSesgundo : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{

    bool troca;
    public GameObject tutorial02;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(troca == true && Input.GetKeyDown(KeyCode.Mouse0))
        {
            tutorial02.GetComponent<tutorial>().troca02--;
        }
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        troca = true;

    }

    public void OnPointerExit(PointerEventData eventData)
    {
        troca = false;

    }

}
