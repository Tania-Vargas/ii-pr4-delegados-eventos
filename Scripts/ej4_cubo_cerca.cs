using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ej4_cubo_cerca : MonoBehaviour
{
    public delegate void impacto();
    public event impacto OnCuboCerca;
    // Start is called before the first frame update
    void OnTriggerEnter(Collider colision) {
        GameObject objectColision = colision.gameObject;

        if (objectColision.tag == "cubo") {
            if (OnCuboCerca != null) {
                OnCuboCerca();
            } 
            else {
                Debug.LogWarning("No hay suscriptores para el evento OnCuboCerca");
            }
        }
    }
}
