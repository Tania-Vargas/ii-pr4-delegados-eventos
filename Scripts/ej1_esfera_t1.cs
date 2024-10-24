using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ej1_esfera_t1 : MonoBehaviour
{
    private ej1_notificador notificador;
    private Rigidbody cilindro;
    private Rigidbody miRb;
    private float speed = 3f;
    private bool moveToCilinder = false;
    private float minDistance = 1.5f;

    // Start is called before the first frame update
    void Start()
    {
        GameObject objCilindro = GameObject.FindWithTag("cilindro");

        cilindro = objCilindro.GetComponent<Rigidbody>();    
        notificador = objCilindro.GetComponent<ej1_notificador>();

        miRb = GetComponent<Rigidbody>();

        notificador.OnChoqueCilindro += miRespuesta;
    }

    void FixedUpdate() {
        if (moveToCilinder) {
            Vector3 moveDirection = (cilindro.position - miRb.position).normalized;

            float distance = Vector3.Distance(miRb.position, cilindro.position);
            
            if (distance > minDistance) {
                miRb.MovePosition(miRb.position + moveDirection * speed * Time.deltaTime);
            } 
            else {
                moveToCilinder = false;
            }
        }
    }

    void miRespuesta() {
        moveToCilinder = true;
    }
}
