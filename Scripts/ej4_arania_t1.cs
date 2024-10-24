using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ej4_arania_t1 : MonoBehaviour
{   
    private ej4_cubo_cerca notificadorCC;
    private Rigidbody miRb;
    private Rigidbody huevo2Rb;
    private bool teleport = false;

    // Start is called before the first frame update
    void Start()
    {
        miRb = GetComponent<Rigidbody>();
        huevo2Rb = GameObject.FindWithTag("egg_t2").GetComponent<Rigidbody>();

        GameObject cuboCerca = GameObject.FindWithTag("cubocerca");
        notificadorCC = cuboCerca.GetComponent<ej4_cubo_cerca>();
        notificadorCC.OnCuboCerca += respuestaTeleport;
    }

    void FixedUpdate() {
        if (teleport) {
            miRb.MovePosition(huevo2Rb.position);
        }
    }

    void respuestaTeleport() {
        teleport = true;
    }
}
