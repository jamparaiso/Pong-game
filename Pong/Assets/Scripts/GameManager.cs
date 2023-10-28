using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public TextMeshProUGUI _playerScoreText;
    public TextMeshProUGUI _computerScoreText;

    public Ball ball;
    public Paddle playerPaddle;
    public Paddle computerPaddle;

    private int _playerScore;
    private int _computerScore;

    public void PlayerScores()
    {
        _playerScore++;
        this._playerScoreText.text = _playerScore.ToString();
        ResetGame();
    }

    public void ComputerScores()
    {
        _computerScore++;
        this._computerScoreText.text = _computerScore.ToString();
        ResetGame();
    }

    private void ResetGame()
    {
        this.playerPaddle.ResetPaddle();
        this.computerPaddle.ResetPaddle();
        this.ball.ResetPosition();
        this.ball.AddStartingForce();
    }
}
