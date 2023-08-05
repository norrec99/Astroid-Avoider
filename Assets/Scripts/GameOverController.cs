using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class GameOverController : MonoBehaviour
{
    [Header("Texts")]
    [SerializeField] private TMP_Text gameOverText;
    [Header("Buttons")]
    [SerializeField] private Button playAgainButton;
    [SerializeField] private Button continueButton;
    [SerializeField] private Button returnToMenuButton;
    [Header("Controllers")]
    [SerializeField] private AsteroidSpawner asteroidSpawner;
    [SerializeField] private ScoreSystemController scoreSystemController;

    private void Awake() 
    {
        playAgainButton.onClick.AddListener(OnPlayAgainClicked);        
        continueButton.onClick.AddListener(OnContinueClicked);        
        returnToMenuButton.onClick.AddListener(OnReturnToMenuClicked);        
    }

    public void EndGame()
    {
        int score = scoreSystemController.GetScoreValue();
        gameOverText.SetText($"Your score: {score}");

        asteroidSpawner.gameObject.SetActive(false);
        scoreSystemController.gameObject.SetActive(false);
        this.gameObject.SetActive(true);
    }

    private void OnPlayAgainClicked()
    {
        SceneManager.LoadScene(1);
    }
    private void OnContinueClicked()
    {
        gameObject.SetActive(false);
    }
    private void OnReturnToMenuClicked()
    {
        SceneManager.LoadScene(0);
    }
}
