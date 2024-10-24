using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ej8_charapter : MonoBehaviour
{
    public delegate void charapter();
    public event charapter OnScoreUpdate;
    public event charapter OnGameOver;
    public event charapter OnWin;
    public int score;

    // Start is called before the first frame update
    void Start()
    {
        score = -10;
    }

    void OnCollisionEnter(Collision colision) {
        GameObject objectColision = colision.gameObject;

        if (objectColision.tag == "plataforma" || objectColision.tag == "salida") {
            if (OnScoreUpdate != null) {
                OnScoreUpdate();
                score += 10;
            }
        } else if (objectColision.tag == "plano") {
            if (OnGameOver != null) {
                OnGameOver();
            }
        } else if (objectColision.tag == "meta") {
            if (OnWin != null) {
                OnWin();
            }
        }
    }
}
