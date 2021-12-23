using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cursorMenu : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        //transform.position = Input.mousePosition + new Vector3(160,-170,0);
        transform.position = Input.mousePosition;

    }
}
