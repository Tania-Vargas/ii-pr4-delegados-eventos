using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ej4_arania_t2 : MonoBehaviour
{
    private ej4_cubo_cerca notificadorCC;
    private Transform miTr;
    private Rigidbody huevo2Rb;
    private bool rotate = false;
    private float speed = 10f;

    // Start is called before the first frame update
    void Start()
    {
        miTr = GetComponent<Transform>();
        huevo2Rb = GameObject.FindWithTag("egg_t2").GetComponent<Rigidbody>();

        GameObject cuboCerca = GameObject.FindWithTag("cubocerca");
        notificadorCC = cuboCerca.GetComponent<ej4_cubo_cerca>();
        notificadorCC.OnCuboCerca += respuestaRotate;
    }

    // Update is called once per frame
    void FixedUpdate() {
        if (rotate) {
            Vector3 rotateDirection = (huevo2Rb.position - miTr.position).normalized;
        
            if (rotateDirection != Vector3.zero) {
                Quaternion targetRotation = Quaternion.LookRotation(rotateDirection);
                // Slerp para una rotación más suave
                miTr.rotation = Quaternion.Slerp(miTr.rotation, targetRotation, speed * Time.deltaTime);
        }
        }
    }
    void respuestaRotate() {
        rotate = true;
    }
}
