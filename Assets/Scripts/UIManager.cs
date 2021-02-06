using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public Text player1ScoreText;
    public Text player2ScoreText;
    public Text winText;
    public void OnPlayer1Score(int score)
    {
        player1ScoreText.text = score.ToString();
    }
    public void OnPlayer2Score(int score)
    {
        player2ScoreText.text = score.ToString();
    }
    public void OnPlayer1Win()
    {
        winText.text = "PLAYER 1 WİN";
    }
    public void OnPlayer2Win()
    {
        winText.text = "PLAYER 2 WİN";
    }
}
