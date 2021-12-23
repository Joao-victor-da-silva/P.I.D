using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;
using UnityStandardAssets.Characters.FirstPerson;

public class playerCamera : MonoBehaviour
{

    public GameObject player;
    bool trocar;
    public PlayableDirector inicial;

    // Start is called before the first frame update
    void Start()
    {
       // transform.position = new Vector3(0, 0.8f, 0); // aqui
       // transform.rotation = new Quaternion(0, 0, 0, 0);
        trocar = false;
        inicial = player.GetComponent<PlayableDirector>();
    }

    // Update is called once per frame
    void Update()
    {

        player.GetComponent<FirstPersonController>().controles = trocar;
       

        Invoke("trocando", (float)inicial.duration);
    }


    void trocando()
    {
        trocar = true;
    }

}
