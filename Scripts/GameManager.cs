using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    /*--------------------------------------------------- SINGLETONS --------------------------------------------------- */
    private static GameManager instance;
    public static GameManager Instance
    {
        get
        {
            if (instance == null)
            {
                instance = FindObjectOfType<GameManager>();
            }
            return instance;
        }
    }
    /*------------------------------------------------------------------------------------------------------------------ */


    [SerializeField] public TMP_Text player1ScoreText;
    [SerializeField] public TMP_Text player2ScoreText;

    [SerializeField] private Transform ballTransform;

    public int player1Scored;
    public int player2Scored;

    public void Player1Scored() // Para aumentar la puntuación del jugador 1.
    {
        player1Scored++;
        player1ScoreText.text = player1Scored.ToString();
    }
    public void Player2Scored() // Para aumentar la puntuación del jugador 2.
    {
        player2Scored++;
        player2ScoreText.text = player2Scored.ToString();
    }

    public void Restart() // Para reiniciar la posición de la pelota.
    {
        ballTransform.position = new Vector2(0, 0);
    }

    public void GameRestart() // Para reiniciar el marcador.
    {
        player1Scored = player2Scored = 0;
        player1ScoreText.text = player1Scored.ToString();
        player2ScoreText.text = player2Scored.ToString();
        Restart();
        Time.timeScale = 1f;
    }
}
