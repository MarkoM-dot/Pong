using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public Ball ball;
    public Paddle playerPaddle;
    public Paddle computerPaddle;
    public TextMeshProUGUI playerScoreText;
    public TextMeshProUGUI computerScoreText;
    public TextMeshProUGUI winnerText;
    public TextMeshProUGUI loserText;
    public GameObject endGameWon;
    public GameObject endGameLost;
    public string nextLevel = "Level2";
    public int levelToUnlock = 2;
    int _playerScore;
    int _computerScore;


    public void PlayerScores()
    {
        _playerScore++;
        this.playerScoreText.text = _playerScore.ToString();

        if (_playerScore >= 5 && _playerScore - _computerScore > 1)
        {
            endGameWon.SetActive(true);
            winnerText.text = "PLAYER WINS";
            ball.CenterBall();
            LevelWon();
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
            endGameLost.SetActive(true);
            loserText.text = "COMPUTER WINS";
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
    public void LevelWon()
    {
        PlayerPrefs.SetInt("levelReached", levelToUnlock);
    }
    public void BackToChallenge()
    {
        SceneManager.LoadScene(3);
    }
}
