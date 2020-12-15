using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManger : MonoBehaviour
{
    private bool gameHasEnded = false;
    private bool gameHasWon = false;
    public GameObject gameOverUI;
    public GameObject gameWonUI;
    public GameObject howToPlay;
    public GameObject mainMenu;
    public IntScript score;

    void start()
    {
        gameHasWon = false;
    }
    public void WonGame()
    {
        if (gameHasWon == false)
        {
            gameHasWon = true;
            Debug.Log("game complete");
            Victory();
        }
    }
    public void EndGame()
    {
        if (gameHasEnded == false)
        {
            gameHasEnded = true;
            Debug.Log("Game Over");
            GameOver();
            score.value = 0;

        }
    }
    void GameOver()
    {
        gameOverUI.SetActive(true);
    }
    public void HowTo()
    {
        howToPlay.SetActive(true);
        mainMenu.SetActive(false);
    }
    void Victory()
    {
        gameWonUI.SetActive(true);
    }
    public void PlayGame()
    {
        SceneManager.LoadScene(0);
    }

    public void MainMenu()
    {
        mainMenu.SetActive(true);
        howToPlay.SetActive(false);
    }
    public void MenuStart()
    {
        SceneManager.LoadScene(1);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
