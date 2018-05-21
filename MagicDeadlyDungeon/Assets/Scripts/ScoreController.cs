using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreController : MonoBehaviour {

    //public Text scoreText;
    private int score;

    void Start ()
    {
        score = 0;
        UpdateScore();
    }
	
	// Update is called once per frame
	void Update ()
    {
		
	}

     void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
            AddScore(1);
    }

    public void AddScore(int newScoreValue)
    {
        score += newScoreValue;
        UpdateScore();
    }

    void UpdateScore()
    {
     //   scoreText.text = "Score: " + score;
    }
}
