using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ej8_canvas : MonoBehaviour
{
    public ej8_charapter notificador;
    private Text scoreText;
    private Text gameText;

    // Start is called before the first frame update
    void Start()
    {
        GameObject charapter = GameObject.FindWithTag("personaje");
        if (charapter != null) {
            notificador = charapter.GetComponent<ej8_charapter>();
            notificador.OnScoreUpdate += updateScore;
            notificador.OnGameOver += updateGameOver;
            notificador.OnWin += updateWin;
        } else {
            Debug.Log("No encontrado");
        }

        scoreText = GetComponent<Text>();
        gameText = GetComponent<Text>();
    }

    void updateScore() {
        int newScore = notificador.score;
        scoreText.text = "Score " + newScore;
        scoreText.color = Color.white;
        scoreText.fontSize = 50;
        scoreText.gameObject.SetActive(true);
        Debug.Log(newScore);
    }

    void updateGameOver() {
        gameText.text = "Game Over";
        gameText.color = Color.red;
        gameText.fontSize = 50;
        gameText.alignment = TextAnchor.MiddleCenter; // centra texto
        gameText.gameObject.SetActive(true);

        //scoreText.gameObject.SetActive(false);
    }

    void updateWin() {
        int lastScore = notificador.score;

        //texto
        gameText.text = "You Win!";
        gameText.color = Color.green;
        gameText.fontSize = 50;
        gameText.alignment = TextAnchor.MiddleCenter; // centra texto
        gameText.gameObject.SetActive(true);
        
        // Mantén visible la puntuación al ganar
        scoreText.text = "Final Score: " + notificador.score;
        scoreText.fontSize = 30; // Reduce un poco el tamaño de la puntuación
        scoreText.alignment = TextAnchor.MiddleCenter;
        //scoreText.gameObject.SetActive(true);
    }
}
