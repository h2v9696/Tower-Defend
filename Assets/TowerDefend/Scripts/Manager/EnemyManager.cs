using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : SingletonMonoBehaviour<EnemyManager> {
    public List<GameObject> enemies;
    [SerializeField]
    int _point;

    public int enemiesCount;
    public int point
    {
        get { return _point; }
        set { _point = point; }
    }


	// Use this for initialization
	void Start () {
        enemiesCount = enemies.Count;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
