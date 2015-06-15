using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class HUDScript : MonoBehaviour {

	public Text HUDRahe;
	public Text HUDAyy;
	public Text HUDIncrease;
	public Text HUDClick;
	public Text HUDCurrentClick;
	public Text HUDAyyPrice;
	public Text HUDAutoPrice;
	public Text HUDRootPrice;

	private string screenRahe;
	private string screenAyy;
	private string screenIncrease;
	private string screenClick;
	private string screenCurrentClick;
	private string screenAyyPrice;
	private string screenAutoPrice;
	private string screenRootPrice;

	private bool autorahe1buy;

	public Button autoRahe1;
	public Button increaseAuto;
	public Button raheButton;
	public Button clickIncrease;
	public Button buyAyy;
	public Button rootIncreaseButton;

	private int rahe;
	private int rahePerSecond;
	private int rahePrize;
	private int clickPrize;
	private int currentClick;
	private int ayyPrice;
	private int autoPrice;
	private int rootPrice;
	
	void Start () {
		autoRahe1.interactable = false;
		increaseAuto.interactable = false;
		autorahe1buy = true;

		rahePrize = 100;
		clickPrize = 16;
		ayyPrice = 100;
		autoPrice = 20;
		rahePerSecond = 0;
		rootPrice = 1;

		raheButton = raheButton.GetComponent<Button>();
		autoRahe1 = autoRahe1.GetComponent<Button>();
		increaseAuto = increaseAuto.GetComponent<Button> ();
		clickIncrease = clickIncrease.GetComponent<Button> ();
		buyAyy = buyAyy.GetComponent<Button> ();
		rootIncreaseButton = rootIncreaseButton.GetComponent<Button> ();

		AutoRahe ();

	}


	void Update () {

		currentClick = GameGlobals.GetClick();

		screenRahe = GameGlobals.rahe.ToString();
		HUDRahe.text = "Rahe: " + screenRahe;

		screenAyy = GameGlobals.ayyyluminium.ToString();
		HUDAyy.text = "Ayyyluminium: " + screenAyy;

		screenIncrease = rahePrize.ToString();
		HUDIncrease.text = "Enhance AutoClicker (" + screenIncrease + " Rahe)";

		screenClick = clickPrize.ToString();
		HUDClick.text = "Increase Rahe from clicks (" + screenClick + " Rahe)";

		screenCurrentClick = currentClick.ToString();
		HUDCurrentClick.text = "Current Rahe from a click: " + screenCurrentClick;

		screenAyyPrice = ayyPrice.ToString();
		HUDAyyPrice.text = "Buy Ayyluminium (" + screenAyyPrice + " Rahe)";

		screenAutoPrice = autoPrice.ToString();
		HUDAutoPrice.text = "Buy Auto Clicker (" + screenAutoPrice + " Rahe)";

		screenRootPrice = rootPrice.ToString();
		HUDRootPrice.text = "Increase auto clicker root (" + screenRootPrice + " Ayyyluminium)";

		if (GameGlobals.rahe >= autoPrice && autorahe1buy == true) {
			autoRahe1.interactable = true;
		} else {
			autoRahe1.interactable = false;
		}

		if (GameGlobals.rahe >= rahePrize && autorahe1buy == false) {
			increaseAuto.interactable = true;
		} else {
			increaseAuto.interactable = false;
		}


		if (GameGlobals.rahe >= clickPrize) {
			clickIncrease.interactable = true;
		} else {
			clickIncrease.interactable = false;
		}

		if (GameGlobals.rahe >= ayyPrice) {
			buyAyy.interactable = true;
		} else {
			buyAyy.interactable = false;
		}

		if (GameGlobals.ayyyluminium >= rootPrice && autorahe1buy == false) {
			rootIncreaseButton.interactable = true;
		} else {
			rootIncreaseButton.interactable = false;
		}


	}

	void AutoRahe()
	{
		rahe = GameGlobals.GetRahe();
		rahe = rahe + rahePerSecond;
		GameGlobals.SetRahe (rahe);
		Invoke ("AutoRahe", GameGlobals.autoRahe);
	}

	public void SetAutoRahe()
	{
		int tempRahe;
		tempRahe = GameGlobals.GetRahe();

		tempRahe = tempRahe -20;
		GameGlobals.SetRahe(tempRahe);
		rahePerSecond ++;

		autorahe1buy = false;
		autoRahe1.interactable = false;
		
	}

	public void RootAutoRahe()
	{
		int tempAyy;
		tempAyy = GameGlobals.GetAyy();
		tempAyy = tempAyy - rootPrice;
		rahePerSecond ++;
		GameGlobals.SetAyy(tempAyy);
		rootPrice = rootPrice * 2;
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
		tempRahe = tempRahe - rahePrize;
		GameGlobals.SetRahe (tempRahe);

		rahePrize = rahePrize * newPrize;
		newPrize = newPrize * 2;

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
		tempRahe = tempRahe - clickPrize;
		GameGlobals.SetClick (click);
		clickPrize = clickPrize * 2;
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
}
