using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameManager : MonoBehaviour
{
    public Ball ball;
    public Paddle playerPaddle;
    public Paddle computerPaddle;
    public TextMeshProUGUI playerScoreText;
    public TextMeshProUGUI computerScoreText;
    public TextMeshProUGUI winnerText;
    public GameObject endGame;
    int _playerScore;
    int _computerScore;


    public void PlayerScores()
    {
        _playerScore++;
        this.playerScoreText.text = _playerScore.ToString();

        if (_playerScore >= 5 && _playerScore - _computerScore > 1)
        {
            endGame.SetActive(true);
            winnerText.text = "PLAYER WINS";
            ball.CenterBall();
        }
        else 
        {
            RoundReset();
        }
    }
    public void ComputerScores()
    {
        _computerScore++;
        this.computerScoreText.text = _computerScore.ToString();

        if (_computerScore >= 5 && _computerScore - _playerScore > 1)
        {
            endGame.SetActive(true);
            winnerText.text = "COMPUTER WINS";
            ball.CenterBall();
        }
        else
        {
            RoundReset();
        }
    }
    public void RoundReset()
    {
        playerPaddle.ResetPosition();
        computerPaddle.ResetPosition();
        ball.ResetPosition();
    }
}
