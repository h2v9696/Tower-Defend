using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : SingletonMonoBehaviour<ScoreManager> {
    int score;
    [SerializeField] 
    Text scoreText;

	void Start () {
        score = 0;
	}
	
    public void AddScore(int _score) {
        score += _score;
        scoreText.text = "" + score;
    }
}
