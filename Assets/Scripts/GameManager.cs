using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public TextMeshProUGUI scoreText;

    public TextMeshProUGUI timerText;

    public TextMeshProUGUI gameOverText;
    public GameObject titleScreen;
    public Button restartButton;

    public List<GameObject> targetPrefabs;

    public float currentTime;
    public float startingTime = 60f;

    private int score;
    private float spawnRate = 1.5f;
    public bool isGameActive;


    // Start the game, remove title screen, reset score, and adjust spawnRate based on difficulty button clicked
    public void StartGame(int difficulty)
    {
        currentTime = startingTime;
        spawnRate /= difficulty;
        isGameActive = true;
        //StartCoroutine(SpawnTarget());
        titleScreen.SetActive(false);
    }

    void Update()
    {

    }


    // Stop game, bring up game over text and restart button
    public void GameOver()
    {
        gameOverText.gameObject.SetActive(true);
        restartButton.gameObject.SetActive(true);
        isGameActive = false;
    }

    // Restart game by reloading the scene
    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

}
