using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class HUDScript : MonoBehaviour {

	public Text HUDRahe;
	public Text HUDAyy;
	public Text HUDIncrease;
	public Text HUDClick;
	public Text HUDCurrentClick;
	public Text HUDAutoPrice;
	public Text HUDRootPrice;

	private string screenRahe;
	private string screenAyy;
	private string screenIncrease;
	private string screenClick;
	private string screenCurrentClick;
	private string screenAutoPrice;
	private string screenRootPrice;

	private bool h_autorahe1buy;

	public Button autoRahe1;
	public Button increaseAuto;
	public Button raheButton;
	public Button clickIncrease;
	public Button rootIncreaseButton;
	public Button toShop;
	public Button toBattle;

	private int rahe;
	private int currentClick;
	private int h_rahePerSecond;
	private int h_rahePrize;
	private int h_clickPrize;
	private int h_autoPrice;
	private int h_rootPrice;
	
	void Start () {
		h_autorahe1buy = GameGlobals.GetAutoRahe1buy ();

		h_autoPrice = GameGlobals.GetAutoPrice();
		h_rahePrize = GameGlobals.GetRahePrize();
		h_clickPrize = GameGlobals.GetClickPrize ();
		h_autoPrice = GameGlobals.GetAutoPrice ();
		h_rootPrice = GameGlobals.GetRootPrice ();

		raheButton = raheButton.GetComponent<Button>();
		autoRahe1 = autoRahe1.GetComponent<Button>();
		increaseAuto = increaseAuto.GetComponent<Button> ();
		clickIncrease = clickIncrease.GetComponent<Button> ();
		rootIncreaseButton = rootIncreaseButton.GetComponent<Button> ();
		toShop = toShop.GetComponent<Button> ();
		toBattle = toBattle.GetComponent<Button> ();

		AutoRahe ();

	}


	void Update () {

		currentClick = GameGlobals.GetClick();

		screenRahe = GameGlobals.rahe.ToString();
		HUDRahe.text = "Rahe: " + screenRahe;

		screenAyy = GameGlobals.ayyyluminium.ToString();
		HUDAyy.text = "Ayyyluminium: " + screenAyy;

		screenIncrease = h_rahePrize.ToString();
		HUDIncrease.text = "Enhance AutoClicker (" + screenIncrease + " Rahe)";

		screenClick = h_clickPrize.ToString();
		HUDClick.text = "Increase Rahe from clicks (" + screenClick + " Rahe)";

		screenCurrentClick = currentClick.ToString();
		HUDCurrentClick.text = "Current Rahe from a click: " + screenCurrentClick;

		screenAutoPrice = h_autoPrice.ToString();
		HUDAutoPrice.text = "Buy Auto Clicker (" + screenAutoPrice + " Rahe)";

		screenRootPrice = h_rootPrice.ToString();
		HUDRootPrice.text = "Increase auto clicker root (" + screenRootPrice + " Ayyyluminium)";

		if (GameGlobals.rahe >= h_autoPrice && h_autorahe1buy == true) {
			autoRahe1.interactable = true;
		} else {
			autoRahe1.interactable = false;
		}

		if (GameGlobals.rahe >= h_rahePrize && h_autorahe1buy == false) {
			increaseAuto.interactable = true;
		} else {
			increaseAuto.interactable = false;
		}


		if (GameGlobals.rahe >= h_clickPrize) {
			clickIncrease.interactable = true;
		} else {
			clickIncrease.interactable = false;
		}


		if (GameGlobals.ayyyluminium >= h_rootPrice && h_autorahe1buy == false) {
			rootIncreaseButton.interactable = true;
		} else {
			rootIncreaseButton.interactable = false;
		}


	}

	void AutoRahe()
	{
		rahe = GameGlobals.GetRahe();
		rahe = rahe + h_rahePerSecond;
		GameGlobals.SetRahe (rahe);
		Invoke ("AutoRahe", GameGlobals.autoRahe);
	}

	public void SetAutoRahe()
	{
		int tempRahe;
		tempRahe = GameGlobals.GetRahe();

		tempRahe = tempRahe -20;
		GameGlobals.SetRahe(tempRahe);
		h_rahePerSecond ++;
		GameGlobals.SetRahePerSecond (h_rahePerSecond);

		h_autorahe1buy = false;
		GameGlobals.SetAutoRahe1buy(false);
		autoRahe1.interactable = false;
		
	}

	public void RootAutoRahe()
	{
		int tempAyy;
		tempAyy = GameGlobals.GetAyy();
		tempAyy = tempAyy - h_rootPrice;
		h_rahePerSecond ++;
		GameGlobals.SetAyy(tempAyy);
		GameGlobals.SetRahePerSecond (h_rahePerSecond);

		h_rootPrice = h_rootPrice * 2;
		GameGlobals.SetRootPrice (h_rootPrice);
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
		int newPrize;
		float speed;
		int tempRahe;

		newPrize = GameGlobals.GetIncreasePrize ();
		speed = GameGlobals.GetAuto();
		tempRahe = GameGlobals.GetRahe();

		speed = speed/1.5f;
		tempRahe = tempRahe - h_rahePrize;
		GameGlobals.SetRahe (tempRahe);

		h_rahePrize = h_rahePrize * newPrize;
		newPrize = newPrize * 2;

		GameGlobals.SetRahePrize (h_rahePrize);
		GameGlobals.SetAuto (speed);
		GameGlobals.SetIncreasePrize (newPrize);
	}

	public void ClickIncrease()
	{
		int click;
		int tempRahe;

		tempRahe = GameGlobals.GetRahe ();
		click = GameGlobals.GetClick ();

		click++;
		tempRahe = tempRahe - h_clickPrize;
		GameGlobals.SetClick (click);
		h_clickPrize = h_clickPrize * 2;

		GameGlobals.SetClickPrize (h_clickPrize);
		GameGlobals.SetRahe (tempRahe);

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

	public void ToTheShop()
	{
		Application.LoadLevel (3);
	}

	public void ToTheBattle()
	{
		Application.LoadLevel (1);
	}
}
