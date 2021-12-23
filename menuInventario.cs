using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class menuInventario : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
   public  bool fechar;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
    }
    /*
    private void OnMouseEnter()
    {
        entrou = true;
    }

    private void OnMouseExit()
    {
        entrou = false;
    }

    private void OnMouseOver()
    {
        entrou = true;
    }
    */
    public void OnPointerEnter(PointerEventData eventData)
    {
        fechar = true;
       
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        fechar = false;
       
    }

}
