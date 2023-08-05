using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    [SerializeField] private GameOverController gameOverController;
    public void Crash()
    {
        gameOverController.EndGame();
        gameObject.SetActive(false);
    }
}
