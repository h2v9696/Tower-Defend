using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : SingletonMonoBehaviour<GameManager> {
    [SerializeField]
    GameObject[] listGO;

    void Start() {
        SetActiveGOList ();
    }

	public void StartGame () {
        SetActiveGOList ();
	}
     
    //Active or de-active when start game
    public void SetActiveGOList() {
        foreach (GameObject go in listGO)
        {
            go.SetActive (!go.activeSelf);
        }
    }

    public void Reset() {
        SceneManager.LoadScene ("Main");
    }
}
