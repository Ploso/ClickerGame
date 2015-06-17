using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class MenuScript : MonoBehaviour {

	public Button startButton;

	void Start () {
	
	}

	void Update () {
	
	}

	public void StartGame()
	{
		Application.LoadLevel (1);
	}
}
