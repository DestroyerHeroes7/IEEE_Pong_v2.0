using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    public UIManager uiManager;
    public int player1Score;
    public int player2Score;

    public Player player1;
    public Player player2;

    private Vector2 player1DefaultPosition = new Vector2(-8.5f, 0);
    private Vector2 player2DefaultPosition = new Vector2(8.5f, 0);
    private int winScoreCount = 3;

    public Ball ball;
    public void OnPlayer1Score()
    {
        player1Score++;
        uiManager.OnPlayer1Score(player1Score);
    }
    public void OnPlayer2Score()
    {
        player2Score++;
        uiManager.OnPlayer2Score(player2Score);
    }
    public void GameEnd()
    {
        SceneManager.LoadScene(0);
    }
    public bool CheckGameEnd()
    {
        return player1Score >= winScoreCount || player2Score >= winScoreCount;
    }
    public void OnScore(string playerName)
    {
        if (CheckGameEnd())
        {
            player1.ToogleMove(false);
            player2.ToogleMove(false);
            if (playerName == "Player 1")
                uiManager.OnPlayer1Win();
            else
                uiManager.OnPlayer2Win();
            Invoke("GameEnd", 3);
        }
        else
            SetDefaultPosition();
    }
    public void SetDefaultPosition()
    {
        player1.transform.position = player1DefaultPosition;
        player2.transform.position = player2DefaultPosition;
        ball.transform.position = Vector2.zero;
        ball.Invoke("Start", 1);
    }
}
