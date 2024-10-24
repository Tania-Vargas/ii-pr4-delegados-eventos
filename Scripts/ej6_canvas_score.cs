using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ej6_canvas_score : MonoBehaviour
{
    public ej5_cubo_puntuacion notificaCubo;
    private Text text;
    private int recompensa;

    // Start is called before the first frame update
    void Start()
    {
        text = GetComponent<Text>();
        recompensa = 0;

        GameObject cubo = GameObject.FindWithTag("cubo");
        notificaCubo = cubo.GetComponent<ej5_cubo_puntuacion>();
        notificaCubo.OnUpdateScore += actualizaScore;
    }

    // Update is called once per frame
    void actualizaScore() {
        int newScore = notificaCubo.score;
        text.text = "Score " + newScore;

        while (newScore >= recompensa + 100) {
            recompensa += 100;
            text.text += "  + 100 Monedas";
        }
    }
}
