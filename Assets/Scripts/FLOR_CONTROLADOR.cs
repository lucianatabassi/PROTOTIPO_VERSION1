using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FLOR_CONTROLADOR : MonoBehaviour
{
    public GameObject flor;
    public Transform mano;

    private bool activo;

    
    void Update()
    {
        if (activo = true)
        {
            if(Input.GetKeyDown("mouse 0")) //agarra con boton izq del mouse
            {
                flor.transform.SetParent(mano); //que la flor sea hija de la mano
                flor.transform.position = mano.position;
                flor.GetComponent<Rigidbody>().isKinematic = true;
            }
        }


        if (Input.GetKeyDown("mouse 1")) //suelta con boton der del mouse
        {
            flor.transform.SetParent(null);
            flor.GetComponent<Rigidbody>().isKinematic = false;
        }
    }

    void OnTriggerEnter (Collider other) 
    { 
        if (other.tag == "Player")
        {
            activo = true;
            Debug.Log("aaa");
            
        }
    }

    void OnTriggerExit (Collider other)
    {
        if (other.tag == "Player")
        {
            activo = false;
        }
    }
}
