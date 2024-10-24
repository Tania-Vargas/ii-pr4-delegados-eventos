using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ej1_notificador : MonoBehaviour
{
    public delegate void impacto();
    public event impacto OnChoqueCilindro;

    void OnCollisionEnter(Collision colision) {
        GameObject objectColision = colision.gameObject;

        if (objectColision.tag == "cubo") {
            if (OnChoqueCilindro != null) {
                OnChoqueCilindro();
            }
            else {
                Debug.LogWarning("No hay susciptores para el evecto OnChoqueCilindro");
            }
        }
    }
}
