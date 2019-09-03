using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour {

    public static GameController instance;
    public GameObject gameOverText;
    public bool gameOver;
    public float scrollSpeed = -1.5f;

    private int score;
    public Text scoreText;

    private void Awake()
    {
        GameController.instance = this;
    }
  
    public void BirdScored()
    {
        if (gameOver) return;

        score++;
        scoreText.text = "Puntaje: " + score;
    }
	
	    // Update is called once per frame
	void Update () {
		
	}

    public void BirdDie()
    {
        gameOverText.SetActive(true);
        gameOver = true;
    }
}
