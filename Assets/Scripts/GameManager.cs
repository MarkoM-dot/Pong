using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public Ball ball;
    public Paddle playerPaddle;
    public Paddle computerPaddle;
    public Text playerScoreText;
    public Text computerScoreText;
    private int _playerScore;
    private int _computerScore;


    public void PlayerScores()
    {
        _playerScore++;
        this.playerScoreText.text = _playerScore.ToString();

        RoundReset();
    }
    public void ComputerScores()
    {
        _computerScore++;
        this.computerScoreText.text = _computerScore.ToString();

        RoundReset();
    }
    private void RoundReset()
    {
        this.playerPaddle.ResetPosition();
        this.computerPaddle.ResetPosition();
        this.ball.ResetPosition();
    }
}
