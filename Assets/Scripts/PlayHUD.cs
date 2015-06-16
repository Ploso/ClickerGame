using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PlayHUD : MonoBehaviour {

	public Text health;
	public Text ammo;

	private string screenHp;
	private string screenAmmo;

	void Start () {
	
	}

	void Update () {
		screenHp = GameGlobals.hp.ToString();
		health.text = "Health: " + screenHp;

		screenAmmo = GameGlobals.ammo.ToString();
		ammo.text = "Ammo: " + screenAmmo;
	}
}
