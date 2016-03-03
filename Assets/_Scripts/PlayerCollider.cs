using UnityEngine;
using System.Collections;

public class PlayerCollider : MonoBehaviour {

	// public instance variables 
	public GameController gameController;
	public EnemyController enemyController;

	// private 
	private AudioSource[] _audioSources;
	private AudioSource _hitSound; 
	private AudioSource _engineSound;


	// Use this for initialization
	void Start () {
		this._audioSources = gameObject.GetComponents<AudioSource> ();
		this._hitSound = this._audioSources [1];
		this._engineSound = this._audioSources [2]; 
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	// detect collision with enemy object, make actions
	public void OnTriggerEnter2D(Collider2D other) {
		if (other.gameObject.CompareTag ("enemy")) {
			this.gameController.LivesValue -= 1;
			this._hitSound.Play ();
			// destroying clone and no setting new 
		//	Destroy (other.gameObject);
			this.enemyController._Reset ();


		}
	}
}