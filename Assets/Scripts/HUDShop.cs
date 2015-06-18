using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class HUDShop : MonoBehaviour {
	
	public Text HUDRahe;
	public Text HUDAyy;
	public Text HUDAyyPrice;
	public Text HUDTita;
	public Text HUDTitaPrice;
	public Text HUDAnti;
	public Text HUDAntiPrice;
	public Text HUDFift;
	public Text HUDFifthPrice;
	
	private string screenRahe;
	private string screenAyy;
	private string screenAyyPrice;
	private string screenTita;
	private string screenTitaPrice;
	private string screenAnti;
	private string screenAntiPrice;
	private string screenFift;
	private string screenFiftPrice;
	
	public Button buyAyy;
	public Button buyTita;
	public Button buyAnti;
	public Button buyFifth;
	public Button back;
	public Button buyAmmo10;
	public Button buyAmmo100;
	public Button buyAmmo1000;
	public Button heal;
	public Button buyShield;
	public Button upgradeWeapon;
	
	private int rahe;
	private int ayyPrice;
	private int titaPrice;
	private int antiPrice;
	private int fifthPrice;
	private int ammo10Price;
	private int ammo100Price;
	private int ammo1000Price;
	private int s_rahePerSecond;
	private int healPrice;
	private int s_hp;
	private int shieldPrice;
	private int upgradeWeaponPrice;

	private bool s_shieldUnBought;
	private bool s_upgradeBought;

	void Start () {

		ayyPrice = 100;
		titaPrice = 1000;
		antiPrice = 10000;
		fifthPrice = 100000;
		ammo10Price = 1;
		ammo100Price = 10;
		ammo1000Price = 100;
		healPrice = 1;
		shieldPrice = 1;
		upgradeWeaponPrice = 100;

		s_shieldUnBought = GameGlobals.GetShieldBought();
		s_upgradeBought = GameGlobals.GetUpgradeBought ();
		s_hp = GameGlobals.GetHp();

		buyAyy = buyAyy.GetComponent<Button> ();
		buyTita = buyTita.GetComponent<Button> ();
		buyAnti = buyAnti.GetComponent<Button> ();
		buyFifth = buyFifth.GetComponent<Button> ();
		buyAyy = buyAyy.GetComponent<Button> ();
		buyAyy = buyAyy.GetComponent<Button> ();
		back = back.GetComponent<Button> ();
		buyAmmo10 = buyAmmo10.GetComponent<Button> ();
		buyAmmo100 = buyAmmo100.GetComponent<Button> ();
		buyAmmo1000 = buyAmmo1000.GetComponent<Button> ();
		heal = heal.GetComponent<Button> ();
		buyShield = buyShield.GetComponent<Button> ();
		upgradeWeapon = upgradeWeapon.GetComponent<Button> ();

		AutoRahe ();
			
	}
	
	
	void Update () {
		
		screenRahe = GameGlobals.rahe.ToString();
		HUDRahe.text = "Rahe: " + screenRahe;
		
		screenAyy = GameGlobals.ayyyluminium.ToString();
		HUDAyy.text = "Ayyyluminium: " + screenAyy;

		screenTita = GameGlobals.titayyynium.ToString();
		HUDTita.text = "Titayyynium: " + screenTita;
		
		screenAnti = GameGlobals.ayyyntimatter.ToString();
		HUDAnti.text = "Ayyyntimatter: " + screenAnti;
		
		screenFift = GameGlobals.fiftAyyylement.ToString();
		HUDFift.text = "Fifth Ayyylement: " + screenFift;

		screenAyyPrice = ayyPrice.ToString();
		HUDAyyPrice.text = screenAyyPrice + " Rahe";

		screenTitaPrice = titaPrice.ToString();
		HUDTitaPrice.text = screenTitaPrice + " Rahe";

		screenAntiPrice = antiPrice.ToString();
		HUDAntiPrice.text =  screenAntiPrice + " Rahe";

		screenFiftPrice = fifthPrice.ToString();
		HUDFifthPrice.text = screenFiftPrice + " Rahe";

		if (GameGlobals.rahe >= ayyPrice) {
			buyAyy.interactable = true;
		} else {
			buyAyy.interactable = false;
		}

		if (GameGlobals.rahe >= titaPrice) {
			buyTita.interactable = true;
		} else {
			buyTita.interactable = false;
		}

		if (GameGlobals.rahe >= antiPrice) {
			buyAnti.interactable = true;
		} else {
			buyAnti.interactable = false;
		}

		if (GameGlobals.rahe >= fifthPrice) {
			buyFifth.interactable = true;
		} else {
			buyFifth.interactable = false;
		}

		if (GameGlobals.ayyyluminium >= ammo10Price) {
			buyAmmo10.interactable = true;
		} else {
			buyAmmo10.interactable = false;
		}

		if (GameGlobals.ayyyluminium >= ammo100Price) {
			buyAmmo100.interactable = true;
		} else {
			buyAmmo100.interactable = false;
		}

		if (GameGlobals.ayyyluminium >= ammo1000Price) {
			buyAmmo1000.interactable = true;
		} else {
			buyAmmo1000.interactable = false;
		}

		if (GameGlobals.titayyynium >= healPrice && s_hp < 100) {
			heal.interactable = true;
		} else {
			heal.interactable = false;
		}

		if (GameGlobals.ayyyntimatter >= shieldPrice && s_shieldUnBought == true) {
			buyShield.interactable = true;
		} else {
			buyShield.interactable = false;
		}

		if (GameGlobals.fiftAyyylement >= upgradeWeaponPrice && s_upgradeBought == true) {
			upgradeWeapon.interactable = true;
		} else {
			upgradeWeapon.interactable = false;
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
		tempRahe = tempRahe - ayyPrice;
		GameGlobals.SetRahe(tempRahe);
		
	}

	public void BuyTita()
	{
		int tita;
		int tempRahe;
		
		tita = GameGlobals.GetTitayyynium ();
		tita++;
		GameGlobals.SetTitayyynium (tita);
		tempRahe = GameGlobals.GetRahe();
		tempRahe = tempRahe - titaPrice;
		GameGlobals.SetRahe(tempRahe);
		
	}

	public void BuyAnti()
	{
		int anti;
		int tempRahe;
		
		anti = GameGlobals.GetAyyyntimatter ();
		anti++;
		GameGlobals.SetAyyyntimatter (anti);
		tempRahe = GameGlobals.GetRahe();
		tempRahe = tempRahe - antiPrice;
		GameGlobals.SetRahe(tempRahe);
		
	}

	public void BuyFifth()
	{
		int fifth;
		int tempRahe;
		
		fifth = GameGlobals.GetFiftAyyylement ();
		fifth++;
		GameGlobals.SetFiftAyyylement (fifth);
		tempRahe = GameGlobals.GetRahe();
		tempRahe = tempRahe - fifthPrice;
		GameGlobals.SetRahe(tempRahe);
		
	}

	public void BuyAmmo10()
	{
		int ayy;
		int tempAmmo;
		
		ayy = GameGlobals.GetAyy ();
		ayy = ayy - ammo10Price;
		GameGlobals.SetAyy (ayy);

		tempAmmo = GameGlobals.GetAmmo();
		tempAmmo = tempAmmo +10;
		GameGlobals.SetAmmo(tempAmmo);
		
	}

	public void BuyAmmo100()
	{
		int ayy;
		int tempAmmo;
		
		ayy = GameGlobals.GetAyy ();
		ayy = ayy - ammo100Price;
		GameGlobals.SetAyy (ayy);
		
		tempAmmo = GameGlobals.GetAmmo();
		tempAmmo = tempAmmo +100;
		GameGlobals.SetAmmo(tempAmmo);
		
	}

	public void BuyAmmo1000()
	{
		int ayy;
		int tempAmmo;
		
		ayy = GameGlobals.GetAyy ();
		ayy = ayy - ammo1000Price;
		GameGlobals.SetAyy (ayy);
		
		tempAmmo = GameGlobals.GetAmmo();
		tempAmmo = tempAmmo +1000;
		GameGlobals.SetAmmo(tempAmmo);
		
	}

	public void BackToMain()
	{ 
		Application.LoadLevel (1);
	}

	public void AutoRahe()
	{
		rahe = GameGlobals.GetRahe();
		s_rahePerSecond = GameGlobals.GetRahePerSecond ();
		rahe = rahe + s_rahePerSecond;
		GameGlobals.SetRahe (rahe);
		Invoke ("AutoRahe", GameGlobals.autoRahe);
	}

	public void Heal()
	{
		int tita;
		tita = GameGlobals.GetTitayyynium();
		tita--;
		GameGlobals.SetHp (100);
		GameGlobals.SetTitayyynium (tita);
		s_hp = 100;
	}

	public void BuyShield()
	{
		int anti;
		anti = GameGlobals.GetAyyyntimatter ();
		GameGlobals.SetShield (20);
		anti = anti - shieldPrice;
		GameGlobals.SetAyyyntimatter (anti);
		s_shieldUnBought = false;
		GameGlobals.SetShieldBought (s_shieldUnBought);
		GameGlobals.SetMaxShield (20);
	}

	public void UpgradeWeapon()
	{
		int fifth;
		fifth = GameGlobals.GetFiftAyyylement ();
		GameGlobals.SetPlayerDamage (3);
		fifth = fifth - upgradeWeaponPrice;
		GameGlobals.SetFiftAyyylement (fifth);
		s_upgradeBought = false;
		GameGlobals.SetUpgradeBought (s_upgradeBought);
	}
}
