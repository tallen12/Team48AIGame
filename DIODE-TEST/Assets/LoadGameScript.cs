using UnityEngine;
using System.Collections;

public class LoadGameScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    public void LoadStage()
    {
        Application.LoadLevel("GameLobby");
    }
}
