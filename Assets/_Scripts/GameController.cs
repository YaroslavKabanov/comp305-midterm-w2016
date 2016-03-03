using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour {
	// PUBLIC INSTANCE VARIABLES
	public int tankCount;
	public GameObject tank;

	// private instance variables
	private int _scoreValue;
	private int _livesValue;


	//public access methods
	public int ScoreValue {
		get {
			return this._scoreValue;
		}

		set {
			this._scoreValue = value;
			this.ScoreLabel.text = "Score: " + this._scoreValue;
		}
	}

	public int LivesValue {
		get {
			return this._livesValue;
		}

		set {
			this._livesValue = value;

			if (this._livesValue <= 0) {
				this._gameOver ();
			} else {
				this.LivesLabel.text = "Lives: " + this._livesValue;
			}
		}
	}


	// public instance variables 
	public Text LivesLabel;
	public Text ScoreLabel;
	public Text ScoreHighLabel;
	public Button RestartButton;
	public Text GameOverLabel;

	// Use this for initialization
	void Start () {
		this._GenerateTanks ();
		this._initialize ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	// Initial methods
	private void _initialize() {
		this.ScoreValue = 0;
		this.LivesValue = 5;
		//	this.GameOverLabel.gameObject.SetActive (false); 
		this.ScoreHighLabel.gameObject.SetActive (false); 
		this.RestartButton.gameObject.SetActive (false);
		this.GameOverLabel.gameObject.SetActive (false);

	}


	private void _gameOver () {
		this.ScoreHighLabel.gameObject.SetActive (true);
		this.ScoreHighLabel.text = "Your score : " + this._scoreValue;
		//	this.GameOverLabel.gameObject.SetActive(true);
		this.GameOverLabel.gameObject.SetActive (true);
		this.LivesLabel.gameObject.SetActive (false);
		this.ScoreLabel.gameObject.SetActive (false);
	//	this.tank.gameObject.SetActive (false);
		this.RestartButton.gameObject.SetActive (true);

	}

	// generate Clouds
	private void _GenerateTanks() {
		for (int count = 0; count < this.tankCount; count++) {
			Instantiate (tank);
		}
	}
	
	// public methods 

		public void RestartButtonClick () {
			SceneManager.LoadScene (SceneManager.GetActiveScene().name);
	
	}
}
