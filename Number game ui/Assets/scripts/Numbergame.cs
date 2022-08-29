using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Numbergame : MonoBehaviour
{
    [SerializeField] private int max;
    [SerializeField] private int min;
    [SerializeField] private TextMeshProUGUI guessText;

    private int guess;

    void Start()
    {
        StartGame();
    }

    void StartGame()
    {
        NextGuess();
    }

    public void OnPressHigher()
    {
        min = guess + 1;
        NextGuess();
    }

    public void OnPressLower()
    {
        max = guess - 1;
        NextGuess();
    }

    void NextGuess()
    {
        guess = Random.Range(min, max + 1);
        guessText.text = guess.ToString();
    }
}
