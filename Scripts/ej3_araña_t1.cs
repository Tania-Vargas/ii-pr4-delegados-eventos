using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ej3_araña_t1 : MonoBehaviour
{
    private bool correrAHuevoT2 = false;
    private bool correrAHuevoT1 = false;

    private Rigidbody miRb;
    private SkinnedMeshRenderer spiderChildRd;
    private Rigidbody huevoRb2;
    private Transform huevoTr1;
    private float minDistance = 1f;
    private float speed = 2f;
    private ej3_huevo_t2 notificadorH2;
    private ej3_araña_t2 notificadorA2;
    public Material miMaterial;

    // Start is called before the first frame update
    void Start()
    {
        // Elementos para interaccion con huvos
        GameObject huevoT2 = GameObject.FindWithTag("egg_t2"); 
        miRb = GetComponent<Rigidbody>();
        huevoRb2 = huevoT2.GetComponent<Rigidbody>();

        // Notificacion para impacto con huevo
        notificadorH2 = huevoT2.GetComponent<ej3_huevo_t2>();
        notificadorH2.OnChoqueHuevoT2A1 += respuestaChoqueHuevo2;

        // Accede al hijo para el cambio de color
        Transform spiderChildTr = transform.Find("Spider_Fuga_Blue_Green");
        if (spiderChildTr != null) {
            spiderChildRd = spiderChildTr.GetComponent<SkinnedMeshRenderer>();
        }

        // Para el desplazamineto cuando cubo choca con araña de tipo 2
        huevoTr1 = GameObject.FindWithTag("egg_t1").GetComponent<Transform>();
        notificadorA2 = GameObject.FindWithTag("spider_tipo2").GetComponent<ej3_araña_t2>();
        notificadorA2.OnChoqueArañaT2 += correHaciaHuevo1;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (correrAHuevoT2) { // Caso de cubo choque con esta araña (corre al huevo 2)
            // Tomo posicion de huevos tipo 2 y corro
            Vector3 moveDirection = (huevoRb2.position - miRb.position).normalized;
            float distance = Vector3.Distance(miRb.position, huevoRb2.position);

            if (distance > minDistance) {
                miRb.MovePosition(miRb.position + moveDirection * speed * Time.deltaTime);
            } 
            else {
                correrAHuevoT2 = false;
            }
        } else if (correrAHuevoT1) { // Caso de cubo choque con araña tipo 2 (corre al huevo 2)
            Vector3 moveDirection = (huevoTr1.position - miRb.position).normalized;
            float distance = Vector3.Distance(miRb.position, huevoTr1.position);

            if (distance > minDistance) {
                miRb.MovePosition(miRb.position + moveDirection * speed * Time.deltaTime);
            } 
            else {
                correrAHuevoT1 = false;
            }
        }
    }

    void OnCollisionEnter(Collision colision) {
        GameObject objectColision = colision.gameObject;

        if (objectColision.tag == "cubo") {
            correrAHuevoT2 = true;
        }
    }

    void respuestaChoqueHuevo2() {
        // Cambio de color
        if (spiderChildRd != null) {
            spiderChildRd.material = miMaterial;
        }
    }

    void correHaciaHuevo1() {
        correrAHuevoT1 = true;
    }
}
