using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PlayHUD : MonoBehaviour {

	public Text health;
	public Text ammo;
	public Text HUDRahe;
	public Text HUDLevel;
	public Text HUDShield;

	public Text debug1;
	public Text debug2;

	private string screenHp;
	private string screenAmmo;
	private string screenRahe;
	private string screenLevel;
	private string screenShield;

	private int p_shield;

	void Start () {
		AutoRahe ();
		p_shield = GameGlobals.GetShield(); 
	}

	void Update () {

		if (p_shield <= 0) {
			p_shield = 0;
		} else {
			p_shield = GameGlobals.GetShield();
		}

		debug1.text = "Timer " + Player.mapTimer;
		debug2.text = "Length " + GameGlobals.mapLength;

		screenHp = GameGlobals.hp.ToString();
		health.text = "Health: " + screenHp;

		screenAmmo = GameGlobals.ammo.ToString();
		ammo.text = "Ammo: " + screenAmmo;

		screenRahe = GameGlobals.rahe.ToString();
		HUDRahe.text = "Rahe: " + screenRahe;

		screenLevel = GameGlobals.currentLevel.ToString();
		HUDLevel.text = "Level: " + screenLevel;

		screenShield = p_shield.ToString();
		HUDShield.text = "Shield: " + screenShield;
	}

	public void AutoRahe()
	{
		int rahe;
		int p_rahePerSecond;
		rahe = GameGlobals.GetRahe();
		p_rahePerSecond = GameGlobals.rahePerSecond;
		rahe = rahe + p_rahePerSecond;
		GameGlobals.SetRahe (rahe);
		Invoke ("AutoRahe", GameGlobals.autoRahe);
	}
}
