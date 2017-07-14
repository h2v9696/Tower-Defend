using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TowerHealth : SingletonMonoBehaviour<TowerHealth> {
    [SerializeField]
    int maxHealth;
    [SerializeField]
    Slider healthSlider;

    public int health;

	// Use this for initialization
	void OnEnable () {
        health = maxHealth;
        healthSlider.maxValue = maxHealth;
        healthSlider.value = health;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void TakeDamage(int damage) {
        health -= damage;
        healthSlider.value = health;
        if (health == 0)
        {
            Debug.Log ("GameOver!");
        }
    }
}
