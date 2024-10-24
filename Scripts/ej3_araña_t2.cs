using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ej3_araña_t2 : MonoBehaviour
{
    public delegate void impacto();
    public event impacto OnChoqueArañaT2;

    public Material miMaterial;
    private SkinnedMeshRenderer spiderChildRd;

    private ej3_huevo_t2 notificadorH2;

    // Start is called before the first frame update
    void Start()
    {
        // Notificacion para impacto con huevo
        GameObject huevoT2 = GameObject.FindWithTag("egg_t2");
        notificadorH2 = huevoT2.GetComponent<ej3_huevo_t2>();
        notificadorH2.OnChoqueHuevoT2A2 += respuestaChoqueHuevo2;

        // Cambio de color si choca con huevo 2
        Transform spiderChildTr = transform.Find("Spider_Fuga_Red");
        if (spiderChildTr != null) {
            spiderChildRd = spiderChildTr.GetComponent<SkinnedMeshRenderer>();
        }
    }

    void OnCollisionEnter(Collision colision) {
        GameObject objectColision = colision.gameObject;

        if (objectColision.tag == "cubo") {
            if (OnChoqueArañaT2 != null) {
                OnChoqueArañaT2();
            }
            else {
                Debug.LogWarning("No hay suscriptores para el evento OnChoqueArañaT2");
            }
        }
    }

    void respuestaChoqueHuevo2() {
        // Cambio de color
        if (spiderChildRd != null) {
            spiderChildRd.material = miMaterial;
        }
    }
}
