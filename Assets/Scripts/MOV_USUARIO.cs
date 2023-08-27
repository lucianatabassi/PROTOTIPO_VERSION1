using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MOV_USUARIO : MonoBehaviour
{
    public CharacterController controller;

    public float vel = 10f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 mover = transform.right * x + transform.forward * z;

        controller.Move(mover * vel * Time.deltaTime);  
    }
}
