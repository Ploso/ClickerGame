using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class HUDScript : MonoBehaviour {

	public Text HUDRahe;
	private string screenRahe;

	public Button raheButton;
	private int rahe;


	void Start () {
		raheButton = raheButton.GetComponent<Button>();
	}

	public void RaheGains()
	{
		rahe = GameGlobals.GetRahe();
		rahe++;
		GameGlobals.SetRahe (rahe);
	}

	void Update () {
		screenRahe = GameGlobals.rahe.ToString();
		HUDRahe.text = "Rahe: " + screenRahe;

	}
}
