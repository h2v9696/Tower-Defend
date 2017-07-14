using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour {
    // Use this for initialization
    [SerializeField]
    float lifeTime;

    void Start() {
        Destroy (gameObject, lifeTime);
    }
    void OnCollisionEnter(Collision other)
    {
        if (gameObject != null)
            Destroy (gameObject);
        if (other.gameObject.CompareTag ("Enemy"))
        {
            Destroy (other.gameObject);
            ScoreManager.Instance.AddScore (EnemyManager.Instance.point);
            EnemyManager.Instance.enemiesCount--;
            if (EnemyManager.Instance.enemiesCount == 0)
                Debug.Log ("You win!");
        }
    }


}
