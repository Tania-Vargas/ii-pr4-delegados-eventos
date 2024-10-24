using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ej5_cubo_move : MonoBehaviour
{
    Rigidbody rb;
    private float speed = 6f;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 moveDir = Vector3.zero;

        if (Input.GetKey(KeyCode.W)) {
            moveDir = Vector3.forward;
        } else if (Input.GetKey(KeyCode.S)) {
            moveDir = Vector3.back;
        } else if (Input.GetKey(KeyCode.A)) {
            moveDir = Vector3.left;
        } else if (Input.GetKey(KeyCode.D)) {
            moveDir = Vector3.right;
        }

        rb.AddForce(moveDir * speed);
    }
}
