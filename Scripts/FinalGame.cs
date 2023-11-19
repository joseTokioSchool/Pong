using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinalGame : MonoBehaviour
{
    [SerializeField] GameObject panel;
    void Start()
    {
        panel.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (GameManager.Instance.player1Scored == 10 || GameManager.Instance.player2Scored == 10)
        {
            Time.timeScale = 0f;
            panel.SetActive(true);
        }

    }
    public void RestartGame()
    {
        GameManager.Instance.GameRestart();
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void MainMenu(int n)
    {
        SceneManager.LoadScene(n);
    }

}
