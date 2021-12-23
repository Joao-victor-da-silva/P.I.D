using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cenariZombie : MonoBehaviour
{
    [SerializeField]
    float tempo, ygard, velocidade;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        transform.Translate(0, 0, velocidade * Time.deltaTime);

        if(transform.position.z < -34.9f)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, ygard);
        }


    }





    

}
