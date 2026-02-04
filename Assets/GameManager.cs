using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public Ball ball;

    public Text playerScoreTest;

    public Text computerScoreTest;

    public int playerScore = 0;
    public int computerScore = 0;

    public void PlayerScore()
    {
        playerScore++;
        this.playerScoreTest.text = playerScore.ToString();
        this.ball.ResetPosition();
    }
    public void ComputerScore()
    {
        computerScore++;
        this.computerScoreTest.text = computerScore.ToString();
        this.ball.ResetPosition();
    }
}
