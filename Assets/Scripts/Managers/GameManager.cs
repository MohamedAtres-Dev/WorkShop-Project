using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [HideInInspector] public int currentScore = 0;
    public GameObject gameOverViewObject;
    public static GameManager instance;

    private void OnEnable()
    {
        PlayerCollision.onCollectCoin += UpdateScore;
    }

    private void OnDisable()
    {
        PlayerCollision.onCollectCoin -= UpdateScore;
    }

    private void Awake()
    {
        instance = this;
    }

    public void UpdateScore()
    {
        currentScore++;
    }

    public void GameOver()
    {
        gameOverViewObject.SetActive(true);
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(0);
    }

}
