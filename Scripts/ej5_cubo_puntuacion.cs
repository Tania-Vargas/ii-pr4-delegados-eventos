using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ej5_cubo_puntuacion : MonoBehaviour
{
    public int score;
    public delegate void update(); //Ejercicio 6
    public event update OnUpdateScore; //Ejercicio 6

    // Start is called before the first frame update
    void Start()
    {
        score = 0;
    }

    void OnCollisionEnter(Collision colision) {
        GameObject objectColision = colision.gameObject;

        if (objectColision.tag == "spider_tipo1") {
            score = score + 5;
            Debug.Log("Score: " + score);
            //Ejercicio 6
            if (OnUpdateScore != null) {
                OnUpdateScore();
            }
        } 
        else if (objectColision.tag == "spider_tipo2") {
            score = score + 10;
            Debug.Log("Score: " + score);
            if (OnUpdateScore != null) {
                OnUpdateScore();
            }
        }
    }
}
