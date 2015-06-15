using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class HUDScript : MonoBehaviour {

	public Text HUDRahe;
	public Text HUDAyy;
	private string screenRahe;
	private string screenAyy;

	public Button autoRahe1;
	public Button increaseAuto;
	public Button raheButton;
	public Button clickIncrease;
	public Button buyAyy;

	private int rahe;

	
	void Start () {
		raheButton = raheButton.GetComponent<Button>();
		autoRahe1 = autoRahe1.GetComponent<Button>();
		increaseAuto = increaseAuto.GetComponent<Button> ();
		clickIncrease = clickIncrease.GetComponent<Button> ();
		buyAyy = buyAyy.GetComponent<Button> ();

	}


	void Update () {
		screenRahe = GameGlobals.rahe.ToString();
		HUDRahe.text = "Rahe: " + screenRahe;

		screenAyy = GameGlobals.ayyyluminium.ToString();
		HUDAyy.text = "Ayyyluminium: " + screenAyy;

	}

	void AutoRahe()
	{
		rahe = GameGlobals.GetRahe();
		rahe++;
		GameGlobals.SetRahe (rahe);
		Invoke ("AutoRahe", GameGlobals.autoRahe);
	}

	public void SetAutoRahe()
	{
		int tempRahe;
		if (GameGlobals.rahe >= 20) {
			tempRahe = GameGlobals.GetRahe();
			tempRahe = tempRahe -20;
			GameGlobals.SetRahe(tempRahe);
			AutoRahe ();
		}
	}

	public void RaheGains()
	{
		int click;
		click = GameGlobals.GetClick ();
		rahe = GameGlobals.GetRahe();
		rahe = rahe + click;
		GameGlobals.SetRahe (rahe);
	}

	public void RaheAutoIncrease()
	{
		float speed;
		speed = GameGlobals.GetAuto();
		speed = speed/1.1f;
		GameGlobals.SetAuto (speed);
	}

	public void ClickIncrease()
	{
		int click;
		click = GameGlobals.GetClick();
		click++;
		GameGlobals.SetClick (click);
	}

	public void BuyAyy()
	{
		int ayy;
		int tempRahe;

		if (GameGlobals.rahe >= 100) {
			ayy = GameGlobals.GetAyy ();
			ayy++;
			GameGlobals.SetAyy (ayy);
			tempRahe = GameGlobals.GetRahe();
			tempRahe = tempRahe -100;
			GameGlobals.SetRahe(tempRahe);
		}
	}
}
