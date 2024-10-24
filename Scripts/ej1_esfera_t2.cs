using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ej1_esfera_t2 : MonoBehaviour
{
    private ej1_notificador notificador;
    private Transform spheresTr;
    private Rigidbody miRb;
    private float speed = 3f;
    private bool moveToSpheres = false;
    private float minDistance = 1f;

    // Start is called before the first frame update
    void Start()
    {
        GameObject spheresType1 = GameObject.FindWithTag("vacio_tipo1");
        GameObject objCilindro = GameObject.FindWithTag("cilindro");

        miRb = GetComponent<Rigidbody>();
        spheresTr = spheresType1.GetComponent<Transform>();

        notificador = objCilindro.GetComponent<ej1_notificador>();
        notificador.OnChoqueCilindro += miRespuesta;
    }

    void FixedUpdate()
    {
        if (moveToSpheres) {
            Vector3 moveDirection = (spheresTr.position - miRb.position).normalized;

            float distance = Vector3.Distance(miRb.position, spheresTr.position);
            
            if (distance > minDistance) {
                miRb.MovePosition(miRb.position + moveDirection * speed * Time.deltaTime);
            } 
            else {
                moveToSpheres = false;
            }   
        }
    }

    void miRespuesta() {
        moveToSpheres = true;
    }
}
