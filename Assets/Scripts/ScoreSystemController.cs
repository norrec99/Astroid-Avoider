using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreSystemController : MonoBehaviour
{
    [SerializeField] private TMP_Text scoreText;
    [SerializeField] private float scoreMultiplier = 1f;

    private float scoreValue;

    // Update is called once per frame
    void Update()
    {
        scoreValue += Time.deltaTime * scoreMultiplier;

        scoreText.SetText($"{Mathf.RoundToInt(scoreValue).ToString()}");
    }

    public int GetScoreValue()
    {
        return Mathf.RoundToInt(scoreValue);
    }
}
