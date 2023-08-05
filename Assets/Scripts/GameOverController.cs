using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOverController : MonoBehaviour
{
    [SerializeField] private Button playAgainButton;
    [SerializeField] private Button continueButton;
    [SerializeField] private Button returnToMenuButton;
    [SerializeField] private AsteroidSpawner asteroidSpawner;

    private void Awake() 
    {
        playAgainButton.onClick.AddListener(OnPlayAgainClicked);        
        continueButton.onClick.AddListener(OnContinueClicked);        
        returnToMenuButton.onClick.AddListener(OnReturnToMenuClicked);        
    }

    public void EndGame()
    {
        asteroidSpawner.gameObject.SetActive(false);
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
