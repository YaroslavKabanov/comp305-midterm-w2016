using UnityEngine;
using System.Collections;

public class PlayerCollider : MonoBehaviour {

	// public instance variables 

	public GameController gameController;
	public EnemyController enemyController;


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	// detect collision with enemy object, make actions
	public void OnTriggerEnter2D(Collider2D other) {
		if (other.gameObject.CompareTag ("enemy")) {
			this.gameController.LivesValue -= 1;
			this.enemyController._Reset ();

		}
	}
}