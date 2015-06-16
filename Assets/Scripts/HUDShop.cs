using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class HUDShop : MonoBehaviour {
	
	public Text HUDRahe;
	public Text HUDAyy;
	public Text HUDAyyPrice;
	
	private string screenRahe;
	private string screenAyy;
	private string screenAyyPrice;
	
	public Button buyAyy;
	public Button back;
	public Button buyAmmo10;
	
	private int rahe;
	private int ayyPrice;
	private int ammo10Price;

	void Start () {

		ayyPrice = 100;
		ammo10Price = 1;

		buyAyy = buyAyy.GetComponent<Button> ();
		back = back.GetComponent<Button> ();
		buyAmmo10 = buyAmmo10.GetComponent<Button> ();
		
	}
	
	
	void Update () {

		
		screenRahe = GameGlobals.rahe.ToString();
		HUDRahe.text = "Rahe: " + screenRahe;
		
		screenAyy = GameGlobals.ayyyluminium.ToString();
		HUDAyy.text = "Ayyyluminium: " + screenAyy;

		screenAyyPrice = ayyPrice.ToString();
		HUDAyyPrice.text = "Buy Ayyluminium (" + screenAyyPrice + " Rahe)";

		if (GameGlobals.rahe >= ayyPrice) {
			buyAyy.interactable = true;
		} else {
			buyAyy.interactable = false;
		}

		if (GameGlobals.ayyyluminium >= ammo10Price) {
			buyAmmo10.interactable = true;
		} else {
			buyAmmo10.interactable = false;
		}
		
		
	}


	public void BuyAyy()
	{
		int ayy;
		int tempRahe;
		
		ayy = GameGlobals.GetAyy ();
		ayy++;
		GameGlobals.SetAyy (ayy);
		tempRahe = GameGlobals.GetRahe();
		tempRahe = tempRahe -100;
		GameGlobals.SetRahe(tempRahe);
		
	}

	public void BuyAmmo10()
	{
		int ayy;
		int tempAmmo;
		
		ayy = GameGlobals.GetAyy ();
		ayy --;
		GameGlobals.SetAyy (ayy);

		tempAmmo = GameGlobals.GetAmmo();
		tempAmmo = tempAmmo +10;
		GameGlobals.SetAmmo(tempAmmo);
		
	}

	public void BackToMain()
	{
		Application.LoadLevel (0);
	}
}
