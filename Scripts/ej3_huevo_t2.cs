using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ej3_huevo_t2 : MonoBehaviour
{
    public delegate void impacto();
    public event impacto OnChoqueHuevoT2A1;
    public event impacto OnChoqueHuevoT2A2;

    void OnCollisionEnter(Collision colision) {
        GameObject objectColision = colision.gameObject;

        if (objectColision.tag == "spider_tipo1") {
            if (OnChoqueHuevoT2A1 != null) {
                OnChoqueHuevoT2A1();
            }
            else {
                Debug.LogWarning("No hay suscriptores para el evento OnChoqueHuevoT2A1");
            }
        } else if (objectColision.tag == "spider_tipo2") {
            if (OnChoqueHuevoT2A2 != null) {
                OnChoqueHuevoT2A2();
            }
            else {
                Debug.LogWarning("No hay suscriptores para el evento OnChoqueHuevoT2A2");
            }
        }
    }
}
