using UnityEngine;
using System.Collections;

public class GameManagerTest : MonoBehaviour {

	GameManager GM;

	void Awake () {

		GM = GameManager.Instance;
		GM.OnStateChange += HandleOnStateChange;

		Debug.Log("Current game state when Awakes: " + GM.gameState);

		GM.SetGameState(GameState.Intro);
	}

	void Start () {
		Debug.Log("Current game state when Starts: " + GM.gameState);
	}

	public void HandleOnStateChange ()
	{
		Debug.Log("Handling state change to: " + GM.gameState);
	}

}
