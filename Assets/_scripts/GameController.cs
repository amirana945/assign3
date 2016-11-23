using UnityEngine;
// reference to the UI namespace
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour {
    // The actual GUI text objects
    public Text Score;

    public Text Lives;
    private AudioSource _gameOver;
    public Text GameOver;
    public Text FinalScore;
    public Button RestartButton;

    //PRIVATE INSTANCE VARIABLES
    private int _scoreValue;
    private int _livesValue;

    // PIBLICE PROPERTIES
    public int LivesValue
    {
        get
        {
            return this._livesValue;
        }


        set
        {
            this._livesValue = value;
            if (this._livesValue <= 0)
            {
                this.endGame();
            }
            else
                this.Lives.text = "Lives: " + this._livesValue;
        }

    }

    public int ScoreValue
    {
        get
        {
            return this._scoreValue;
        }
        set
        {
            this._scoreValue = value;
            this.Score.text = "Score: " + this._scoreValue;
        }
    }
    // Use this for initialization
    
    void Start()
    {
        this.LivesValue = 5;
        this.ScoreValue = 0;
        this.GameOver.gameObject.SetActive(false);
        this.FinalScore.gameObject.SetActive(false);
        this.RestartButton.gameObject.SetActive(false);
        this._gameOver = this.GetComponent<AudioSource>();

    }
    public void UpdateLives(int health)
    {
        this._livesValue += health;
    }
    private void endGame()
    {
        this.GameOver.gameObject.SetActive(true);
        this.FinalScore.text = "Final Score: " + this.ScoreValue;
        this.FinalScore.gameObject.SetActive(true);
        this.RestartButton.gameObject.SetActive(true);
        this._gameOver.Play();
       

    }
    public void RestartButton_Click()
    {
        SceneManager.LoadScene("main");
    }


    // Update is called once per frame
    void Update () {
        Score.text = "Score: " + ScoreValue;
        Lives.text = "Lives: " + LivesValue;
	}
}
