using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    [SerializeField] private Button startGameButton;

    private void Awake() 
    {
        startGameButton.onClick.AddListener(OnStartGameClicked);        
    }

    private void OnStartGameClicked()
    {
        SceneManager.LoadScene(1);
    }
}
