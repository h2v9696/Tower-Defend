using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttack : MonoBehaviour {
    [SerializeField]
    int damage;
	
	void OnCollisionEnter (Collision col) {
        if (col.gameObject.CompareTag ("Tower"))
        {
            TowerHealth.Instance.TakeDamage (damage);
        }
	}
}
